using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class RoomSeeder
    {
        public static void SeedRoom(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Room>().HasData(
                new Room{
                    Id = 1,
                    RoomTypeId = 1
                },
                new Room{
                    Id = 2,
                    RoomTypeId = 2
                },
                new Room{
                    Id = 3,
                    RoomTypeId = 2
                },
                new Room{
                    Id = 4,
                    RoomTypeId = 3
                },
                new Room{
                    Id = 5,
                    RoomTypeId = 4
                },
                new Room{
                    Id = 6,
                    RoomTypeId = 1
                },
                new Room{
                    Id = 7,
                    RoomTypeId = 2
                },
                new Room{
                    Id = 8,
                    RoomTypeId = 2
                },
                new Room{
                    Id = 9,
                    RoomTypeId = 3
                },
                new Room{
                    Id = 10,
                    RoomTypeId = 5
                },
                new Room{
                    Id = 11,
                    RoomTypeId = 1
                },
                new Room{
                    Id = 12,
                    RoomTypeId = 2
                },
                new Room{
                    Id = 13,
                    RoomTypeId = 3
                },
                new Room{
                    Id = 14,
                    RoomTypeId = 3
                },
                new Room{
                    Id = 15,
                    RoomTypeId = 4
                }
            );
        }
    }
}