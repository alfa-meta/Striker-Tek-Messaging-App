namespace StrikerTekMessaginApp.Auth;

using Microsoft.AspNetCore.Mvc;
using StrikerTekMessagingApp.Auth.Models.Requests;

public interface IAuthController
{
    Task<IActionResult> Home();
    Task<IActionResult> Register(RegisterRequest request);
    Task<IActionResult> Login();
    Task<IActionResult> RefreshToken();
}