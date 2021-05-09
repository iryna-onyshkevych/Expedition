using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class EditUserViewModel
    {
        [Required]
        public string Id { get; set; }

        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        public string Email { get; set; }
    }
}
