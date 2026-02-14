using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrikerTekMessagingApp.ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAuths",
                columns: table => new
                {
                    UserAuthGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuths", x => x.UserAuthGuid);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    TokenHash = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAuthGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Jti = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    DeviceInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.TokenHash);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_UserAuths_UserAuthGuid",
                        column: x => x.UserAuthGuid,
                        principalTable: "UserAuths",
                        principalColumn: "UserAuthGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_ExpiresAt",
                table: "RefreshTokens",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_Jti",
                table: "RefreshTokens",
                column: "Jti",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserAuthGuid",
                table: "RefreshTokens",
                column: "UserAuthGuid");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_Email",
                table: "UserAuths",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_UserGuid",
                table: "UserAuths",
                column: "UserGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserAuths");
        }
    }
}
