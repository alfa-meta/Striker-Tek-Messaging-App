// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Models/Requests/LoginRequest.cs

using System.ComponentModel.DataAnnotations;

namespace StrikerTekMessagingApp.Auth.Models.Requests;

/// <summary>
/// Request model for user Login endpoint.
/// </summary>
public class LoginRequest
{
    /// <summary>
    /// User's email address. Must be valid email format.
    /// </summary>
    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";

    /// <summary>
    /// User's password. Minimum 8 characters.
    /// </summary>
    [Required]
    [MinLength(8)]
    public string Password { get; set; } = "";
}