using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployess.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59276d19-35ba-4b5e-9c39-0b4ad5fdc5b3", "d083f9f8-7b7a-480c-8b5b-d8c8cc14fc5b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad8edc9d-8dce-4434-a8ae-670e10d18775", "67918389-450c-49f6-8384-853ca57bc7bb", "Manager", "MANAGER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59276d19-35ba-4b5e-9c39-0b4ad5fdc5b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad8edc9d-8dce-4434-a8ae-670e10d18775");
        }
    }
}
