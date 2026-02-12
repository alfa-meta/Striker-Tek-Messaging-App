// /Striker-Tek-Messaging-App/StrikerTekMessagingApp.ClassLibrary/Models/Auth/Data/RefreshToken.cs
namespace StrikerTekMessagingApp.ClassLibrary.Models.Auth;


// This is part of Auth Database.
public class RefreshToken
{
    public string TokenHash { get; set; } = "";
    public Guid UserAuthGuid { get; set; }
    public string Jti { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool IsRevoked { get; set; } = false;
    public string? DeviceInfo { get; set; }

    // Navigation property
    public UserAuth UserAuth { get; set; } = null!;
}