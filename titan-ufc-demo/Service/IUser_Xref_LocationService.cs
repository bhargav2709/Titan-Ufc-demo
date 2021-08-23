using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo.Service
{
    public interface IUser_Xref_LocationService
    {
        Task<bool> CreateUser_Xref_Location(User_Xref_Location userxreflocation);
        User_Xref_Location GetUser_Xref_Location(int User_Xref_LocationId);
        Task<bool> UpdateUser_Xref_Location(User_Xref_Location userxreflocation);
        Task<bool> RemoveUser_Xref_Location(User_Xref_Location userxreflocation);
    }
}
