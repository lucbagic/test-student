using System;

namespace HotelRooms.Data.Entities
{
    public class ReservedRoom : AppModel
    {
        public Room Room { get; set; }
        public long RoomId { get; set; }
        public Guest Guest { get; set; }
        public long GuestId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}