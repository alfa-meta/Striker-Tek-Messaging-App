namespace StrikerTekMessagingApp.ClassLibrary;


// This is part of Auth Database.
public class RefreshToken
{
    public string TokenHash { get; set; } = "";
    public Guid UserGuid { get; set; }
    public string Jti { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public bool IsRevoked { get; set; } = false;
    public string? DeviceInfo { get; set; }
}