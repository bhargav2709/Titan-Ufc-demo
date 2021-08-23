using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public interface IDeviceService
    {
        Task<bool> CreateDevice(Devices device, int UserId);
        Devices GetDevice(int DeviceId);
        Task<bool> UpdateDevice(Devices device, int UserId);
        Task<bool> UpdateDeviceLocation(Location location, int UserId);
        Task<bool> RemoveDevice(Devices device, int UserId);
    }
}
