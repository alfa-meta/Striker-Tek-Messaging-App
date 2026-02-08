namespace StrikerTekMessagingApp.ClassLibrary;

using Microsoft.EntityFrameworkCore;

public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    public DbSet<UserAuth> UserAuths { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RefreshToken>(entity =>
        {
           entity.HasKey(e => e.TokenHash);
           entity.HasIndex(e => e.UserGuid);
           entity.HasIndex(e => e.ExpiresAt);
           entity.HasIndex(e => e.Jti);
        });

        modelBuilder.Entity<UserAuth>(entity =>
        {
            entity.HasKey(e => e.UserGuid);
        });
    }
}