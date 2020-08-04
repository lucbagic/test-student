using Microsoft.EntityFrameworkCore;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Seed;

namespace HotelRooms.Data.Database
{
    public class ApplicationContext : DbContext
    {
             public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<AssignedRoom> AssignedRooms { get; set; }
        public DbSet<Chambermaid> Chambermaids { get; set; }
        public DbSet<CleaningStatus> CleaningStatuses { get; set; }
        public DbSet<CleaningType> CleaningTypes { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<ReservedRoom> ReservedRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedCleaningType();
            modelBuilder.SeedChambermaid();
            modelBuilder.SeedCleaningStatus();
            modelBuilder.SeedGuest();
            modelBuilder.SeedRoomType();
            modelBuilder.SeedRoom();
            modelBuilder.SeedReservedRoom();
        }
    }
}