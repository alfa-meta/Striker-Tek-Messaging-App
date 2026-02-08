// \Striker-Tek-Messaging-App\StrikerTekMessaginApp.Auth\Program.cs

using StrikerTekMessagingApp.ClassLibrary;


builder.Services.AddDbContext<AuthDbContext>( options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthDatabase"))
);