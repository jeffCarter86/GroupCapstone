using Microsoft.EntityFrameworkCore.Migrations;

namespace Mowerman.Migrations
{
    public partial class AddingStateToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fca6b85-3959-427f-ac1f-3d266a7fcc68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70a486ff-db25-4fd9-b3fd-0065b1b4b1da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a89a6411-f1d4-4f20-9e77-6c46ba88a09d");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6fca6b85-3959-427f-ac1f-3d266a7fcc68", "16c57645-a47c-47e6-83d3-d29004e4f397", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70a486ff-db25-4fd9-b3fd-0065b1b4b1da", "96d0d2b9-b415-44f0-a836-19b4f0623c22", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a89a6411-f1d4-4f20-9e77-6c46ba88a09d", "4707a8a3-8de5-42ac-a2aa-b01a2f80ac12", "Operation", "Operation" });
        }
    }
}
