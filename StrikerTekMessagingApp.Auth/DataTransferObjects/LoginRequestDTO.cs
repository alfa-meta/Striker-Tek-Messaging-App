// /Striker-Tek-Messaging-App/StrikerTekMEssaginApp.Auth/DataTransferObjects/LoginUserAuthDTO.cs

namespace StrikerTekMessagingApp.Auth.DataTransferObjects;

public class LoginRequestDTO
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}