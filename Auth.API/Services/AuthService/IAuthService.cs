using Auth.API.DTOs;

namespace Auth.API.Services.AuthService;

public interface IAuthService
{
    LoginResponse? Authenticate(LoginRequest request);
    bool Register(RegisterRequest request);
    
}