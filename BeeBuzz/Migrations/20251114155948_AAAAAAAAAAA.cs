using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class AAAAAAAAAAA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "BeeHiveOrganizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeeHiveOrganizations",
                table: "BeeHiveOrganizations",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                column: "BeeBuzzOrganizationOrganizationId",
                principalTable: "BeeHiveOrganizations",
                principalColumn: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BeeHiveOrganizations",
                table: "BeeHiveOrganizations");

            migrationBuilder.RenameTable(
                name: "BeeHiveOrganizations",
                newName: "Organizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                column: "BeeBuzzOrganizationOrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId");
        }
    }
}
