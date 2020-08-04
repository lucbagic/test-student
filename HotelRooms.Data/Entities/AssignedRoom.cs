namespace HotelRooms.Data.Entities
{
    public class AssignedRoom : AppModel
    {
        public ReservedRoom ReservedRoom { get; set; }
        public long ReservedRoomId { get; set; }
        public CleaningType CleaningType { get; set; }
        public  long CleaningTypeId { get; set; }
        public Chambermaid Chambermaid { get; set; }
        public long ChambermaidId { get; set; }
        public CleaningStatus CleaningStatus { get; set; }
        public long CleaningStatusId { get; set; }
        public int BigTowels { get; set; }
        public int SmallTowels { get; set; }
        public int FootTowels { get; set; }
        public int Pillowcases { get; set; }
        public int SingleSheets { get; set; }
        public int DoubleSheets { get; set; }
        public int SingleDuvetCovers { get; set; }
        public int DoubleDuvetCovers { get; set; }
    }
}