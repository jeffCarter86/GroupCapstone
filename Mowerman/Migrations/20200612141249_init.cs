using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mowerman.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0744940d-711c-41eb-a1a3-6af13a0dfaa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6cad703-dc33-4648-a872-8d3b18157550");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae6d034-0f39-4411-9d99-7d4a2ffe1346");

            migrationBuilder.DropColumn(
                name: "ClockIn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClockOut",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee20e293-e7a2-47d8-b8d7-ac7901af4f96", "3b0ff5c3-81a5-48cd-b64f-03482fef813e", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d493377-d1d1-4832-94d9-4761baeaf2e3", "144c1db3-d6c5-411b-a641-5f6fc3d6d947", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b2479f3-dba5-4cfd-9caa-b862ba4f3ab1", "b43de5c4-7573-4066-bbd0-3c1162ea3412", "Operation", "Operation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d493377-d1d1-4832-94d9-4761baeaf2e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b2479f3-dba5-4cfd-9caa-b862ba4f3ab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee20e293-e7a2-47d8-b8d7-ac7901af4f96");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClockIn",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClockOut",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobAddress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6cad703-dc33-4648-a872-8d3b18157550", "44ed3011-284b-4bc1-97b7-f07fb726ee7f", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eae6d034-0f39-4411-9d99-7d4a2ffe1346", "c24ab697-f155-49b2-8e90-11732c9e1439", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0744940d-711c-41eb-a1a3-6af13a0dfaa4", "c0d000c9-5dac-48e1-bb80-0c2b0e02dc17", "Operation", "Operation" });
        }
    }
}
