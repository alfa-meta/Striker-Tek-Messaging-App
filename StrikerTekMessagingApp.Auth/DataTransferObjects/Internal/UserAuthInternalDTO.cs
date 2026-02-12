

namespace StrikerTekMessagingApp.Auth.DataTransferObjects.Internal;

// DO NOT EXPOSE THIS VIA API - internal use only!

internal class UserAuthInternalDTO
{
    public Guid UserAuthGuid { get; set; }
    public Guid UserGuid { get; set; }
    public string PublicKey { get; set; } = "";
    public string Email { get; set; } = "";
}