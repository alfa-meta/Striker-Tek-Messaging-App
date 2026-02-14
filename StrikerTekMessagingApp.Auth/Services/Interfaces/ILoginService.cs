namespace StrikerTekMessagingApp.Auth.Services.Interfaces;

using StrikerTekMessagingApp.Auth.DataTransferObjects;

public interface ILoginService
{
    public Task<bool> Register(RegisterUserAuthDTO registerUserAuthDTO);
    public Task<bool> Login(LoginRequestDTO loginRequestDTO);
    public Task<bool> CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO);
}