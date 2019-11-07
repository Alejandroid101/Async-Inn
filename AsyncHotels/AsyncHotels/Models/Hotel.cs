using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string StreetAdress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Phone { get; set; }

        //Navigation Properties
        public ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
