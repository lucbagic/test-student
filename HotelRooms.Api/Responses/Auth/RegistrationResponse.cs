using HotelRooms.Data.Entities;

namespace HotelRooms.Api.Responses
{
    public class RegistrationResponse
    {
        public string Token { get; set; }
        public AppUser User { get; set; }

        public RegistrationResponse(AppUser user, string token)
        {
            this.User = user;
            this.Token = token;
        }
    }
}