using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models
{
    public class ChangePasswordRequestModel
    {
        [Required(ErrorMessage = "Tên đăng nhập không hợp lệ")]
        public string username { get; set; }
        [Required(ErrorMessage = "Mật khẩu cũ không được để trống")]
        public string oldPassword { get; set; }
        [Required(ErrorMessage = "Mật khẩu cũ không được để trống")]
        public string newPassword { get; set; }
        [Required(ErrorMessage = "Mật khẩu cũ không được để trống")]
        [Compare(nameof(newPassword), ErrorMessage = "Mật khẩu không khớp")]
        public string confirmNewPassword { get; set; }

    }
}
