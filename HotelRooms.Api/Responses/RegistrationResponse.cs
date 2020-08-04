using HotelRooms.Data.Entities;

namespace HotelRooms.Api.Responses
{
    public class RegistrationResponse
    {
        public string Token { get; set; }
        public AppUser User { get; set; }
    }
}