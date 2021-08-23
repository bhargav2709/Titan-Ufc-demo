using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public interface ILocationService
    {
        Task<bool> CreateLocation(Location location, int UserId);
        Location GetLocation(int LocationId);
        Task<bool> UpdateLocation(Location location, int UserId);
        Task<bool> RemoveLocation(Location location);
    }
}
