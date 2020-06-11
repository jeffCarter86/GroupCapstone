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
                keyValue: "87ae5b69-51f1-4858-acb3-002520b099f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9383383f-fde0-408d-b4f7-c088ceb8e7f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c325c8bb-34f5-4c0d-8528-bedacce8eae9");

            migrationBuilder.CreateTable(
                name: "TimeClock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team = table.Column<string>(nullable: true),
                    JobAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: false),
                    ClockIn = table.Column<DateTime>(nullable: true),
                    ClockOut = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeClock", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6fea5978-8790-458e-ae22-6bdecc24aa3e", "26bbff2a-a67e-4190-9882-59d3d4a2d00b", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58a1fca5-fadd-4ee8-9ca1-b87ed459841f", "b8bf0f4d-7ba3-4895-81fb-0f13b06c4622", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "225757e5-d172-44cc-af13-e916d5e405de", "4f0284e7-bc3e-48a6-a93e-01c4d6ecdfbe", "Operation", "Operation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeClock");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "225757e5-d172-44cc-af13-e916d5e405de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58a1fca5-fadd-4ee8-9ca1-b87ed459841f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fea5978-8790-458e-ae22-6bdecc24aa3e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87ae5b69-51f1-4858-acb3-002520b099f1", "8e9237ab-c164-4420-826b-161aac3abce5", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c325c8bb-34f5-4c0d-8528-bedacce8eae9", "17508ac6-d5eb-4702-b352-e669897c75a0", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9383383f-fde0-408d-b4f7-c088ceb8e7f2", "576fd538-3eda-4f31-82c1-bffd0f2522de", "Operation", "Operation" });
        }
    }
}
