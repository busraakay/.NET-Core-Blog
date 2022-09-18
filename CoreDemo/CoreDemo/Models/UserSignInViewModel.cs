using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string password { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string username { get; set; }
    }
}
