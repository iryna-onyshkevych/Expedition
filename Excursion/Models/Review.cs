using System;

namespace Excursion.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ParticipantName { get; set; }
        public DateTime ReviewTime { get; set; }
        public string ParticipantReview { get; set; }
    }
}
