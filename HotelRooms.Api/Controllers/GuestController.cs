using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;
using HotelRooms.Core.Repositories;

namespace HotelRooms.Api.Controllers
{

    [ApiController]
    [Route("api/guests")]
    public class GuestController : AppController
    {
        private readonly IGuestRepository guestRepository;

        public GuestController(IGuestRepository guestRepository)
        {
            this.guestRepository = guestRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Guest>> GetGuests([FromQuery] string search)
        {
            var guests = this.guestRepository.GetAll(search);
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

        [HttpPut("{id}")]
        public ActionResult<Guest> UpdateChambermaid(long id, [FromBody] Guest updatedGuest)
        {
            var guest = this.guestRepository.Update(id, updatedGuest);
            return guest;
        }

        [HttpPatch("{id}")]
        public ActionResult<Guest> Patch(int id, [FromBody]JsonPatchDocument<Guest> doc)
        {
            var guest = this.guestRepository.GetOne(id);
            this.guestRepository.Patch(id, doc);
            return Ok(guest);
        }

    }
}