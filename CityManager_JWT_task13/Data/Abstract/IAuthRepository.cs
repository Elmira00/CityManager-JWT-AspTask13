using CityManager_JWT_task13.Entites;

namespace CityManager_JWT_task13.Data.Abstract
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
