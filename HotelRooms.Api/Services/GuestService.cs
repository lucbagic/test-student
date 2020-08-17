using AutoMapper;
using HotelRooms.Api.Requests.Guests;
using HotelRooms.Api.Responses.Guests;
using HotelRooms.Core.Repositories;

namespace HotelRooms.Api.Services
{
    public interface IGuestService
    {
        GuestPaginatedResponse GetPaginatedResponse(PaginatedGuestRequest request);
    }
    public class GuestService : IGuestService
    {
        private readonly IGuestRepository guestRepository;
        private readonly IMapper mapper;

        public GuestService(
            IGuestRepository guestRepository,
            IMapper mapper
        )
        {
            this.guestRepository = guestRepository;
            this.mapper = mapper;
        }

        public GuestPaginatedResponse GetPaginatedResponse(PaginatedGuestRequest request)
        {
            var guests = this.guestRepository.GetPaginatedGuests(
                request.Page,
                request.Search,
                request.Sort
            );

            /* SELECT COUNT(*) FROM protests WHERE title LIKE '' ... */
            int count = this.guestRepository.Count(request.Search);

            var response = new GuestPaginatedResponse(guests, request.Page, count, this.guestRepository.PerPage);
            return response;
        }
    }
}