using AsyncHotels.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces.Services
{
    public class RoomService : IRoomManager
    {
        private AsyncDbContext _context;

        public RoomService(AsyncDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoom(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoom(int id)
        {
            Room room = await GetRoomById(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomById(int id) => await _context.Rooms.FirstOrDefaultAsync(rom => rom.ID == id);
        

        public async Task<List<Room>> GetRooms()
        {
            List<Room> rooms = await _context.Rooms.ToListAsync();
            return rooms;
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
