namespace StrikerTekMessagingApp.ClassLibrary;


public class Notifications
{
    public Guid NotificationsGuid { get; set; }
    public Guid UserGuid { get; set; }
    public string? NotificationType { get; set; } = "message";
    public string? ReferenceId  { get; set; }
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; }
}