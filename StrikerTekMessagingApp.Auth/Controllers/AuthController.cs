namespace StrikerTekMessagingApp.Auth;

using StrikerTekMessagingApp.Auth.Services.Interface;
using StrikerTekMessagingApp.Auth.DataTransferObjects;
using StrikerTekMessagingApp.Auth.Models.Requests;

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase, IAuthController
{
    private ILoginService _loginService;

    public AuthController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpGet("home")]
    public async Task<IActionResult> Home()
    {
        return Ok(new { token = "Hello From: /Home" });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        RegisterUserAuthDTO registerUserAuthDTO = new RegisterUserAuthDTO()
        {
            PublicKey = request.PublicKey,
            Email = request.Email,
            Password = request.Password
        };

        bool success = await _loginService.Register(registerUserAuthDTO);

        if (success)
            return Ok(new { token = "your-token-here" });
        else
            return Unauthorized();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        LoginRequestDTO LoginUserAuthDTO = new LoginRequestDTO()
        {
            Email = request.Email,
            Password = request.Password
        };

        bool success = await _loginService.Login(LoginUserAuthDTO);

        if (success)
            return Ok(new { token = "your-token-here" });
        else
            return Unauthorized();
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken()
    {
        return Ok(new { message = "Token refreshed" });
    }
}