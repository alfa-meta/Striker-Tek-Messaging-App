// Striker-Tek-Messaging-App/StrikerTekMessaginApp.Auth/Services/Interface/ICryptographyService.cs

namespace StrikerTekMessagingApp.Auth.Services.Interface;

using System.Security.Claims;
public interface ICryptographyService
{
    string GenerateSalt();
    string HashPassword(string password, string salt);
    bool VerifyPassword(string password, string salt, string hash);
    string GenerateJwtToken(string userId, string email);
    ClaimsPrincipal? ValidateJwtToken(string token);
}