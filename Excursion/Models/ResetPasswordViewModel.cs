using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class ResetPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Пароль повинен містити як мінімум 6 символів", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Паролі не збігаються")]
        public string ConfirmPassword { get; set; }
        public string Code { get; set; }
    }
}
