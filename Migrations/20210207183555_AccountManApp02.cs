using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManagementApp2.Migrations
{
    public partial class AccountManApp02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdatedDate",
                table: "Accounts",
                newName: "lastUpdatedDate");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Accounts",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "IsComplete",
                table: "Accounts",
                newName: "isComplete");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Accounts",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Accounts",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Accounts",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DeletionDate",
                table: "Accounts",
                newName: "deletionDate");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Accounts",
                newName: "dateOfBirth");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Accounts",
                newName: "createdDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastUpdatedDate",
                table: "Accounts",
                newName: "LastUpdatedDate");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Accounts",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "isComplete",
                table: "Accounts",
                newName: "IsComplete");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Accounts",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Accounts",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Accounts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "deletionDate",
                table: "Accounts",
                newName: "DeletionDate");

            migrationBuilder.RenameColumn(
                name: "dateOfBirth",
                table: "Accounts",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "Accounts",
                newName: "CreatedDate");
        }
    }
}
