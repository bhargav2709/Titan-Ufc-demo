using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.DataAccess;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public class User_Xref_LocationService : IUser_Xref_LocationService
    {
        private IUser_Xref_LocationDataAccess _userxreflocationDataAccess { get; set; }

        public User_Xref_LocationService(IUser_Xref_LocationDataAccess _userxreflocationDataAccess)
        {
            this._userxreflocationDataAccess = _userxreflocationDataAccess;
        }

        public async Task<bool> CreateUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            return await _userxreflocationDataAccess.CreateUser_Xref_Location(userxreflocation);
        }

        public User_Xref_Location GetUser_Xref_Location(int User_Xref_LocationId)
        {
            return _userxreflocationDataAccess.GetUser_Xref_Location(User_Xref_LocationId);
        }

        public async Task<bool> UpdateUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            return await _userxreflocationDataAccess.UpdateUser_Xref_Location(userxreflocation);
        }

        public async Task<bool> RemoveUser_Xref_Location(User_Xref_Location userxreflocation)
        {
            return await _userxreflocationDataAccess.RemoveUser_Xref_Location(userxreflocation);
        }
    }
}
