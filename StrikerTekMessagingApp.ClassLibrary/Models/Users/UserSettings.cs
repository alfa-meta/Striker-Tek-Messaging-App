namespace StrikerTekMessagingApp.ClassLibrary;

public class UserSettings
{
    public Guid UserGuid { get; set; }
    public Guid? ProfileImageGuid { get; set; }
    public Guid ThemeGuid { get; set; }
    public bool? NotificationsEnabled { get; set; } = true;
    public string? LastSeenPrivacy { get; set; } = "everyone";
}

