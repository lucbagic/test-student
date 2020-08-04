using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class CleaningStatusSeeder
    {
           public static void SeedCleaningStatus(this ModelBuilder modelBuilder){
            modelBuilder.Entity<CleaningStatus>().HasData(
                new CleaningStatus{
                    Id = 1,
                    Status = "Nespremljena"
                },
                new CleaningStatus{
                    Id = 2,
                    Status = "Trenutno se sprema"
                },
                new CleaningStatus{
                    Id = 3,
                    Status = "Zavrsena"
                }
            );
        }
    }
}