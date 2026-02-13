namespace StrikerTekMessagingApp.Auth.Services.Interfaces;

using StrikerTekMessagingApp.Auth.DataTransferObjects;

public interface ILoginService
{
    public string Register(RegisterUserAuthDTO registerUserAuthDTO);
    public string Login(LoginRequestDTO loginRequestDTO);
    public string CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO);
}