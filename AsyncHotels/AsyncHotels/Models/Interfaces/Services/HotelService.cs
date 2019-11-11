using AsyncHotels.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces.Services
{
    public class HotelService : IHotelManager
    {
        private AsyncDbContext _context;

        public HotelService(AsyncDbContext context)
        {
            _context = context;
        }
        public async Task CreateHotel(Hotel hotel)
        {
            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotel(int id)
        {
            Hotel hotel = await GetHotelById(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> GetHotelById(int id) => await _context.Hotels.FirstOrDefaultAsync(htl => htl.ID == id);
        

        public async Task<List<Hotel>> GetHotels()
        {
            List<Hotel> hotels = await _context.Hotels.ToListAsync();
            return hotels;
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
