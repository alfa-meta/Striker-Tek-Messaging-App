namespace StrikerTekMessagingApp.ClassLibrary;

public class BlockedUsers
{
    public int Id { get; set; }
    public Guid UserGuid { get; set; }
    public Guid BlockedUserGuid { get; set; }
    public DateTime BlockedAt { get; set; }
}