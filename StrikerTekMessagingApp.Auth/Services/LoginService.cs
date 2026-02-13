namespace StrikerTekMessagingApp.Auth.Services;

using StrikerTekMessagingApp.Auth.Services.Interfaces;
using StrikerTekMessagingApp.Auth.DataTransferObjects;

public class LoginService : ILoginService
{

    public LoginService()
    {
        
    }

    public string Register(RegisterUserAuthDTO registerUserAuthDTO)
    {
        throw new NotImplementedException();
    }

    public string Login(LoginRequestDTO loginRequestDTO)
    {
        throw new NotImplementedException();
    }

    public string CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO)
    {
        throw new NotImplementedException();
    }
}