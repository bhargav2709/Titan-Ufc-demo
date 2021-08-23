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
    [Route("api/userxreflocation")]
    public class User_Xref_LocationController : ControllerBase
    {
        private IUser_Xref_LocationService _userxreflocationService { get; set; }
        public User_Xref_LocationController(IUser_Xref_LocationService userxreflocationService)
        {
            _userxreflocationService = userxreflocationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser_Xref_Location([FromBody] User_Xref_Location userxreflocation)
        {
            var data = await _userxreflocationService.CreateUser_Xref_Location(userxreflocation);
            return Ok(data);
        }

        [HttpGet]
        [Route("{userxreflocationid:int}/UserXrefLocationData")]
        public IActionResult GetUser_Xref_Location(int userxreflocationid)
        {
            var data = _userxreflocationService.GetUser_Xref_Location(userxreflocationid);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser_Xref_Location([FromBody] User_Xref_Location userxreflocation)
        {
            var data = await _userxreflocationService.UpdateUser_Xref_Location(userxreflocation);
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser_Xref_Location([FromBody] User_Xref_Location userxreflocation)
        {
            var data = await _userxreflocationService.RemoveUser_Xref_Location(userxreflocation);
            return Ok(data);
        }
    }
}
