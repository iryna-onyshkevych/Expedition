using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class ForgotPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        public string Email { get; set; }
    }
}
