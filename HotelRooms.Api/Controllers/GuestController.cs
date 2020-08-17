using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;
using HotelRooms.Core.Repositories;
using HotelRooms.Api.Responses.Guests;
using HotelRooms.Api.Requests.Guests;
using HotelRooms.Api.Services;

namespace HotelRooms.Api.Controllers
{

    [ApiController]
    [Route("api/guests")]
    public class GuestController : AppController
    {
        private readonly IGuestRepository guestRepository;

        private readonly IGuestService guestService;
        private readonly IMapper mapper;

        public GuestController(
            IGuestRepository guestRepository,
            IGuestService guestService,
            IMapper mapper
        )
        {
            this.guestService = guestService;
            this.guestRepository = guestRepository;
            this.mapper = mapper;
        }

        /*
        [HttpGet]
        public ActionResult<IEnumerable<Guest>> GetGuests([FromQuery] string search)
        {
            var guests = this.guestRepository.GetAll(search);
            return Ok(guests);
        }
     */
        [HttpGet]
        public ActionResult<GuestPaginatedResponse> GetPaginatedGuests([FromQuery] PaginatedGuestRequest request)
        {
            var guests = this.guestService.GetPaginatedResponse(request);
            return Ok(guests);
        }


        [HttpGet("{id}")]
        public ActionResult<Guest> GetGuest(long id){
            var guest = this.guestRepository.GetOne(id);
            return guest;
        }

        [HttpPost]
        public ActionResult<Guest> CreateGuest(Guest newGuest)
        {
            var guest = this.guestRepository.Create(newGuest);
            return guest;
        }

        [HttpDelete("{id}")]
        public ActionResult<object> DeleteGuest(long id)
        {
            return new { success = this.guestRepository.Delete(id) };
        }

        [HttpPatch("{id}")]
        public ActionResult<Guest> Patch(long id, [FromBody]JsonPatchDocument<Guest> doc)
        {
            var guest = this.guestRepository.GetOne(id);
            this.guestRepository.Patch(id, doc);
            return Ok(guest);
        }

    }
}