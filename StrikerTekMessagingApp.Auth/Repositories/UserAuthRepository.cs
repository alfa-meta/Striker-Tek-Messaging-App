// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Repositories/Interface/IUserAuthRepository.cs

using StrikerTekMessagingApp.ClassLibrary.Models.Auth;
using StrikerTekMessagingApp.Auth.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace StrikerTekMessagingApp.Auth.Repositories;

public class UserAuthRepository : IUserAuthRepository
{
    private readonly AuthDbContext _context;

    public UserAuthRepository(AuthDbContext context)
    {
        _context = context;
    }

    public async Task<UserAuth?> GetByEmailAsync(string email)
    {
        return await _context.UserAuths
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<UserAuth?> GetByUserAuthGuidAsync(Guid userAuthGuid)
    {
        return await _context.UserAuths
            .FirstOrDefaultAsync(u => u.UserAuthGuid == userAuthGuid);
    }

    public async Task<UserAuth?> GetAuthUserByEmailAndPasswordHash(string email, string passwordHash)
    {
        return await _context.UserAuths
            .FirstOrDefaultAsync(u => u.Email == email && u.PasswordHash == passwordHash);
    }

    public async Task CreateAccountAsync(UserAuth userAuth)
    {
        
    }

    public async Task UpdateAccountAsync(UserAuth userAuth)
    {
        
    }

    public async Task DeleteAsync(Guid userAuthGuid)
    {
        
    }
}