// Striker-Tek-Messaging-App/StrikerTekMessagingApp.ClassLibrary/Models/Auth/AuthDbContext.cs

namespace StrikerTekMessagingApp.ClassLibrary.Models.Auth;

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

        modelBuilder.Entity<UserAuth>(entity =>
        {
            entity.HasKey(e => e.UserAuthGuid);
            entity.HasIndex(e => e.UserGuid);
            entity.HasIndex(e => e.Email).IsUnique();

            entity.Property(e => e.PublicKey).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.PasswordSalt).IsRequired();
            entity.Property(e => e.PasswordHash).IsRequired();
            entity.Property(e => e.CreatedAt).IsRequired();
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
           entity.HasKey(e => e.TokenHash);
           entity.HasIndex(e => e.UserAuthGuid);
           entity.HasIndex(e => e.ExpiresAt);
           entity.HasIndex(e => e.Jti).IsUnique();

           entity.Property(e => e.TokenHash).IsRequired();
           entity.Property(e => e.Jti).IsRequired();
           entity.Property(e => e.CreatedAt).IsRequired();
           entity.Property(e => e.ExpiresAt).IsRequired();

           // Foreign key relationship
           entity.HasOne(e => e.UserAuth)
                .WithMany(u => u.RefreshTokens)
                .HasForeignKey(e => e.UserAuthGuid)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}