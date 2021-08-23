using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.DataAccess
{
    public interface ILocationDataAccess
    {
        Task<bool> CreateLocation(Location location, int UserId);
        Location GetLocation(int LocationId);
        Task<int> GetLocationIdByLocation(string LocationName);
        Task<bool> UpdateLocation(Location location, int UserId);
        Task<bool> RemoveLocation(Location location);
    }
}
