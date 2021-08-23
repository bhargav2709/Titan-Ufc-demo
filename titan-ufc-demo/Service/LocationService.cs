using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.DataAccess;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public class LocationService : ILocationService
    {
        private ILocationDataAccess _locationDataAccess { get; set; }
        public LocationService(ILocationDataAccess _locationDataAccess)
        {
            this._locationDataAccess = _locationDataAccess;
        }

        public async Task<bool> CreateLocation(Location location, int UserId)
        {
            var data = await _locationDataAccess.CreateLocation(location, UserId);
            int LocationId = await _locationDataAccess.GetLocationIdByLocation(location.LocationName);
            return true;
        }

        public Location GetLocation(int LocationId)
        {
            return _locationDataAccess.GetLocation(LocationId);
        }

        public async Task<bool> UpdateLocation(Location location, int UserId)
        {
            return await _locationDataAccess.UpdateLocation(location, UserId);
        }

        public async Task<bool> RemoveLocation(Location location)
        {
            return await _locationDataAccess.RemoveLocation(location);
        }
    }
}
