namespace StrikerTekMessagingApp.Auth.Services.Interface;

using StrikerTekMessagingApp.Auth.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;


public interface ILoginService
{
    public Task<IActionResult> Register(RegisterUserAuthDTO registerUserAuthDTO);
    public Task<IActionResult> Login(LoginRequestDTO loginRequestDTO);
    public Task<IActionResult> CheckIfAccountExists(UserAuthResponseDTO userAuthResponseDTO);
}