using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Core.Repositories;
using HotelRooms.Data.Models;
using HotelRooms.Data.Entities;

namespace HotelRooms.Api.Controllers
{
    [ApiController]
    [Route("api/assignedRooms")]
    public class AssignedRoomController : AppController
    {
        private readonly IAssignedRoomRepository AssignedRoomRepository;
        
        private readonly IMapper mapper;

        public AssignedRoomController(
            IAssignedRoomRepository AssignedRoomRepository,
            IMapper mapper
        )
        {
            this.AssignedRoomRepository = AssignedRoomRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AssignedRoomDetail>> GetAssignedRooms([FromQuery] string search)
        {
            var assignedRoom = this.AssignedRoomRepository.GetAll(search);
            var assignedRoomDTO = this.mapper.Map<IEnumerable<AssignedRoomDetail>>(assignedRoom);
            return Ok(assignedRoomDTO);
        }

        [HttpGet("{id}")]
        public ActionResult<AssignedRoomDetail> GetAssignedRoom(long id)
        {
            var assignedRoom = this.AssignedRoomRepository.GetOne(id);
            var assignedRoomDTO = this.mapper.Map<AssignedRoomDetail>(assignedRoom);
            return Ok(assignedRoomDTO);
        }

        [HttpPost]
        public ActionResult<AssignedRoomDetail> CreateAssignedRoom(AssignedRoom newAssignedRoom)
        {
            var assignedRoom = this.mapper.Map<AssignedRoom>(newAssignedRoom);
            assignedRoom = this.AssignedRoomRepository.Create(assignedRoom);
            return this.mapper.Map<AssignedRoomDetail>(assignedRoom);
        }

        [HttpDelete("{id}")]
        public ActionResult<object> DeleteAssignedRoom(long id)
        {
            return new { success = this.AssignedRoomRepository.Delete(id) };
        }

        [HttpPut("{id}")]
        public ActionResult<AssignedRoomDetail> UpdateAssignedRoom(long id, [FromBody] AssignedRoom updatedAssignedRoom)
        {
            var assignedRoom = this.AssignedRoomRepository.Update(id, updatedAssignedRoom);
            var assignedRoomResult = this.mapper.Map<AssignedRoomDetail>(assignedRoom);
            return assignedRoomResult;
        }
    }
}