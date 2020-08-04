using System.Collections.Generic;
using System.Linq;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace HotelRooms.Core.Repositories
{
    public interface IChambermaidRepository : IRepository<Chambermaid> { }

    public class ChambermaidRepository : IChambermaidRepository
    {
        private readonly ApplicationContext context;

        public ChambermaidRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Chambermaid> GetAll(string search)
        {
            var query = this.context.Chambermaids.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    c => c.Name.Contains(search) ||
                    c.LastName.Contains(search)
                );
            }
            return query.ToList();
        }

        public Chambermaid GetOne(long id)
        {
            return this.context.Chambermaids.Where(p => p.Id == id).Single();
        }

        public Chambermaid Create(Chambermaid entity)
        {
            this.context.Chambermaids.Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public bool Delete(long id)
        {
            this.context.Chambermaids.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }

        public Chambermaid Update(long id, Chambermaid newChambermaid)
        {
            newChambermaid.Id = id;
            this.context.Entry(newChambermaid).State = EntityState.Modified;
            this.context.SaveChanges();

            return newChambermaid;
        }

        public Chambermaid Patch(long id, JsonPatchDocument<Chambermaid> doc)
        {
            var chambermaid = this.GetOne(id);
            doc.ApplyTo(chambermaid);
            this.context.SaveChanges();
            return chambermaid;
        }
    }
}