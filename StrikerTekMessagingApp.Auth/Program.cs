// Striker-Tek-Messaging-App/StrikerTekMessagingApp.Auth/Program.cs

using StrikerTekMessagingApp.ClassLibrary.Models.Auth;
using StrikerTekMessagingApp.Auth.Services;
using StrikerTekMessagingApp.Auth.Services.Interface;
using StrikerTekMessagingApp.Auth.Repositories;
using StrikerTekMessagingApp.Auth.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthDatabase"))
);

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));

// Register repositories
builder.Services.AddScoped<IUserAuthRepository, UserAuthRepository>();

// Register services
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddSingleton<ICryptographyService, CryptographyService>();

var app = builder.Build();

// Run migrations
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AuthDbContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Remove or conditionally apply HTTPS redirection
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();