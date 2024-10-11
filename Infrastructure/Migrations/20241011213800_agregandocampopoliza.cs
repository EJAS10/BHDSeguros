using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHDSeguros.Migrations
{
    /// <inheritdoc />
    public partial class agregandocampopoliza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Policy",
                table: "ClientSecure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Policy",
                table: "ClientSecure");
        }
    }
}
