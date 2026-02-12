namespace StrikerTekMessagingApp.Auth.Services.Interfaces;

using StrikerTekMessagingApp.Auth.Services.Interfaces;
public interface ILoginService
{
    public string Register(RegisterUserDTO userAuthDTO);
    public string Login(LoginRequestDTO userAuthDTO);
    public string CheckIfAccountExists(UserAuthResponseDTO userAuthDTO);
}