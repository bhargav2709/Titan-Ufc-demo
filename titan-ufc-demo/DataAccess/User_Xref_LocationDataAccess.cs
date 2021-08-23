using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.DataAccess
{
    public class User_Xref_LocationDataAccess : IUser_Xref_LocationDataAccess
    {
        private ApplicationDbContext _context { get; set; }
        public User_Xref_LocationDataAccess(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(users user)
        {
            await _context.UserEntity.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateLocation(Location location)
        {
            await _context.LocationEntity.AddAsync(location);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            //if (await _context.UserEntity.AnyAsync(x => x.UserId == UserId))
            //{
            //  await _context.LocationEntity.AddAsync(location);
                await _context.UserXrefLocationEntity.AddAsync(userxreflocation);
                await _context.SaveChangesAsync();
                    return true;
            //}
            //return false;
        }

        public User_Xref_Location GetUser_Xref_Location(int User_Xref_LocationId)
        {
            //_context.LocationEntity.First;
            return _context.UserXrefLocationEntity.FirstOrDefault(_ => _.User_Xref_LocationId == User_Xref_LocationId);
        }

        public async Task<bool> UpdateUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            _context.UserXrefLocationEntity.Update(userxreflocation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            _context.UserXrefLocationEntity.Remove(userxreflocation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
