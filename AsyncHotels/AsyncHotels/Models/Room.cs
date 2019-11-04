using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models
{
    public class Room
    {
        public string Nickname { get; set; }
        public Layout Layout { get; set; }
    }

    public enum Layout
    {
        Sturio = 0,
        OneBedroom = 1,
        TwoBedroom = 2
    }
}
