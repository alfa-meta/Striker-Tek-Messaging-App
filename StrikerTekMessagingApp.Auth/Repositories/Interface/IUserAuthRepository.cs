// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Repositories/Interface/IUserAuthRepository.cs

using StrikerTekMessagingApp.ClassLibrary.Models.Auth;

namespace StrikerTekMessagingApp.Auth;


public interface IUserAuthRepository
{
    Task<UserAuth?> GetByEmailAsync(string email);
    Task<UserAuth?> GetByGuidAsync(Guid guid);
    Task CreateAccountAsync(UserAuth userAuth);
    Task UpdateAccountAsync(UserAuth userAuth);
    Task DeleteAsync(Guid guid);
}