
// /Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/DataTransferObjects/UserAuthResponseDTO.cs
using System.ComponentModel.DataAnnotations;

namespace StrikerTekMessagingApp.Auth;


// This is part of Auth Database.
public class UserAuthResponseDTO
{
    public Guid UserAuthGuid { get; set; }
    public Guid UserGuid { get; set; }
    public string Email { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}
