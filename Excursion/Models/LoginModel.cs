using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class LoginModel
    {
        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        [Display(Name = "Пошта")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
