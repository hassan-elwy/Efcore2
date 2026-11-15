using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore2.Migrations
{
    /// <inheritdoc />
    public partial class definingRelationshipsAndConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "EventOrganizer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EventOrganizer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AttendeeId",
                table: "badges",
                newName: "AttendeeID");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "attendees",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "attendees",
                newName: "ZipCode");

            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "organzierProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_organzierProfiles_OrganizerId",
                table: "organzierProfiles",
                column: "OrganizerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_badges_AttendeeID",
                table: "badges",
                column: "AttendeeID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_badges_attendees_AttendeeID",
                table: "badges",
                column: "AttendeeID",
                principalTable: "attendees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organzierProfiles_EventOrganizer_OrganizerId",
                table: "organzierProfiles",
                column: "OrganizerId",
                principalTable: "EventOrganizer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_badges_attendees_AttendeeID",
                table: "badges");

            migrationBuilder.DropForeignKey(
                name: "FK_organzierProfiles_EventOrganizer_OrganizerId",
                table: "organzierProfiles");

            migrationBuilder.DropIndex(
                name: "IX_organzierProfiles_OrganizerId",
                table: "organzierProfiles");

            migrationBuilder.DropIndex(
                name: "IX_badges_AttendeeID",
                table: "badges");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "organzierProfiles");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EventOrganizer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventOrganizer",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AttendeeID",
                table: "badges",
                newName: "AttendeeId");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "attendees",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "attendees",
                newName: "PostalCode");
        }
    }
}
