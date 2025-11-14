using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedOrganizationToBeeBuzzOrganizationScrewSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehive_AspNetUsers_ApplicationUserId",
                table: "Beehive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beehive",
                table: "Beehive");

            migrationBuilder.RenameTable(
                name: "Beehive",
                newName: "Beehives");

            migrationBuilder.RenameIndex(
                name: "IX_Beehive_ApplicationUserId",
                table: "Beehives",
                newName: "IX_Beehives_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beehives",
                table: "Beehives",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                column: "BeeBuzzOrganizationOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers",
                column: "BeeBuzzOrganizationOrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beehives",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "BeeBuzzOrganizationOrganizationId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Beehives",
                newName: "Beehive");

            migrationBuilder.RenameIndex(
                name: "IX_Beehives_ApplicationUserId",
                table: "Beehive",
                newName: "IX_Beehive_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beehive",
                table: "Beehive",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehive_AspNetUsers_ApplicationUserId",
                table: "Beehive",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
