using Auth.API.DTOs;
using Auth.API.Services.JwtService;
using Auth.API.Data;
using System.Security.Claims;

namespace Auth.API.Services.UserService;

public class UserService : IUserService
{
    private readonly IJwtService _jwtService;
    private readonly AppDbContext _context;

    public UserService(AppDbContext context, IJwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    public UserResponse? Me(string token)
    {
        var principal = _jwtService.ValidateToken(token);
        if (principal == null)
        {
            return null;
        }

        var username = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
        if (username == null)
        {
            return null;
        }

        var user = _context.Users.FirstOrDefault(u => u.Username == username);
        if (user == null)
        {
            return null;
        }

        return new UserResponse
        {
            Username = user.Username,
            Email = user.Email,
            Id = user.Id,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
}
