using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppFullStack.Migrations
{
    /// <inheritdoc />
    public partial class AddedNameComplexType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Patient",
                newName: "Name_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Patient",
                newName: "Name_FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Name_MiddleName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name_MiddleName",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "Name_LastName",
                table: "Patient",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name_FirstName",
                table: "Patient",
                newName: "FirstName");
        }
    }
}
