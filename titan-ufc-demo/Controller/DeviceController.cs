using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;
using titan_ufc_demo.Service;

namespace titan_ufc_demo.Controller
{
        [Produces("application/json")]
        [Route("api/device")]
        public class DeviceController : ControllerBase
        {

            private IDeviceService _deviceService { get; set; }
            public DeviceController(IDeviceService deviceService)
            {
                _deviceService = deviceService;
            }

            [HttpPost]
            public async Task<IActionResult> CreateDevice([FromBody] Devices device, [FromHeader] int UserId)
            {

                if (await _deviceService.CreateDevice(device, UserId))
                {
                    return Ok("Successfully added device");
                }
                    return BadRequest("Invalid data");
            }

            [HttpGet]
            [Route("{deviceid:int}/DeviceData")]
            public IActionResult GetDevice(int deviceid)
            {
                var data = _deviceService.GetDevice(deviceid);
                return Ok(data);
            }

            /*[HttpGet]
            [Route("{locationid: int}/LocationData")]
            public IActionResult GetDeviceLocation(int locationid)
            {
                var data = _deviceService.GetDeviceLocation(locationid);
                return Ok(data);
            }*/

            [HttpPut]
            public async Task<IActionResult> UpdateDevice([FromBody] Devices device, [FromHeader] int UserId)
            {
                if (await _deviceService.UpdateDevice(device, UserId))
                {
                    return Ok("Successfully updated");
                }
                return BadRequest("Not Updated plese check");
            }

            [HttpDelete]
            public async Task<IActionResult> DeleteDevice([FromBody] Devices device, [FromHeader] int UserId)
            {
                var data = await _deviceService.RemoveDevice(device, UserId);
                return Ok(data);
            }
        }
}
