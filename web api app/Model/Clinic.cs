using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace web_api_app.Model
{
    public class Clinic
    {
        [Key]
        public int CID { get; set; }
        public string Specialization { get; set; } // Unique
        public int NumberOfSlots { get; set; } // Max 20
        [JsonIgnore]
        public ICollection<Booking> Bookings { get; set; }
    }
}
