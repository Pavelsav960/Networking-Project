using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace Networking_Website.Models
{
    public class FlightTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Flight Type")]
        public string FlightType { get; set; }
    }
}
