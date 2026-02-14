// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Repositories/Interface/IUserAuthRepository.cs

using StrikerTekMessagingApp.ClassLibrary.Models.Auth;

namespace StrikerTekMessagingApp.Auth.Repositories.Interface;


public interface IUserAuthRepository
{
    Task<UserAuth?> GetByEmailAsync(string email);
    Task<UserAuth?> GetByUserAuthGuidAsync(Guid userAuthGuid);
    Task<UserAuth?> GetAuthUserByEmailAndPasswordHash(string email, string passwordHash);
    Task CreateAccountAsync(UserAuth userAuth);
    Task UpdateAccountAsync(UserAuth userAuth);
    Task DeleteAsync(Guid userAuthGuid);
}