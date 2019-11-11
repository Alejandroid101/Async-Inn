using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        //Create
        Task CreateAmenities(Amenities amenity);

        //Read
        Task <Amenities> GetAmenitiesById(int id);

        Task<List<Amenities>> GetAmenity();

        //Update
        Task UpdateAmenities(Amenities amenity);

        //Delete
        Task DeleteAmenities(int id);

    }
}
