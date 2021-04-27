using System;

namespace Excursion.Models
{
    public class GoogleMap
    {
        public int Id { get; set; }
        public string MapAddress { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
    }
}
