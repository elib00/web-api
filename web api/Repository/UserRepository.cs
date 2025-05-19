using web_api.Models;

namespace web_api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BackendDBContext _dbContext; //for dependency injection

        public UserRepository(BackendDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUser(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }
    }
}
