using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class CreateUserViewModel
    {
        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть пароль!")]
        public string Password { get; set; }
    }
}
