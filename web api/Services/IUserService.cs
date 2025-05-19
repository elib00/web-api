using web_api.DTO;

namespace web_api.Services
{
    public interface IUserService
    {
        Task<UserDTO> GetUser(int userId);
    }
}
