using System.Collections.Generic;
using System.Linq;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Core.Repositories
{
    public interface IRoomRepository : IRepository<Room> {}

    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationContext context;

        public RoomRepository(ApplicationContext context)
        {
            this.context = context;
        }

         public Room Create(Room r)
        {
            this.context.Rooms.Add(r);
            this.context.SaveChanges();
            return r;
        }

        public bool Delete(long id)
        {
            this.context.Rooms.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }

        public IEnumerable<Room> GetAll(string search)
        {
            var query = this.context.Rooms.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    r => r.RoomType.Type.Contains(search) 
                );
            }
            return query.ToList();  
        }

        public Room GetOne(long id)
        {
            return this.context.Rooms.Where(r => r.Id == id).Single();
        }

        public Room Patch(long id, JsonPatchDocument<Room> doc)
        {
            var Room = this.GetOne(id);
            doc.ApplyTo(Room);
            this.context.SaveChanges();
            return Room;
        }

        public Room Update(long id, Room newRoom)
        {
            newRoom.Id = id;
            this.context.Entry(newRoom).State = EntityState.Modified;
            this.context.SaveChanges();
            return newRoom;
        }
    }
}