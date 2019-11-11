using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Models.Interfaces
{
    public interface IRoomManager
    {
        //Create
        Task CreateRoom(Room room);

        //Read
        Task<Room> GetRoomById(int id);

        Task<List<Room>> GetRooms();

        //Update
        Task UpdateRoom(Room room);

        //Delete
        Task DeleteRoom(int id);

    }
}

