using System;
using HotelRooms.Data.Entities;

namespace HotelRooms.Data.Models
{
    public class ReservedRoomDetail
    {
        public long Id { get; set; }
        public Room Room { get; set; }
        public long RoomId { get; set; }
        public Guest Guest { get; set; }
        public long GuestId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
   
    }
}