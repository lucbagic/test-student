using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class RoomTypeSeeder
    {
        public static void SeedRoomType(this ModelBuilder modelBuilder){
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType{
                    Id = 1,
                    Type = "1SB",
                    Description = "One single bed"
                },
                new RoomType{
                    Id = 2,
                    Type = "2SB",
                    Description = "Two single beds"
                },
                new RoomType{
                    Id = 3,
                    Type = "1DB",
                    Description = "One double bed"
                },
                new RoomType{
                    Id = 4,
                    Type = "3SB",
                    Description = "Three single beds"
                },
                new RoomType{
                    Id = 5,
                    Type = "1DB1SB",
                    Description = "One double bed and one single bed"
                }
            );
        }
    }
}