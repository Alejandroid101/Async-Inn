using AsyncHotels.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces.Services
{
    public class AmenitiesService : IAmenitiesManager
    {
        private AsyncDbContext _context;

        public AmenitiesService(AsyncDbContext context)
        {
            _context = context;
        }
        public async Task CreateAmenities(Amenities amenity)
        {
            await _context.Amenities.AddAsync(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenities(int id)
        {
            Amenities amenity = await GetAmenitiesById(id);
            _context.Amenities.Remove(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<Amenities> GetAmenitiesById(int id) => await _context.Amenities.FirstOrDefaultAsync(amts => amts.ID == id);
        
        public async Task<List<Amenities>> GetAmenity()
        {
            List<Amenities> amenities = await _context.Amenities.ToListAsync();
            return amenities;
        }

        public async Task UpdateAmenities(Amenities amenity)
        {
            _context.Amenities.Update(amenity);
            await _context.SaveChangesAsync();
        }
    }
}
