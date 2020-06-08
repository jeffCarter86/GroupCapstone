using Microsoft.EntityFrameworkCore.Migrations;

namespace Mowerman.Migrations
{
    public partial class AddingPhoneNumberToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "762207dc-e922-4786-be59-7eb9bbf5beee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc5e9895-f94c-4747-b450-14fc5fd97fe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deebfb16-a78a-4001-9902-92c17ddff9ed");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36270bac-55d9-4d85-ae48-0f2c0acf48c4", "ba9f889c-ad71-4a4f-9ba3-914e7b5db560", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e7918f3-478f-47d5-9145-5faa273d6082", "8daf0799-43e0-490f-8383-8f45d0e7b1a4", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e45271c8-d6c2-4b51-a9b4-6e1bc5932741", "641729dc-4323-4636-bff3-e762b7a4f994", "Operation", "Operation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36270bac-55d9-4d85-ae48-0f2c0acf48c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e7918f3-478f-47d5-9145-5faa273d6082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45271c8-d6c2-4b51-a9b4-6e1bc5932741");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc5e9895-f94c-4747-b450-14fc5fd97fe9", "dad6cb17-188a-4a0d-80ba-53fa63d57e0c", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "deebfb16-a78a-4001-9902-92c17ddff9ed", "c1adfa1a-59fc-432f-aa84-df39beecdc25", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "762207dc-e922-4786-be59-7eb9bbf5beee", "8d07cb3f-e063-4859-8555-52b915651031", "Operation", "Operation" });
        }
    }
}
