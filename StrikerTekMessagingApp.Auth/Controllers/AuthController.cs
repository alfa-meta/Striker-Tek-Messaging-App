namespace StrikerTekMessaginApp.Auth;

using StrikerTekMessagingApp.Auth.Services.Interfaces;
using StrikerTekMessagingApp.Auth.Services;

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase, IAuthController
{
    private ILoginService _loginService;

    AuthController()
    {
        _loginService = new LoginService();
    }

    [HttpGet("home")]
    public async Task<IActionResult> Home()
    {
        return Ok(new { token = "Hello From: /Home" });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        bool success = true;

        if (success)
            return Ok(new { token = "your-token-here" });
        else
            return Unauthorized();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        return Ok(new { message = "Login successful", token = "test-token" });
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken()
    {
        return Ok(new { message = "Token refreshed" });
    }
}