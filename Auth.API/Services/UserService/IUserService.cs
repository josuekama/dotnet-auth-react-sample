using Auth.API.DTOs;

namespace Auth.API.Services.UserService;

public interface IUserService
{
    UserResponse? Me(string token);
}