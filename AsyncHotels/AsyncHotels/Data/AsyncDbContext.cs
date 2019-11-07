using AsyncHotels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncHotels.Data
{
    public class AsyncDbContext : DbContext
    {
        public AsyncDbContext(DbContextOptions<AsyncDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(hotelRoom =>
           new { hotelRoom.HotelID, hotelRoom.RoomID });

            modelBuilder.Entity<RoomAmenities>().HasKey(roomAmenities =>
            new { roomAmenities.AmenitiesID, roomAmenities.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    HotelName = "Bubbles Inn",
                    StreetAdress = "1st street",
                    City = "Omaha",
                    State = "Idaho",
                    Phone = "111-111-1111"
                },
                new Hotel
                {
                    ID = 2,
                    HotelName = "Cuddles Inn",
                    StreetAdress = "2nd street",
                    City = "Springfield",
                    State = "Ohio",
                    Phone = "222-222-2222"
                },
                new Hotel
                {
                    ID = 3,
                    HotelName = "Puddles Inn",
                    StreetAdress = "3rd street",
                    City = "San Antonio",
                    State = "Texas",
                    Phone = "333-333-3333"
                },
                new Hotel
                {
                    ID = 4,
                    HotelName = "Dubbles Inn",
                    StreetAdress = "4th street",
                    City = "Enumclaw",
                    State = "Washington",
                    Phone = "444-444-44444"
                },
                new Hotel
                {
                    ID = 5,
                    HotelName = "Wubbles Inn",
                    StreetAdress = "5th street",
                    City = "Las Vegas",
                    State = "Nevada",
                    Phone = "555-555-5555"
                }
                );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Nickname = "People's Republic of Ninight",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 2,
                    Nickname = "Candle Light",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 3,
                    Nickname = "Pumperschniquel",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 4,
                    Nickname = "Live, Laugh, Love",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 5,
                    Nickname = "Chicken Pot Pie",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 6,
                    Nickname = "Smells like Christmas",
                    Layout = Layout.TwoBedroom
                }
                );
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Amenity = "Massage bed"
                },
                new Amenities
                {
                    ID = 2,
                    Amenity = "Turbo shower"
                },
                new Amenities
                {
                    ID = 3,
                    Amenity = "Hands-Free wipe toilet"
                },
                new Amenities
                {
                    ID = 4,
                    Amenity = "Holographic phone"
                },
                new Amenities
                {
                    ID = 5,
                    Amenity = "Botomless Hummus"
                }
                );
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
