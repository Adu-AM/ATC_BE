using ATC_BE.Models;

namespace ATC_BE.Services
{
    public interface IUserService
    {
        public List<UserModel> GetUsers(); 
    }
}
