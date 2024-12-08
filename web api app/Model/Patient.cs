﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace web_api_app.Model
{
    public class Patient
    {
        [Key]
        public int PID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } // Male or Female
        [JsonIgnore]
        public ICollection<Booking> Bookings { get; set; }
    }
}
