using HotelRooms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Data.Seed
{
    public static class GuestSeeder
    {
        public static void SeedGuest(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Guest>().HasData(
                new Guest{
                    Id = 1,
                    Name = "Morgan",
                    LastName = "Adams",
                    Email = "morgan@mailinator.com"
                },
                new Guest{
                    Id = 2,
                    Name = "Petar",
                    LastName = "Tuker",
                    Email = "petar@mailinator.com"
                },
                new Guest{
                    Id = 3,
                    Name = "Simona",
                    LastName = "Horvat",
                    Email = "simona@mailinator.com"
                },
                new Guest{
                    Id = 4,
                    Name = "Ivan",
                    LastName = "Alton",
                    Email = "ivanalton@mailinator.com"
                },
                new Guest{
                    Id = 5,
                    Name = "Morgan",
                    LastName = "Adams",
                    Email = "morgan@mailinator.com"
                },
                new Guest{
                    Id = 6,
                    Name = "Claudia",
                    LastName = "Hebert",
                    Email = "claudia@mailinator.com"
                },
                new Guest{
                    Id = 7,
                    Name = "Salvatore",
                    LastName = "Singh",
                    Email = "salvatore@mailinator.com"
                },
                new Guest{
                    Id = 8,
                    Name = "Misty",
                    LastName = "Porter",
                    Email = "misty@mailinator.com"
                },
                new Guest{
                    Id = 9,
                    Name = "Brett",
                    LastName = "Mendoza",
                    Email = "mendoza@mailinator.com"
                },
                new Guest{
                    Id = 10,
                    Name = "Wilfred",
                    LastName = "Abel",
                    Email = "abel@mailinator.com"
                }
            );
        }
    }
}