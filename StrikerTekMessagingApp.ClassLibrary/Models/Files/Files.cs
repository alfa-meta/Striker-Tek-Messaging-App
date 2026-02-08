namespace StrikerTekMessagingApp.ClassLibrary;

public class FileItems
{
    public Guid? FileGuid { get; set; }
    public string? FileName { get; set; } = "";
    public int FileSize { get; set; }
    public string? MimeType { get; set; } = "";
    public DateTime UploadedAt { get; set; }
}

