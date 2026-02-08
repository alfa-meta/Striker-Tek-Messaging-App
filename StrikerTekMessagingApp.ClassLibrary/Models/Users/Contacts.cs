namespace StrikerTekMessagingApp.ClassLibrary;

public class Contacts
{
    public int ContactId { get; set; }
    public Guid UserGuid { get; set; }
    public Guid ContactUserGuid { get; set; }
    public DateTime AddedAt { get; set; }
}