namespace StrikerTekMessagingApp.ClassLibrary;

public class Clients
{
    public int ClientInfoId { get; set; }
    public Guid UserGuid { get; set; }
    public string? IPAddress { get; set; } = "";
    public string? UserAgent { get; set; } = "";
    public string? ClientType { get; set; } = "";
    public string? ClientVersion { get; set; } = "";
    public string? DeviceModel { get; set; } = "";
    public string? OSName { get; set; } = "";
    public string? OSVersion { get; set; } = "";
    public string? Browser { get; set; } = "";
    public string? BrowserVersion { get; set; } = "";
    public string? ScreenResolution { get; set; } = "";
    public string? Timezone { get; set; } = "";
    public string? Language { get; set; } = "";
    public string? ConnectionType { get; set; } = "";
    public string? City { get; set; } = "";
    public string? Country { get; set; } = "";
    public string? CountryCode { get; set; } = "";
    public string? ISP { get; set; } = "";
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public DateTime CreateAd { get; set; }
    public DateTime UpdatedAt { get; set; }
}