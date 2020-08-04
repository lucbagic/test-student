
using System;
using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class ReservedRoomSeeder
    {
         public static void SeedReservedRoom(this ModelBuilder modelBuilder){
            modelBuilder.Entity<ReservedRoom>().HasData(
                new ReservedRoom{
                    Id = 1,
                    RoomId = 1,
                    GuestId = 1,
                    ArrivalDate = new DateTime(2020, 07, 20),
                    DepartureDate = new DateTime(2020, 07, 28)
                },
                new ReservedRoom{
                    Id = 2,
                    RoomId = 2,
                    GuestId = 2,
                    ArrivalDate = new DateTime(2020, 07, 15),
                    DepartureDate = new DateTime(2020, 07, 30)
                },
                new ReservedRoom{
                    Id = 3,
                    RoomId = 3,
                    GuestId = 3,
                    ArrivalDate = new DateTime(2020, 07, 24),
                    DepartureDate = new DateTime(2020, 07, 28)
                },
                new ReservedRoom{
                    Id = 4,
                    RoomId = 4,
                    GuestId = 4,
                    ArrivalDate = new DateTime(2020, 07, 25),
                    DepartureDate = new DateTime(2020, 07, 29)
                },
                new ReservedRoom{
                    Id = 5,
                    RoomId = 5,
                    GuestId = 5,
                    ArrivalDate = new DateTime(2020, 08, 02),
                    DepartureDate = new DateTime(2020, 08, 06)
                },
                new ReservedRoom{
                    Id = 6,
                    RoomId = 6,
                    GuestId = 6,
                    ArrivalDate = new DateTime(2020, 08, 01),
                    DepartureDate = new DateTime(2020, 08, 04)
                },
                new ReservedRoom{
                    Id = 7,
                    RoomId = 7,
                    GuestId = 7,
                    ArrivalDate = new DateTime(2020, 08, 03),
                    DepartureDate = new DateTime(2020, 08, 15)
                },
                new ReservedRoom{
                    Id = 8,
                    RoomId = 8,
                    GuestId = 8,
                    ArrivalDate = new DateTime(2020, 07, 22),
                    DepartureDate = new DateTime(2020, 08, 26)
                },
                new ReservedRoom{
                    Id = 9,
                    RoomId = 9,
                    GuestId = 9,
                    ArrivalDate = new DateTime(2020, 07, 25),
                    DepartureDate = new DateTime(2020, 08, 30)
                }
            );
        }
    }
}