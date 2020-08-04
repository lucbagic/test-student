using System.Collections.Generic;
using System.Linq;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Core.Repositories
{
    public interface IRoomTypeRepository : IRepository<RoomType> {}

    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly ApplicationContext context;

        public RoomTypeRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public RoomType Create(RoomType rT)
        {
            this.context.RoomTypes.Add(rT);
            this.context.SaveChanges();

            return rT;
        }

        public bool Delete(long id)
        {
            this.context.RoomTypes.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }

        public IEnumerable<RoomType> GetAll(string search)
        {
            var query = this.context.RoomTypes.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    rT => rT.Type.Contains(search) ||
                    rT.Description.Contains(search)
                );
            }
            return query.ToList();  
        }

        public RoomType GetOne(long id)
        {
            return this.context.RoomTypes.Where(rT => rT.Id == id).Single();
        }

        public RoomType Patch(long id, JsonPatchDocument<RoomType> doc)
        {
            var roomType = this.GetOne(id);
            doc.ApplyTo(roomType);
            this.context.SaveChanges();
            return roomType;
        }

        public RoomType Update(long id, RoomType newRoomType)
        {
            newRoomType.Id = id;
            this.context.Entry(newRoomType).State = EntityState.Modified;
            this.context.SaveChanges();
            return newRoomType;
        }
    }
}