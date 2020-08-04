using System;

namespace HotelRooms.Data.Entities
{
    public class AppModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}