namespace HotelRooms.Api.Responses.AppResponse
{
    public class AppError : AppResponse
    {
        public string Reason { get; set; }
        public AppError(string reason) : base(false) => this.Reason = reason;
    }
}