// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Models/Requests/RegisterRequest.cs

using System.ComponentModel.DataAnnotations;

namespace StrikerTekMessagingApp.Auth.Models.Requests;

/// <summary>
/// Request model for user registration endpoint.
/// </summary>
public class RegisterRequest
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

    /// <summary>
    /// User's public key for end-to-end encryption.
    /// </summary>
    [Required]
    public string PublicKey { get; set; } = "";

    /// <summary>
    /// Optional device information for the refresh token (e.g., "Chrome on Windows").
    /// </summary>
    public string? DeviceInfo { get; set; }
}