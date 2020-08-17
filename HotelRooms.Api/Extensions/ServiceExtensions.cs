using HotelRooms.Api.Services;
using HotelRooms.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelRooms.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IAssignedRoomRepository, AssignedRoomRepository>();
            services.AddScoped<IChambermaidRepository, ChambermaidRepository>();
            services.AddScoped<IGuestRepository, GuestRepository>();
            services.AddScoped<IReservedRoomRepository, ReservedRoomRepository>();

            services.AddScoped<IGuestService, GuestService>();
        }
    }
}