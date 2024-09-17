using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AzureDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8107a1c0-15e5-45f8-b974-94ec0f1e3de2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fda4dccf-82e3-4505-803e-f57454ccb96c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64c5b284-994d-4c1e-8c0e-c94ec05e1e94", null, "Admin", "ADMIN" },
                    { "772097a3-0a2b-4d4d-9c02-9133fbef2348", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64c5b284-994d-4c1e-8c0e-c94ec05e1e94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "772097a3-0a2b-4d4d-9c02-9133fbef2348");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8107a1c0-15e5-45f8-b974-94ec0f1e3de2", null, "User", "USER" },
                    { "fda4dccf-82e3-4505-803e-f57454ccb96c", null, "Admin", "ADMIN" }
                });
        }
    }
}
