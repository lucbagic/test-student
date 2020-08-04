using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HotelRooms.Data.Entities;
using HotelRooms.Data.Database;
using Microsoft.AspNetCore.JsonPatch;

namespace HotelRooms.Core.Repositories
{
    public interface IAssignedRoomRepository : IRepository<AssignedRoom> {}

    public class AssignedRoomRepository : IAssignedRoomRepository
    {
        private readonly ApplicationContext context;

        public AssignedRoomRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<AssignedRoom> GetAll(string search)
        {
            var query = this.context.AssignedRooms.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    aR => aR.Chambermaid.Name.Contains(search) ||
                    aR.Chambermaid.LastName.Contains(search) ||
                    aR.CleaningStatus.Status.Contains(search) ||
                    aR.CleaningType.Type.Contains(search)
                );
            }
            return query.ToList(); 
        }

        public AssignedRoom GetOne(long id)
        {
            return this.context.AssignedRooms.Where(c => c.Id == id).Single();
        }
        
        public AssignedRoom Create(AssignedRoom entity)
        {
            this.context.AssignedRooms.Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.AssignedRooms.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }
        

        public AssignedRoom Update(long id, AssignedRoom newAssignedRoom)
        {
            newAssignedRoom.Id = id;
            this.context.Entry(newAssignedRoom).State = EntityState.Modified;
            this.context.SaveChanges();

            return newAssignedRoom;
        }

        public AssignedRoom Patch(long id, JsonPatchDocument<object> doc)
        {
            var assignedRoom = this.GetOne(id);
            doc.ApplyTo(assignedRoom);
            this.context.SaveChanges();
            return assignedRoom;
        }

    }
}