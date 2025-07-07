using Auth.API.DTOs;
using Auth.API.Services.JwtService;
using Auth.API.Entities;
using Auth.API.Data;
using System.Security.Claims;

namespace Auth.API.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly IJwtService _jwtService;
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context, IJwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    public LoginResponse? Authenticate(LoginRequest request)
    {
        var user = _context.Users.SingleOrDefault(u => u.Username == request.Username);
        if (user == null)
        {
            return null;
        }

        if (!VerifyPassword(request.Password, user.Password))
        {
            return null;
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Name,user.Username)
        };

        var token = _jwtService.GenerateToken(claims);
        return new LoginResponse
        {
            Token = token,
            Username = user.Username,
            Email = user.Email
        };
    }

    public bool Register(RegisterRequest request)
    {
        if (_context.Users.Any(u => u.Username == request.Username))
        {
            return false;
        }

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

        var user = new User
        {
            Username = request.Username,
            Email = request.Email,
            Password = hashedPassword
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return true;
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
