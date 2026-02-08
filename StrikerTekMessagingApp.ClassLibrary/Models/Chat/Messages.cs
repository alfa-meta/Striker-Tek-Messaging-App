namespace StrikerTekMessagingApp.ClassLibrary;

public class Messages
{
    public int MessageId { get; set; }
    public Guid ChatGuid { get; set; }
    public Guid UserGuid { get; set; }
    public Guid? FileGuid { get; set; }
    public byte[]? MessageText { get; set; }
    public int? ReplyToMessageId { get; set; }
    public int? ForwardedToMessageId { get; set; }
    public bool IsEdited { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime EditedAt { get; set; }
    public string Status { get; set; } = "null";
    public DateTime Timestamp { get; set; }
}
