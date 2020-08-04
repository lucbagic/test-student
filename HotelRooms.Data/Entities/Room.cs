namespace HotelRooms.Data.Entities
{
    public class Room : AppModel
    {
        public RoomType RoomType { get; set; }
        public long RoomTypeId { get; set; }
        public bool isRenting { get; set; } = true;
    }
}