using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.DataAccess
{
    public class UserDataAccess: IUserDataAccess
    {
        private ApplicationDbContext _context { get; set; }
        public UserDataAccess(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(users user)
        {
            await _context.UserEntity.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public users GetUser(int UserId)
        {
            return _context.UserEntity.FirstOrDefault(_ => _.UserId == UserId);
        }

        public async Task<bool> UpdateUser(users user)
        {
            _context.UserEntity.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveUser(users user)
        {
            _context.UserEntity.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
