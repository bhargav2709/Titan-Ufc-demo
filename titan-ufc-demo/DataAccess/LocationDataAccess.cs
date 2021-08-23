using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.DataAccess
{
    public class LocationDataAccess : ILocationDataAccess
    {
        private ApplicationDbContext _context { get; set; }
        public LocationDataAccess(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateLocation(Location location, int UserId)
        {
            if (await _context.UserEntity.AnyAsync(x => x.UserId == UserId))
            {
                await _context.LocationEntity.AddAsync(location);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<int> GetLocationIdByLocation(string LocationName)
        {
            return (await _context.LocationEntity.FirstOrDefaultAsync(x => x.LocationName == LocationName)).LocationId;
        }

        public Location GetLocation(int LocationId)
        {
            return _context.LocationEntity.FirstOrDefault(_ => _.LocationId == LocationId);
        }

        public async Task<bool> UpdateLocation(Location location, int UserId)
        {
            if (await _context.UserEntity.AnyAsync(x => x.UserId == UserId))
            {
                _context.LocationEntity.Update(location);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> RemoveLocation(Location location)
        {
            _context.LocationEntity.Remove(location);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
