using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Networking_Website.Models
{
    public class Flights
    {
        public int Id { get; set; }
        [Display(Name = "From")]
        public string OriginCountry { get; set; }
        [Display(Name = "To")]
        public string DestinationCountry { get; set; }
        [Display(Name ="Price(NIS)")]
        public decimal Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool IsDirect { get; set; }
        public bool IsOneWay { get; set; }

    }
}
