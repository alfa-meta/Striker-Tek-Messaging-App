// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Services/LoginService.cs

namespace StrikerTekMessagingApp.Auth.Services;

using StrikerTekMessagingApp.Auth.Services.Interface;
using StrikerTekMessagingApp.Auth.DataTransferObjects;
using StrikerTekMessagingApp.Auth.Repositories.Interface;
using StrikerTekMessagingApp.ClassLibrary.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;

public class LoginService : ILoginService
{
    private readonly IUserAuthRepository _userAuthRepository;

    public LoginService(IUserAuthRepository userAuthRepository)
    {
        _userAuthRepository = userAuthRepository;
    }

    public async Task<IActionResult> Register(RegisterUserAuthDTO registerUserAuthDTO)
    {
        var existingUser = await _userAuthRepository.GetByEmailAsync(registerUserAuthDTO.Email);
        if (existingUser != null)
        {
            return new BadRequestObjectResult(new { message = "This Email is already in use."});
        }

        string hashedPassword = BCrypt.HashPassword(registerUserAuthDTO.Password);

        UserAuth userAuth = new UserAuth()
        {
            PublicKey = registerUserAuthDTO.PublicKey,
            Email = registerUserAuthDTO.Email,
            PasswordHash = hashedPassword
        };

        await _userAuthRepository.CreateAccountAsync(userAuth);
        return new OkObjectResult(new { message = "User registered successfully"});
    }

    public async Task<IActionResult> Login(LoginRequestDTO loginRequestDTO)
    {

        UserAuth? userAuth = await _userAuthRepository.GetByEmailAsync(loginRequestDTO.Email);

        if (userAuth == null)
        {
            return new UnauthorizedObjectResult(new { message = "Invalid email or password."});
        }

        bool isPasswordValid = BCrypt.Verify(loginRequestDTO.Password, userAuth.PasswordHash);

        if (!isPasswordValid)
        {
            return new UnauthorizedObjectResult(new { message = "Invalid email or password"});
        }

        return new OkObjectResult(new { message = "Login successful"});
    }

    public async Task<IActionResult> CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO)
    {
        throw new NotImplementedException();
    }
}