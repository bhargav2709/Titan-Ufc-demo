using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;
using titan_ufc_demo.DataAccess;

namespace titan_ufc_demo.Service
{
    public class DeviceService : IDeviceService
    {
        private IDeviceDataAccess _deviceDataAccess { get; set; }
        public DeviceService(IDeviceDataAccess _deviceDataAccess)
        {
            this._deviceDataAccess = _deviceDataAccess;
        }

        public async Task<bool> CreateDevice(Devices device, int UserId)
        {
            return await _deviceDataAccess.CreateDevice(device, UserId);
        }
        


        public Devices GetDevice(int DeviceId)
        {
            return _deviceDataAccess.GetDevice(DeviceId);
        }

        public async Task<bool> UpdateDevice(Devices device, int UserId)
        {
            return await _deviceDataAccess.UpdateDevice(device, UserId);
        }

        public async Task<bool> UpdateDeviceLocation(Location location, int UserId)
        {
            return await _deviceDataAccess.UpdateDeviceLocation(location, UserId);
        }

        public async Task<bool> RemoveDevice(Devices device, int UserId)
        {
            return await _deviceDataAccess.RemoveDevice(device, UserId);
        }
    }
}
