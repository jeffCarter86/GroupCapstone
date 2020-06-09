using Microsoft.EntityFrameworkCore.Migrations;

namespace Mowerman.Migrations
{
    public partial class RemovingRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25f2b4de-d96c-4c2e-8ebf-9c2acfe59b0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a0e7299-e68e-4ce6-979a-ccedb261b2b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c39804a7-edf6-4ae8-beea-4c9143f263f2");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f0f4a98-bdbd-49c0-8a50-2d064122bb8b", "61eac4f4-b756-4977-8675-522bb262e7d8", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ff1fde5-62db-4de5-a551-62994a4d8141", "86219334-faa1-4803-900d-677df3174b53", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dc5e728-6412-4881-a8de-e4b3d03262e2", "a166c80a-3aec-45da-af84-573559f48317", "Operation", "Operation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc5e728-6412-4881-a8de-e4b3d03262e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff1fde5-62db-4de5-a551-62994a4d8141");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f0f4a98-bdbd-49c0-8a50-2d064122bb8b");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a0e7299-e68e-4ce6-979a-ccedb261b2b2", "e3289165-2fb8-441c-b4ba-09de082bee83", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25f2b4de-d96c-4c2e-8ebf-9c2acfe59b0e", "e5950e79-9b5c-48f4-a8c9-66d92fa08299", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c39804a7-edf6-4ae8-beea-4c9143f263f2", "08af3d96-9a92-499a-b7c2-9d8b5b785995", "Operation", "Operation" });
        }
    }
}
