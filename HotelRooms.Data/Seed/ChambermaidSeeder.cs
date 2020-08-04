using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class ChambermaidSeeder
    {
        public static void SeedChambermaid(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Chambermaid>().HasData(
                new Chambermaid{
                    Id = 1,
                    Name = "Ivana",
                    LastName = "Ivić"
                },
                new Chambermaid{
                    Id = 2,
                    Name = "Matea",
                    LastName = "Matić"
                },
                new Chambermaid{
                    Id = 3,
                    Name = "Lara",
                    LastName = "Lorić"
                }
            );
        }
    }
}