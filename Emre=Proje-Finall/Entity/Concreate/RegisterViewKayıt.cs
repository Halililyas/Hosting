using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class RegisterViewKayıt
    {
        [Required(ErrorMessage = "Lütfen ad girini")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail giriniz")]

        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen telefon giriniz")]
        public string PhoneNumber { get; set; }
    }
}
