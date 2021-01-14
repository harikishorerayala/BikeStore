using DataManager.Interfaces;
using DataTransfers;
using System;
using System.Linq;

namespace DataManager
{
    public class AuthenticationManager : IAuthenticationManager
    {
        public UserInfo ValidateUser(string username, string password)
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                var result = entities.UserMasters
                    .FirstOrDefault(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && user.UserPassword == password);

                if (result != null)
                {
                    UserInfo obj = new UserInfo();
                    obj.UserEmailID = result.UserEmailID;
                    obj.UserID = result.UserID;
                    obj.UserName = result.UserName;
                    obj.UserRoles = result.UserRoles;
                    return obj;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}