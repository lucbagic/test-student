using AutoMapper;
using HotelRooms.Data.Entities;
using HotelRooms.Api.Requests;

namespace HotelRooms.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegistrationRequest, AppUser>().ReverseMap();
        }
    }
}