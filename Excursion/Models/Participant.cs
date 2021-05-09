using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class Participant
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть ім'я!")]
        public string ParticipantName { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть прізвище!")]
        public string ParticipantSurname { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть номер телефону!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть коректну кількість учасників!")]
        public int ParticipantsNumber { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть початкову точку!")]
        public string FirstPoint { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть кінцеву точку!")]
        public string LastPoint { get; set; }

        [EmailAddress(ErrorMessage = "Некоректний запис пошти!")]
        [Required(ErrorMessage = "Будь ласка, введіть пошту!")]
        public string Email { get; set; }
    }
}
