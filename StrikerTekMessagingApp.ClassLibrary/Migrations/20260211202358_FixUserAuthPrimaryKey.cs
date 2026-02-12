using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StrikerTekMessagingApp.ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class FixUserAuthPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserGuid",
                table: "RefreshTokens",
                newName: "UserAuthGuid");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_UserGuid",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_UserAuthGuid");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserAuths",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserAuthGuid",
                table: "UserAuths",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_Email",
                table: "UserAuths",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_UserGuid",
                table: "UserAuths",
                column: "UserGuid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserAuths_Email",
                table: "UserAuths");

            migrationBuilder.DropIndex(
                name: "IX_UserAuths_UserGuid",
                table: "UserAuths");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserAuths");

            migrationBuilder.DropColumn(
                name: "UserAuthGuid",
                table: "UserAuths");

            migrationBuilder.RenameColumn(
                name: "UserAuthGuid",
                table: "RefreshTokens",
                newName: "UserGuid");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_UserAuthGuid",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_UserGuid");
        }
    }
}
