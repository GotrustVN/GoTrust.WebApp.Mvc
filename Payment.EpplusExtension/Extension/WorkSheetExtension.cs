using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Payment.EpplusExtension.Extension
{
    public static class WorkSheetExtension
    {
        public static DataTable ToDataTable(this ExcelWorksheet worksheet, bool hasHeader = true)
        {
            DataTable tbl = new DataTable();
            foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (int rowNum = startRow; rowNum <= worksheet.Dimension.End.Row; rowNum++)
            {
                var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                DataRow row = tbl.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }
            return tbl;
        }
    }
}
