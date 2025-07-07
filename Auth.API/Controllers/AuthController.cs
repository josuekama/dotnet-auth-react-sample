using Microsoft.AspNetCore.Mvc;
using Auth.API.DTOs;
using Auth.API.Services.AuthService;

namespace Auth.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            return BadRequest(new { message = "Kullanıcı adı ve şifre zorunludur." });

        var result = _authService.Authenticate(request);

        if (result == null)
            return Unauthorized(new { message = "Geçersiz kullanıcı adı veya şifre." });

        return Ok(result);
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            return BadRequest(new { message = "Kullanıcı adı ve şifre zorunludur." });

        var success = _authService.Register(request);

        if (!success)
            return Conflict(new { message = "Kullanıcı zaten mevcut." });

        return Ok(new { message = "Kayıt başarılı." });
    }
}
