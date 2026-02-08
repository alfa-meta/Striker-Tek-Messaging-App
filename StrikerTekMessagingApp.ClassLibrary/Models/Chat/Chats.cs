namespace StrikerTekMessagingApp.ClassLibrary;

public class Chats
{
    public Guid ChatGuid { get; set; }
    public Guid CreatorUserGuid { get; set; }
    public string ChatType { get; set; } = "Direct";
    public string ChatName { get; set; } = "Null";
    public string? ChatDescription { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastMessageAt { get; set; }
}