using web_api.Models;

namespace web_api.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUser(int id);
    }
}
