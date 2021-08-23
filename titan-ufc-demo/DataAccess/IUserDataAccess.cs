using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.DataAccess
{
    public interface IUserDataAccess
    {
        Task<bool> CreateUser(users user);
        users GetUser(int UserId);
        Task<bool> UpdateUser(users user);
        Task<bool> RemoveUser(users user);
    }
}
