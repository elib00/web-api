using web_api.DTO;
using web_api.Repository;

namespace web_api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository; //for dependency injection

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> GetUser(int userId)
        {
            var user = await _userRepository.GetUser(userId);
            if (user == null)
            {
                return null;
            }
            return new UserDTO //use the DTO to hide SensitiveInfo from the client (user.SensitiveInfo)
            {
                Name = user.Name
            };
        }
    }
}
