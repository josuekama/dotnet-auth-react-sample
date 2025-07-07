namespace Auth.API.DTOs;

public class LoginResponse
{
    public required string Token { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public DateTime Expiration { get; set; }
}
