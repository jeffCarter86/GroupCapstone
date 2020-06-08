using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mowerman.Data.Migrations
{
    public partial class ChangingDataTypeOfExtraMowDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5f6e8d3-089f-427e-9cc0-674c553fc68d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de55ec15-fb97-489d-8405-41024c6d9bf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd0965eb-1f62-4fd6-8c2c-d6cb3a64243c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraMowDay",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38474e37-618e-4798-8065-38185ccfe5c7", "f823cf58-5a91-48c9-b4bd-10c71e36b287", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40869d46-d02b-46df-885a-45fb03337580", "cf4a9fb4-2bfd-4b86-bb21-71813cd5928f", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c34d7ca9-a22e-4107-ba84-4dadf9bd6615", "44e0e2f6-008a-4918-ae99-9132a1d4748e", "Operation", "Operation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38474e37-618e-4798-8065-38185ccfe5c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40869d46-d02b-46df-885a-45fb03337580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c34d7ca9-a22e-4107-ba84-4dadf9bd6615");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExtraMowDay",
                table: "Customers",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5f6e8d3-089f-427e-9cc0-674c553fc68d", "5ab38a72-8d0a-417b-9351-1fadef8caa2c", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd0965eb-1f62-4fd6-8c2c-d6cb3a64243c", "98d25039-c9b2-4bcc-abaf-19ec0fbe528b", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de55ec15-fb97-489d-8405-41024c6d9bf4", "7089cdab-793a-442d-9155-f33a089c4157", "Operation", "Operation" });
        }
    }
}
