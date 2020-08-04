using System.Collections.Generic;
using System.Linq;
using HotelRooms.Core.Helpers;
using HotelRooms.Data.Database;
using HotelRooms.Data.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace HotelRooms.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser> {
        AppUser FindByEmail(string email);
    }

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext context;
        public UserRepository(ApplicationContext context) => this.context = context;

        public AppUser Create(AppUser entity)
        {
            entity.Password = PasswordHelper.Hash(entity.Password);
            this.context.Users.Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public bool Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AppUser> GetAll(string search)
        {
            throw new System.NotImplementedException();
        }

        public AppUser GetOne(long id)
        {
            return this.context.Users
                .Where(u => u.Id == id)
                .First<AppUser>();
        }

        public AppUser Update(long id, AppUser entity)
        {
            throw new System.NotImplementedException();
        }

        public AppUser FindByEmail(string email)
        {
            return this.context.Users
                .Where(u => u.Email.Equals(email))
                .First<AppUser>();
        }

        public AppUser Patch(long id, JsonPatchDocument<AppUser> doc)
        {
            throw new System.NotImplementedException();
        }
    }
}