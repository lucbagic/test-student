using System.Collections.Generic;
using HotelRooms.Data.Entities;

namespace HotelRooms.Api.Responses.Guests
{
    public class GuestPaginatedResponse : BaseResponse
    {
        public GuestPaginatedResponse()
        {
            
        }

        public GuestPaginatedResponse(List<Guest> guests, int page, int count, int perPage)
        {
            Guests = guests;
            Count = count;
            PerPage = perPage;
            Page = page;
            Success = true;
        }

        public List<Guest> Guests { get; set; }
        public int Count { get; set; }
        public int PerPage { get; set; }
        public int Page { get; set; } = 1;
    }
}