using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
