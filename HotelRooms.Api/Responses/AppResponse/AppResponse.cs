using Microsoft.AspNetCore.Mvc;

namespace HotelRooms.Api.Responses.AppResponse
{
    public class AppResponse : ActionResult
    {
        public bool Success { get; set; } = false;
        public AppResponse(bool success) => this.Success = success;
    }
}