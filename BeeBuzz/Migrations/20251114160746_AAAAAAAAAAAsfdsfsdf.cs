using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class AAAAAAAAAAAsfdsfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                newName: "OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_OrganizationId",
                table: "AspNetUsers",
                column: "OrganizationId",
                principalTable: "BeeHiveOrganizations",
                principalColumn: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_OrganizationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "AspNetUsers",
                newName: "BeeBuzzOrganizationOrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_OrganizationId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_BeeBuzzOrganizationOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BeeHiveOrganizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                column: "BeeBuzzOrganizationOrganizationId",
                principalTable: "BeeHiveOrganizations",
                principalColumn: "OrganizationId");
        }
    }
}
