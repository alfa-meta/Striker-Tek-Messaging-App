namespace StrikerTekMessaginApp.Auth;

using Microsoft.AspNetCore.Mvc;

public interface IAuthController
{
    Task<IActionResult> Home();
    Task<IActionResult> Register();
    Task<IActionResult> Login();
    Task<IActionResult> RefreshToken();
}