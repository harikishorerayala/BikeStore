using DataTransfers;

namespace DataManager.Interfaces
{
    public interface IAuthenticationManager
    {
        UserInfo ValidateUser(string username, string password);
    }
}