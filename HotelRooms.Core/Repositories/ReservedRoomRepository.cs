using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace HotelRooms.Core.Repositories
{
    public interface IReservedRoomRepository : IRepository<ReservedRoom> { }

    public class ReservedRoomRepository : IReservedRoomRepository
    {
        private readonly ApplicationContext context;

        public ReservedRoomRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<ReservedRoom> GetAll(string search)
        {
            var query = this.context.ReservedRooms.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    rR => rR.Guest.Name.Contains(search) ||
                    rR.Guest.LastName.Contains(search) ||
                    rR.Room.RoomType.Type.Contains(search)
                );
            }
            return query.ToList();
        }

        public ReservedRoom GetOne(long id)
        {
            return this.context.ReservedRooms.Where(c => c.Id == id).Single();
        }
        
        public ReservedRoom Create(ReservedRoom rR)
        {
            this.context.ReservedRooms.Add(rR);
            this.context.SaveChanges();
            return rR;
        }

        public bool Delete(long id)
        {
            this.context.ReservedRooms.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }

        public ReservedRoom Update(long id, ReservedRoom newReservedRoom)
        {
            newReservedRoom.Id = id;
            this.context.Entry(newReservedRoom).State = EntityState.Modified;
            this.context.SaveChanges();

            return newReservedRoom;
        }

        public ReservedRoom Patch(long id, JsonPatchDocument<ReservedRoom> doc)
        {
            var reservedRoom = this.GetOne(id);
            doc.ApplyTo(reservedRoom);
            this.context.SaveChanges();
            return reservedRoom;
        }
    }
}