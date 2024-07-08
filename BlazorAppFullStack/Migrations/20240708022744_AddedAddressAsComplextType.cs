using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppFullStack.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddressAsComplextType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Patient",
                newName: "Address_ZipCode");

            migrationBuilder.RenameColumn(
                name: "Street2",
                table: "Patient",
                newName: "Address_Street2");

            migrationBuilder.RenameColumn(
                name: "Street1",
                table: "Patient",
                newName: "Address_Street1");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Patient",
                newName: "Address_State");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Patient",
                newName: "Address_City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_ZipCode",
                table: "Patient",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "Address_Street2",
                table: "Patient",
                newName: "Street2");

            migrationBuilder.RenameColumn(
                name: "Address_Street1",
                table: "Patient",
                newName: "Street1");

            migrationBuilder.RenameColumn(
                name: "Address_State",
                table: "Patient",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Patient",
                newName: "City");
        }
    }
}
