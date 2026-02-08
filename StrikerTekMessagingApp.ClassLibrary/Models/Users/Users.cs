namespace StrikerTekMessagingApp.ClassLibrary;
public class Users
{
    public Guid UserGuid { get; set; }
    public string Username { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string UserStatus { get; set; } = "";
    public Guid? fileGuid { get; set; }
    public Guid? PaymentGuid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastOnline { get; set; }
}