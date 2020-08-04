
using AutoMapper;
using HotelRooms.Core.Services;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using HotelRooms.Api.Requests;
using HotelRooms.Api.Responses;

namespace HotelRooms.Api.Controllers.Auth
{
    
    [Route("api/auth/login")]
    public class LoginController : AppController
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public LoginController(
            IAuthService authService,
            IMapper mapper
        ) {
            this.mapper = mapper;
            this.authService = authService;
        }

        [HttpPost]
        public ActionResult<string> Login(LoginRequest request)
        {
            var token = this.authService.Login(request.Email, request.Password);


            // var user = this.mapper.Map<AppUser>(request);
            // user = this.authService.Register(user);

            // var response = new RegistrationResponse();
            // response.User = user;
            // response.Token = "";
            return token;
        }
    }
}