using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string HotelName { get; set; }
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

        //Navigation Properties
        public ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
