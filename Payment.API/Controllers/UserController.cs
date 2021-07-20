using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Payment.API.Models;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.SharedModel.Common;
using Payment.SharedUltilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<User> genericUserRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public UserController(IGenericRepository<User> genericUserRepository,
            IUserRepository userRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.genericUserRepository = genericUserRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.context = context;
        }

        [HttpPost]
        public ActionResult<CommonResponse> Authenticate(AuthenticateRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var user = genericUserRepository.GetByID(model.username);
                if(user != null)
                {
                    if(SecurityHelper.Encrypt(user.hashkey, model.password) == user.password)
                    {
                        var authenticateResponseData = new AuthenticateResponseDataModel()
                        {
                            username = user.username,
                            accessToken = ClaimHelper.GenerateTokenStringForClaims(new Dictionary<string, string>() 
                            {
                                { "email", user.email },
                                { "phone", user.phone }
                            }),
                            customerCode = user.customerCode
                        };

                        return new CommonResponse()
                            .SetResult(new CommonResult() { code = "success", message = "" })
                            .SetData(authenticateResponseData);
                    }
                    else
                    {
                        ModelState.AddModelError("password", "Mật khẩu không hợp lệ");
                    }
                }
                else
                {
                    ModelState.AddModelError("username", "Tên đăng nhập không tồn tại");
                }
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public ActionResult<CommonResponse> Register(RegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);

                if (userRepository.IsExistUserWithEmail(model.email, out User existUser))
                {
                    ModelState.AddModelError("Error", "Email was used");
                    return BadRequest(ModelState);
                }

                user.SetPassword();

                var response = new CommonResponse();

                genericUserRepository.Insert(user);
                try
                {
                    context.SaveChanges();
                    response.SetData(model);
                }
                catch (DbUpdateException ex)
                {
                    response.SetResult(new CommonResult()
                    {
                        code = "error",
                        message = ex.Message
                    });
                }

                return response;
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult<CommonResponse> ChangePassword(ChangePasswordRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var user = genericUserRepository.GetByID(model.username);
                if (user != null)
                {
                    if (SecurityHelper.Encrypt(user.hashkey, model.oldPassword) == user.password)
                    {
                        user.password = model.newPassword;
                        user.SetPassword();
                        genericUserRepository.Update(user);
                        context.SaveChanges();

                        return new CommonResponse()
                            .SetResult(new CommonResult()
                            {
                                code = "success",
                                message = ""
                            });
                    }
                    else
                    {
                        ModelState.AddModelError("password", "Mật khẩu cũ không hợp lệ");
                    }
                }
                else
                {
                    ModelState.AddModelError("username", "Tên đăng nhập không tồn tại");
                }
            }
            return BadRequest(ModelState);
        }
    }
}
