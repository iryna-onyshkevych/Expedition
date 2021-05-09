using System;
using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class Review
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть ім'я!")]
        public string ParticipantName { get; set; }

        [Required]
        public DateTime ReviewTime { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть відгук!")]
        public string ParticipantReview { get; set; }
    }
}
