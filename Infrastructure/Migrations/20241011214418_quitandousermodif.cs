using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHDSeguros.Migrations
{
    /// <inheritdoc />
    public partial class quitandousermodif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "SecurePlans");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "SecureCode");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "SecureApplications");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "ProductTypeSecureCode");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "ClientSecure");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "UserModific",
                table: "AllowedProductType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "SecurePlans",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "SecureCode",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "SecureApplications",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "ProductTypeSecureCode",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "ClientSecure",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "Client",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserModific",
                table: "AllowedProductType",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
