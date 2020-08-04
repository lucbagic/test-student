using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class CleaningTypeSeeder
    {
        public static void SeedCleaningType(this ModelBuilder modelBuilder){
            modelBuilder.Entity<CleaningType>().HasData(
                new CleaningType{
                    Id = 1,
                    Type = "Generalna"
                },
                new CleaningType{
                    Id = 2,
                    Type = "Gostinjska"
                }
            );
        }
    }
}