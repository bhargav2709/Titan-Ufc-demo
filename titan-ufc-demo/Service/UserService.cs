using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.DataAccess;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public class UserService: IUserService
    {
        private IUserDataAccess _userDataAccess { get; set; }
        public UserService(IUserDataAccess _userDataAccess) 
        {
            this._userDataAccess = _userDataAccess;
        }

        public async Task<bool> CreateUser(users user)
        {
            return await _userDataAccess.CreateUser(user);
        }

        public users GetUser(int UserId)
        {
            return _userDataAccess.GetUser(UserId);
        }

        public async Task<bool> UpdateUser(users user)
        {
            return await _userDataAccess.UpdateUser(user);
        }

        public async Task<bool> RemoveUser(users user)
        {
            return await _userDataAccess.RemoveUser(user);
        }
    }
}
