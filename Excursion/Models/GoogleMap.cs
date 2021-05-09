using System;
using System.ComponentModel.DataAnnotations;

namespace Excursion.Models
{
    public class GoogleMap
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть адресу!")]
        public string MapAddress { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть широту!")]
        public string Lat { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть довготу!")]
        public string Long { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть опис!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть початкову дату!")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, введіть кінцеву дату!")]
        public DateTime FinishDate { get; set; }

        [Required]
        public bool Active { get; set; }
    }
}
