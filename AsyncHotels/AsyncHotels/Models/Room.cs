using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public Layout Layout { get; set; }

        //Navigation Properties
        public ICollection<HotelRoom> HotelRoom { get; set; }
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }


    public enum Layout
    {
        Studio = 0,
        OneBedroom = 1,
        TwoBedroom = 2
    }
}
