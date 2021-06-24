using OfficeOpenXml;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.EpplusExtension.Extension;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace Payment.MiddleLayer.Processes
{
    public class ProcessCustomerLib
    {
        public static IEnumerable<Province> provinces { get; set; }
        public static IEnumerable<District> districts { get; set; }
        public static IEnumerable<Ward> wards { get; set; }
        public static IEnumerable<Gender> genders { get; set; }
        public static IEnumerable<CustomerType> customerTypes { get; set; }
        public static IEnumerable<string> customerCodes { get; set; }
        public static bool ImportCustomerData(string filePath, AppDbContext context,
            out List<Customer> insertCustomers, out List<Customer> updateCustomers, out string errorMessage)
        {
            bool result = false;
            errorMessage = string.Empty;
            insertCustomers = new List<Customer>();
            updateCustomers = new List<Customer>();

            if (!File.Exists(filePath))
            {
                errorMessage = "File not exist";
                return result;
            }

            if(Path.GetExtension(filePath) != ".xlsx")
            {
                errorMessage = "Can not read file. Support only .xlsx file";
                return result;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo fileInfo = new FileInfo(filePath);
            CachePropertyData(context);

            using (var package = new ExcelPackage(fileInfo))
            {
                if (package.Workbook.Worksheets.Count > 0)
                {
                    var workSheet = package.Workbook.Worksheets[0];
                    DataTable table = workSheet.ToDataTable();

                    foreach(DataRow row in table.Rows)
                    {
                        var customer = new Customer();

                        if(!string.IsNullOrEmpty(row["Mã tỉnh"].ToString()))
                        {
                            string provinceCode = row["Mã tỉnh"].ToString();
                            var province = provinces.FirstOrDefault(x => x.code == provinceCode);
                            
                            if(province != null)
                            {
                                customer.province = province;
                            }
                            else
                            {
                                errorMessage = "Invalid province code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }

                        if (!string.IsNullOrEmpty(row["Mã huyện"].ToString()))
                        {
                            string districtCode = row["Mã huyện"].ToString();
                            var district = districts.FirstOrDefault(x => x.code == districtCode);

                            if (district != null)
                            {
                                customer.district = district;
                            }
                            else
                            {
                                errorMessage = "Invalid district code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }

                        if (!string.IsNullOrEmpty(row["Mã xã"].ToString()))
                        {
                            string wardCode = row["Mã xã"].ToString();
                            var ward = wards.FirstOrDefault(x => x.code == wardCode);

                            if (ward != null)
                            {
                                customer.ward = ward;
                            }
                            else
                            {
                                errorMessage = "Invalid ward code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }

                        if (!string.IsNullOrEmpty(row["Phân loại"].ToString()))
                        {
                            string customerTypeCode = row["Phân loại"].ToString();
                            var customerType = customerTypes.FirstOrDefault(x => x.code == customerTypeCode);

                            if (customerType != null)
                            {
                                customer.type = customerType;
                            }
                            else
                            {
                                errorMessage = "Invalid customer type code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }
                        else
                        {
                            errorMessage = "Invalid customer type at line " + table.Rows.IndexOf(row);
                            return result;
                        }

                        if (!string.IsNullOrEmpty(row["Giới tính"].ToString()))
                        {
                            string genderCode = row["Giới tính"].ToString();
                            var gender = genders.FirstOrDefault(x => x.code == genderCode);

                            if (gender != null)
                            {
                                customer.gender = gender;
                            }
                            else
                            {
                                errorMessage = "Invalid customer gender code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }
                        else
                        {
                            errorMessage = "Invalid customer gender at line " + table.Rows.IndexOf(row);
                            return result;
                        }

                        customer.name = row["Họ và tên"].ToString();
                        customer.dateOfBirth = DateTime.ParseExact(row["Ngày sinh"].ToString(), "dd/MM/yyyy", null);
                        customer.identityNumber = row["CMND/CCCD/HC"].ToString();
                        customer.identityPlace = row["Nơi cấp"].ToString();
                        customer.identityDate = DateTime.ParseExact(row["Ngày cấp"].ToString(), "dd/MM/yyyy", null);
                        customer.phone = row["Điện thoại"].ToString();
                        customer.email = row["Email"].ToString();
                        customer.fax = row["Số fax"].ToString();
                        customer.taxCode = row["Mã số thuế"].ToString();
                        customer.note = row["Ghi chú"].ToString();
                        customer.address = row["Số nhà"].ToString();
                        customer.nationality = row["Dân tộc"].ToString();

                        customer.SetFullAddress();

                        if(string.IsNullOrEmpty(row["Mã khách hàng"].ToString()))
                        {
                            customer.SetDefaultValue();
                            insertCustomers.Add(customer);
                        }
                        else
                        {
                            string customerCode = customerCodes.FirstOrDefault(x => x == row["Mã khách hàng"].ToString());
                            
                            if (!string.IsNullOrEmpty(customerCode))
                            {
                                customer.code = customerCode;
                                updateCustomers.Add(customer);
                            }
                            else
                            {
                                errorMessage = "Invalid customer code at line " + table.Rows.IndexOf(row);
                                return result;
                            }
                        }
                    }
                }
                else
                {
                    errorMessage = "File not exist";
                    return result;
                }
            }

            return true;
        }

        public static byte[] GenerateQRCode(string code, string logoPath = "")
        {
            var text = AppGlobal.DefaultCustomerDetailRequestUrl + code;

            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions()
            {
                Width = 300,
                Height = 300,
                Margin = 0,
                PureBarcode = false,
            };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(text);
            Bitmap logo = new Bitmap(logoPath);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(logo, new Point((bitmap.Width - logo.Width) /2, (bitmap.Height - logo.Height) / 2));

            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public static void CachePropertyData(AppDbContext context)
        {
            if(provinces == null ||
               provinces.Count() == 0)
            {
                provinces = context.Province.ToList();
            }

            if(districts == null ||
               districts.Count() == 0)
            {
                districts = context.District.ToList();
            }

            if (wards == null ||
                wards.Count() == 0)
            {
                wards = context.Ward.ToList();
            }

            if (genders == null ||
                genders.Count() == 0)
            {
                genders = context.Gender.ToList();
            }

            if (customerTypes == null ||
                customerTypes.Count() == 0)
            {
                customerTypes = context.CustomerType.ToList();
            }

            if (customerCodes == null ||
                customerCodes.Count() == 0)
            {
                customerCodes = context.Customer.Select(x  => x.code).ToList();
            }
        }
    }
}
