using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class RoomAmenities
    {
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }

        //Navigation Properties
        public Room Room { get; set; }
        public Amenities Amenities { get; set; }
    }
}
