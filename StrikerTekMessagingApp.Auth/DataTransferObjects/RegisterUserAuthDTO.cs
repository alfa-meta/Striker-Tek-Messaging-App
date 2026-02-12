// /Striker-Tek-Messaging-App/StrikerTekMEssaginApp.Auth/DataTransferObjects/RegisterUserAuthDTO.cs

namespace StrikerTekMessagingApp.Auth.DataTransferObjects;

public class RegisterUserAuthDTO
{
    public string PublicKey { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = ""; // Plain password, will be hashed server-side
}