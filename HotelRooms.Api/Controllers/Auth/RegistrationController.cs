using AutoMapper;
using HotelRooms.Core.Services;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Data.Entities;
using HotelRooms.Api.Requests;
using HotelRooms.Api.Responses;

namespace HotelRooms.Api.Controllers.Auth
{
    [Route("api/auth/register")]
    public class RegistrationController : AppController
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public RegistrationController(
            IAuthService authService,
            IMapper mapper
        ) {
            this.mapper = mapper;
            this.authService = authService;
        }

        [HttpPost]
        public ActionResult<RegistrationResponse> Register(RegistrationRequest request)
        {
            /*
            var appUser = this.mapper.Map<AppUser>(request);

            /* register user: create the entity in database, hash the password, etc. 
            var userDetail = this.authService.Register(appUser);
            var token = JwtHelper.CreateFromUser(appUser);
            var response = new RegistrationResponse(userDetail, token);
            return response;
            */
            return null;
        }
    }
}