// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Services/LoginService.cs

namespace StrikerTekMessagingApp.Auth.Services;

using StrikerTekMessagingApp.Auth.Services.Interfaces;
using StrikerTekMessagingApp.Auth.DataTransferObjects;
using StrikerTekMessagingApp.Auth.Repositories.Interface;
using StrikerTekMessagingApp.ClassLibrary.Models.Auth;
using BCrypt.Net;

public class LoginService : ILoginService
{
    private readonly IUserAuthRepository _userAuthRepository;

    public LoginService(IUserAuthRepository userAuthRepository)
    {
        _userAuthRepository = userAuthRepository;
    }

    public async Task<bool> Register(RegisterUserAuthDTO registerUserAuthDTO)
    {
        var existingUser = await _userAuthRepository.GetByEmailAsync(registerUserAuthDTO.Email);
        if (existingUser != null)
        {
            return false;
        }

        string hashedPassword = BCrypt.HashPassword(registerUserAuthDTO.Password);

        UserAuth userAuth = new UserAuth()
        {
            PublicKey = registerUserAuthDTO.PublicKey,
            Email = registerUserAuthDTO.Email,
            PasswordHash = hashedPassword
        };

        await _userAuthRepository.CreateAccountAsync(userAuth);
        return true;
    }

    public async Task<bool> Login(LoginRequestDTO loginRequestDTO)
    {

        UserAuth? userAuth = await _userAuthRepository.GetByEmailAsync(loginRequestDTO.Email);

        if (userAuth == null)
        {
            return false;
        }

        return BCrypt.Verify(loginRequestDTO.Password, userAuth.PasswordHash);
    }

    public async Task<bool> CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO)
    {
        throw new NotImplementedException();
    }
}