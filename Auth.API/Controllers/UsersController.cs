using Microsoft.AspNetCore.Mvc;
using Auth.API.Services.UserService;

namespace Auth.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("me")]
    public IActionResult Me()
    {
        var authHeader = Request.Headers["Authorization"].ToString();

        if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer "))
        {
            return Unauthorized(new { message = "Bearer tokens required." });
        }

        var token = authHeader["Bearer ".Length..].Trim();

        var result = _userService.Me(token);

        if (result == null)
            return Unauthorized(new { message = "Invalid or expired token." });

        return Ok(result);
    }
}
