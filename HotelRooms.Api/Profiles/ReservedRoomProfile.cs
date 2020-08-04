using AutoMapper;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Models;

namespace HotelRooms.Data.Profiles
{
    public class ReservedRoomProfile : Profile
    {
        public ReservedRoomProfile()
        {
            CreateMap<ReservedRoom, ReservedRoomDetail>();
        }
    }
}