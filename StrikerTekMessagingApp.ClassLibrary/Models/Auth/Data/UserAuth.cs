namespace StrikerTekMessagingApp.ClassLibrary;


// This is part of Auth Database.
public class UserAuth
{
    public Guid UserGuid { get; set; }
    public string PublicKey { get; set; } = "";
    public string? PasswordHash { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}
