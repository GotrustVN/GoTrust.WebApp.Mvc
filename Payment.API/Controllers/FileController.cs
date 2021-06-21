using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.API.Models;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Repositories;
using Payment.MiddleLayer.Processes;
using Payment.SharedModel.Common;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IGenericRepository<FileImport> genericFileImportRepository;
        private readonly IGenericRepository<FileType> genericFileTypeRepository;
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment hostEnvironment;

        public FileController(IGenericRepository<FileImport> genericFileImportRepository,
            IGenericRepository<FileType> genericFileTypeRepository,
            AppDbContext context,
            IWebHostEnvironment hostEnvironment)
        {
            this.genericFileImportRepository = genericFileImportRepository;
            this.genericFileTypeRepository = genericFileTypeRepository;
            this.context = context;
            this.hostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult<CommonResponse>> ImportCustomer([FromForm]ImportCustomerRequestModel request)
        {
            if (ModelState.IsValid)
            {
                if (!genericFileTypeRepository.IsExistById(request.fileTypeCode, out FileType fileType))
                {
                    ModelState.AddModelError("FileTypeError", "Invalid file type");
                    return BadRequest(ModelState);
                }

                if (request.uploadFile == null ||
                   request.uploadFile.Length <= 0)
                {
                    ModelState.AddModelError("FileUploadError", "Invalid upload file");
                    return BadRequest(ModelState);
                }

                if (!fileType.allowExtension.Contains(Path.GetExtension(request.uploadFile.FileName)))
                {
                    ModelState.AddModelError("FileExtensionError", "Invalid file extension. " + fileType.allowExtension);
                    return BadRequest(ModelState);
                }

                var directory = hostEnvironment.WebRootPath + AppGlobal.DefaultImportUploadDirectory;
                var fileName = request.uploadFile.FileName;

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var filePath = directory
                    + Path.GetFileNameWithoutExtension(fileName)
                    + AppGlobal.DefaultStringCode
                    + Path.GetExtension(fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await request.uploadFile.CopyToAsync(stream);
                }

                var fileImport = new FileImport()
                {
                    code = AppGlobal.DefaultStringCode,
                    fileName = fileName,
                    savePath = filePath,
                    type = fileType,
                };

                genericFileImportRepository.Insert(fileImport);

                bool importResult = ProcessCustomerLib.ImportCustomerData(filePath, context, out List<Customer> insertCustomers,
                    out List<Customer> updateCustomers, out string errorMessage);

                var respone = new CommonResponse();

                if (importResult)
                {
                    context.Customer.AddRange(insertCustomers);
                    context.Customer.UpdateRange(updateCustomers);
                    context.SaveChanges();

                    insertCustomers.AddRange(updateCustomers);

                    respone.SetResult(new CommonResult() { message = "Import success", code = "success" })
                        .SetData(insertCustomers);
                }
                else
                {
                    respone.SetResult(new CommonResult() { message = errorMessage, code = "error" });
                }

                return respone;
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<CommonResponse>> UploadFile([FromForm]UploadFileRequestModel request)
        {
            if(ModelState.IsValid)
            {
                if(!genericFileTypeRepository.IsExistById(request.fileTypeCode, out FileType fileType))
                {
                    ModelState.AddModelError("FileTypeError", "Invalid file type");
                    return BadRequest(ModelState);
                }

                if(request.uploadFile == null ||
                   request.uploadFile.Length <= 0)
                {
                    ModelState.AddModelError("FileUploadError", "Invalid upload file");
                    return BadRequest(ModelState);
                }

                if (!fileType.allowExtension.Contains(Path.GetExtension(request.uploadFile.FileName)))
                {
                    ModelState.AddModelError("FileExtensionError", "Invalid file extension. " + fileType.allowExtension);
                    return BadRequest(ModelState);
                }

                var directory = hostEnvironment.WebRootPath +  AppGlobal.DefaultImageUploadDirectory;
                var fileName = request.uploadFile.FileName;

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var filePath = directory
                    + Path.GetFileNameWithoutExtension(fileName)
                    + AppGlobal.DefaultStringCode
                    + Path.GetExtension(fileName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    await request.uploadFile.CopyToAsync(stream);
                }

                var fileImport = new FileImport()
                {
                    code = AppGlobal.DefaultStringCode,
                    fileName = fileName,
                    savePath = filePath,
                    type = fileType,
                    user = request.username
                };

                genericFileImportRepository.Insert(fileImport);

                int result = context.SaveChanges();
                var response = new CommonResponse();

                if(result > 0)
                {
                    response.GetCreateSuccessResponse("file import")
                        .SetData(fileImport);
                }
                else
                {
                    response.GetCreateFailedResponse("file import");
                }

                return response;

            }
            return BadRequest(ModelState);
        }
    }
}
