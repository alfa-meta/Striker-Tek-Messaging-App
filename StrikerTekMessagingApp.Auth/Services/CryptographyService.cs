// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Services/CryptographyService.cs

namespace StrikerTekMessagingApp.Auth.Services;

using StrikerTekMessagingApp.Auth.Services.Interface;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

public class CryptographyService : ICryptographyService
{
    private readonly string _jwtSecret;
    private readonly string _jwtIssuer;
    private readonly string _jwtAudience;
    private readonly int _jwtExpirationMinutes;

    public CryptographyService(IOptions<JwtSettings> jwtSettings)
    {
        var settings = jwtSettings.Value;
        _jwtSecret = settings.Secret ?? throw new ArgumentNullException(nameof(settings.Secret));
        _jwtIssuer = settings.Issuer ?? throw new ArgumentNullException(nameof(settings.Issuer));
        _jwtAudience = settings.Audience ?? throw new ArgumentNullException(nameof(settings.Audience));
        _jwtExpirationMinutes = settings.ExpirationMinutes;
    }

    public string GenerateSalt()
    {
        byte[] saltBytes = new byte[32];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }
        
        return Convert.ToBase64String(saltBytes);
    }

    public string HashPassword(string password, string salt)
    {
        byte[] saltBytes = Convert.FromBase64String(salt);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            saltBytes,
            100000,
            HashAlgorithmName.SHA256,
            32
        );

        return Convert.ToBase64String(hash);
    }

    public bool VerifyPassword(string password, string salt, string hash)
    {
        string computedHash = HashPassword(password, salt);
        return computedHash == hash;
    }

    public string GenerateJwtToken(string userId, string email)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: _jwtIssuer,
            audience: _jwtAudience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtExpirationMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public ClaimsPrincipal? ValidateJwtToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret));

        try
        {
            var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = securityKey,
                ValidateIssuer = true,
                ValidIssuer = _jwtIssuer,
                ValidateAudience = true,
                ValidAudience = _jwtAudience,
                ValidateLifetime = true,
            }, out SecurityToken validatedToken);

            return principal;
        }
        catch
        {
            return null;
        }
    }
}