using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Core.Repositories;
using HotelRooms.Data.Models;
using HotelRooms.Data.Entities;

namespace HotelRooms.Api.Controllers
{
    [ApiController]
    [Route("api/reservedRooms")]
    public class ReservedRoomController : AppController
    {
        private readonly IReservedRoomRepository reservedRoomRepository;
        
        private readonly IMapper mapper;

        public ReservedRoomController(
            IReservedRoomRepository reservedRoomRepository,
            IMapper mapper
        )
        {
            this.reservedRoomRepository = reservedRoomRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReservedRoomDetail>> GetreservedRoomss([FromQuery] string search)
        {
            var reservedRooms = this.reservedRoomRepository.GetAll(search);
            var reservedRoomsDTO = this.mapper.Map<IEnumerable<ReservedRoomDetail>>(reservedRooms);
            return Ok(reservedRoomsDTO);
        }

        [HttpGet("{id}")]
        public ActionResult<ReservedRoomDetail> GetreservedRoom(long id)
        {
            var reservedRoom = this.reservedRoomRepository.GetOne(id);
            var reservedRoomDTO = this.mapper.Map<ReservedRoomDetail>(reservedRoom);
            return Ok(reservedRoomDTO);
        }

        [HttpPost]
        public ActionResult<ReservedRoomDetail> CreateReservedRoom(ReservedRoom newReservedRoom)
        {
            var reservedRoom = this.mapper.Map<ReservedRoom>(newReservedRoom);
            reservedRoom = this.reservedRoomRepository.Create(reservedRoom);
            return this.mapper.Map<ReservedRoomDetail>(reservedRoom);
        }

        [HttpDelete("{id}")]
        public ActionResult<object> DeleteReservedRoom(long id)
        {
            return new { success = this.reservedRoomRepository.Delete(id) };
        }

        [HttpPut("{id}")]
        public ActionResult<ReservedRoomDetail> UpdateReservedRooms(long id, [FromBody] ReservedRoom updatedReservedRoom)
        {
            var reservedRoom = this.reservedRoomRepository.Update(id, updatedReservedRoom);
            var reservedRoomResult = this.mapper.Map<ReservedRoomDetail>(reservedRoom);
            return reservedRoomResult;
        }
    }
}