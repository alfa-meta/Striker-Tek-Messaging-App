// /Striker-Tek-Messaging-App/StrikerTekMessagingApp.ClassLibrary/Models/Auth/Data/UserAuth.cs
using System.ComponentModel.DataAnnotations;

namespace StrikerTekMessagingApp.ClassLibrary.Models.Auth;


// This is part of Auth Database.
public class UserAuth
{
    public Guid UserAuthGuid { get; set; }
    public Guid UserGuid { get; set; }
    public string PublicKey { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordSalt { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public DateTime CreatedAt { get; set; }

    // Navigation properties
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}
