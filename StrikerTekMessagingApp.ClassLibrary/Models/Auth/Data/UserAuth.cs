// /Striker-Tek-Messaging-App/StrikerTekMessagingApp.ClassLibrary/Models/Auth/Data/UserAuth.cs
using System.ComponentModel.DataAnnotations;

namespace StrikerTekMessagingApp.ClassLibrary.Models.Auth;


// This is part of Auth Database.
public class UserAuth
{
    public Guid UserAuthGuid { get; private set; }
    public Guid UserGuid { get; private set; }
    public string PublicKey { get; private set; } = "";
    public string Email { get; private set; } = "";
    public string? PasswordHash { get; private set; }
    public DateTime CreatedAt { get; private set; }

    // Navigation properties
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}
