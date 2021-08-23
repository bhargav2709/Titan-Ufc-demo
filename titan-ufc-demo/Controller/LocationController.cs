using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;
using titan_ufc_demo.Controller;
using titan_ufc_demo.Service;

namespace titan_ufc_demo.Controller
{
    [Produces("application/json")]
    [Route("api/location")]
    public class LocationController : ControllerBase
    {
        private ILocationService _locationService { get; set; }
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation([FromBody] Location location, [FromHeader] int UserId)
        {
            var data = await _locationService.CreateLocation(location, UserId);
            return Ok(data);
        }

        [HttpGet]
        [Route("{locationid:int}/LocationData")]
        public IActionResult GetLocation(int locationid)
        {
            var data = _locationService.GetLocation(locationid);
            return Ok(data);
        }

        [HttpPut]
        [Route("{userid:int}/UserData")]
        public async Task<IActionResult> UpdateLocation([FromBody] Location location, int UserId )
        {
            var data = await _locationService.UpdateLocation(location, UserId);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLocation([FromBody] Location location)
        {
            var data = await _locationService.RemoveLocation(location);
            return Ok(data);
        }
    }
}
