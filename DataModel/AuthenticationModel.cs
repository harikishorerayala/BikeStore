using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;
using DataManager.Interfaces;
using DataModel.Interfaces;
using DataTransfers;

namespace DataModel
{
    public class AuthenticationModel : IAuthenticationModel
    {
        private IAuthenticationManager _AuthManager;

        public AuthenticationModel()
        {
            _AuthManager = new AuthenticationManager();
        }

        public AuthenticationModel(IAuthenticationManager mgr)
        {
            this._AuthManager = mgr;
        }

        public UserInfo ValidateUser(string username, string password)
        {
            return _AuthManager.ValidateUser(username, password);
        }
    }
}
