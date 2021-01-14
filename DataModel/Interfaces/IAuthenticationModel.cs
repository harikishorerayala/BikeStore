using DataTransfers;

namespace DataModel.Interfaces
{
    public interface IAuthenticationModel
    {
        UserInfo ValidateUser(string username, string password);
    }
}