namespace StrikerTekMessagingApp.ClassLibrary;
public class ChatsParticipants
{
    public int Id { get; set; }
    public Guid ChatGuid { get; set; }
    public Guid UserGuid { get; set; }
    public int LastReadMessageId { get; set; }
    public string Role { get; set; } = "Member";
    public DateTime JoinedAt { get; set; }
    public bool IsActive { get; set; }
}