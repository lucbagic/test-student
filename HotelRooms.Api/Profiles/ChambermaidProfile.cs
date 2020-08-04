using AutoMapper;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Models;

namespace HotelRooms.Data.Profiles
{
    public class ChambermaidProfile : Profile
    {
        public ChambermaidProfile()
        {

         /*   CreateMap<Chambermaid, ChambermaidDetailDTO>()
                .ForMember(
                    dest => dest.YearsTogether,
                    opt => opt.MapFrom(src => DateTime.Now.Year - src.DateOfCatch.Year));

            CreateMap<PokemonCreateDTO, Pokemon>()
                .ForMember(
                    dest => dest.DateOfCatch,
                    opt => opt.MapFrom(src => new DateTime(src.Year, src.Month, src.Day)));
            */ 

            CreateMap<Chambermaid, ChambermaidDetail>();
        }
    }
}