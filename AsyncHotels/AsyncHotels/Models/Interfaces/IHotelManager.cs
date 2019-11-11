using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces
{
    public interface IHotelManager
    {
        //Create
        Task CreateHotel(Hotel hotel);

        //Read
        Task<Hotel> GetHotelById(int id);

        Task<List<Hotel>> GetHotels();

        //Update
        Task UpdateHotel(Hotel hotel);

        //Delete
        Task DeleteHotel(int id);

    }
}

