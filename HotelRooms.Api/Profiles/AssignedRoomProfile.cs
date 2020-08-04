using AutoMapper;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Models;

namespace HotelRooms.Data.Profiles
{
    public class AssignedRoomProfile : Profile
    {
        public AssignedRoomProfile()
        {
            CreateMap<AssignedRoom, AssignedRoomDetail>();
        }
    }
}