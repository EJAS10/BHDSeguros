using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHDSeguros.Migrations
{
    /// <inheritdoc />
    public partial class agregandocamposdetipoproductoalossegurosdelcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypeSecureCode_AllowedProductType_ProductTypeId",
                table: "ProductTypeSecureCode");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypeSecureCode_SecureCode_SecureCodeId",
                table: "ProductTypeSecureCode");

            migrationBuilder.DropForeignKey(
                name: "FK_SecureApplications_AllowedProductType_ProductTypeId",
                table: "SecureApplications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypeSecureCode",
                table: "ProductTypeSecureCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllowedProductType",
                table: "AllowedProductType");

            migrationBuilder.RenameTable(
                name: "ProductTypeSecureCode",
                newName: "SecureCodeProductType");

            migrationBuilder.RenameTable(
                name: "AllowedProductType",
                newName: "ProductType");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTypeSecureCode_SecureCodeId",
                table: "SecureCodeProductType",
                newName: "IX_SecureCodeProductType_SecureCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTypeSecureCode_ProductTypeId",
                table: "SecureCodeProductType",
                newName: "IX_SecureCodeProductType_ProductTypeId");

            migrationBuilder.AddColumn<string>(
                name: "ProductNumber",
                table: "ClientSecure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "ClientSecure",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecureCodeProductType",
                table: "SecureCodeProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSecure_ProductTypeId",
                table: "ClientSecure",
                column: "ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSecure_ProductType_ProductTypeId",
                table: "ClientSecure",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecureApplications_ProductType_ProductTypeId",
                table: "SecureApplications",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecureCodeProductType_ProductType_ProductTypeId",
                table: "SecureCodeProductType",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecureCodeProductType_SecureCode_SecureCodeId",
                table: "SecureCodeProductType",
                column: "SecureCodeId",
                principalTable: "SecureCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSecure_ProductType_ProductTypeId",
                table: "ClientSecure");

            migrationBuilder.DropForeignKey(
                name: "FK_SecureApplications_ProductType_ProductTypeId",
                table: "SecureApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_SecureCodeProductType_ProductType_ProductTypeId",
                table: "SecureCodeProductType");

            migrationBuilder.DropForeignKey(
                name: "FK_SecureCodeProductType_SecureCode_SecureCodeId",
                table: "SecureCodeProductType");

            migrationBuilder.DropIndex(
                name: "IX_ClientSecure_ProductTypeId",
                table: "ClientSecure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecureCodeProductType",
                table: "SecureCodeProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "ProductNumber",
                table: "ClientSecure");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "ClientSecure");

            migrationBuilder.RenameTable(
                name: "SecureCodeProductType",
                newName: "ProductTypeSecureCode");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "AllowedProductType");

            migrationBuilder.RenameIndex(
                name: "IX_SecureCodeProductType_SecureCodeId",
                table: "ProductTypeSecureCode",
                newName: "IX_ProductTypeSecureCode_SecureCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_SecureCodeProductType_ProductTypeId",
                table: "ProductTypeSecureCode",
                newName: "IX_ProductTypeSecureCode_ProductTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypeSecureCode",
                table: "ProductTypeSecureCode",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllowedProductType",
                table: "AllowedProductType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypeSecureCode_AllowedProductType_ProductTypeId",
                table: "ProductTypeSecureCode",
                column: "ProductTypeId",
                principalTable: "AllowedProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypeSecureCode_SecureCode_SecureCodeId",
                table: "ProductTypeSecureCode",
                column: "SecureCodeId",
                principalTable: "SecureCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecureApplications_AllowedProductType_ProductTypeId",
                table: "SecureApplications",
                column: "ProductTypeId",
                principalTable: "AllowedProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
