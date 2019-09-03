using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAuthenticationJWT.Services.Interfaces;

namespace WebApiAuthenticationJWT.Services
{
    public class UserManagementService : IUserManagementService
    {
        //Todo: Dependency injection of IUserManagementRepository
        public bool IsValidUser(string userName, string password)
        {
            return true;
        }
    }
}
