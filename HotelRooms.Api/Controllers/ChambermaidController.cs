using System.Collections.Generic;
using AutoMapper;
using HotelRooms.Core.Repositories;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelRooms.Api.Controllers
{

    [ApiController]
    [Route("api/chambermaids")]
    public class ChambermaidController : AppController
    {
        private readonly IChambermaidRepository chambermaidRepository;
        
        private readonly IMapper mapper;

        public ChambermaidController(
            IChambermaidRepository chambermaidRepository,
            IMapper mapper
        )
        {
            this.chambermaidRepository = chambermaidRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ChambermaidDetail>> GetChambermaids([FromQuery] string search)
        {
            var chambermaid = this.chambermaidRepository.GetAll(search);
            var chambermaidDTO = this.mapper.Map<IEnumerable<ChambermaidDetail>>(chambermaid);
            return Ok(chambermaidDTO);
        }

        [HttpGet("{id}")]
        public ActionResult<ChambermaidDetail> GetChambermaid(long id)
        {
            var chambermaid = this.chambermaidRepository.GetOne(id);
            var chambermaidDTO = this.mapper.Map<ChambermaidDetail>(chambermaid);
            return Ok(chambermaidDTO);
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<AuthorDto>> GetAuthors(
        //     [FromQuery] AuthorsResourceParameters authorsResourceParameters)
        // {

        //     var authorsFromRepo = _courseLibraryRepository.GetAuthors(authorsResourceParameters);
        //     return Ok(_mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo));
        // }

        [HttpPost]
        public ActionResult<ChambermaidDetail> CreateChambermaid(Chambermaid newChambermaid)
        {
            var chambermaid = this.mapper.Map<Chambermaid>(newChambermaid);
            chambermaid = this.chambermaidRepository.Create(chambermaid);
            return this.mapper.Map<ChambermaidDetail>(chambermaid);
        }

        [HttpDelete("{id}")]
        public ActionResult<object> DeleteChambermaid(long id)
        {
            return new { success = this.chambermaidRepository.Delete(id) };
        }

        [HttpPut("{id}")]
        public ActionResult<ChambermaidDetail> UpdateChambermaid(long id, [FromBody] Chambermaid updatedChambermaid)
        {
            var chambermaid = this.chambermaidRepository.Update(id, updatedChambermaid);
            var chambermaidResult = this.mapper.Map<ChambermaidDetail>(chambermaid);
            return chambermaidResult;
        }
    }
}