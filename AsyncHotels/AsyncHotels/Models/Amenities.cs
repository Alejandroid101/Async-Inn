using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class Amenities
    {
        public int ID { get; set; }
        public string Amenity { get; set; }

        //Navigation Properties
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
