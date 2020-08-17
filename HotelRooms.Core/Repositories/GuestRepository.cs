using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace HotelRooms.Core.Repositories
{
    public interface IGuestRepository : IRepository<Guest> { 
        Guest Patch(long id, JsonPatchDocument<Guest> doc);

        List<Guest> GetPaginatedGuests(int page = 1, string? search = null, string? sort = null);

        int PerPage { get; set; }

        int Count(string search);
    }

    public class GuestRepository : IGuestRepository
    {
        private readonly ApplicationContext context;

        public int PerPage { get; set; } = 15;

        public GuestRepository(ApplicationContext context) => this.context = context;

        public IEnumerable<Guest> GetAll(string search)
        {
            var query = this.context.Guests.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    g => g.Name.Contains(search) ||
                    g.LastName.Contains(search) ||
                    g.Email.Contains(search)
                );
            }
            return query.ToList();
        }

        public Guest GetOne(long id)
        {
            return this.context.Guests.Where(c => c.Id == id).Single();
        }

        public Guest Create(Guest g)
        {
            this.context.Guests.Add(g);
            this.context.SaveChanges();

            return g;
        }

        public bool Delete(long id)
        {
            this.context.Guests.Remove(this.GetOne(id));
            this.context.SaveChanges();
            return true;
        }

        public Guest Update(long id, Guest newGuest)
        {
            newGuest.Id = id;
            this.context.Entry(newGuest).State = EntityState.Modified;
            this.context.SaveChanges();

            return newGuest;
        }

        public Guest Patch(long id, JsonPatchDocument<Guest> doc)
        {
            var guest = this.GetOne(id);
            doc.ApplyTo(guest);
            this.context.SaveChanges();
            return guest;
        }

        public List<Guest> GetPaginatedGuests(int page, string search, string sort)
        {
            var query = this.context.Guests.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(
                    g => g.Name.Contains(search) ||
                    g.LastName.Contains(search) ||
                    g.Email.Contains(search)
                );
            }

            if (!string.IsNullOrEmpty(sort))
            {
                string[] elements = sort.Split(":"); // 0 => title, 1 => asc
                /* TODO: implement dynamic sort */
                query = query.OrderByDescending(g => g.LastName);
            }

            return query.Skip((page - 1) * this.PerPage)
                .Take(this.PerPage)
                .ToList();
        }

        public int Count(string search)
        {
            var query = this.context.Guests.AsQueryable();
            if(!string.IsNullOrEmpty(search))
            {
                return query.Count(g => 
                g.Name.Contains(search) ||
                    g.LastName.Contains(search) ||
                    g.Email.Contains(search));
            }

            return query.Count();
        }
    }
}