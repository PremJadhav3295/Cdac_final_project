using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaBuy.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class NewDbMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "280549d0-a41d-42e2-895e-599f191b2f71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0715b387-4be5-4eca-ac99-8a2e4862fe54", "AQAAAAEAACcQAAAAEIINZyxbk7tOGUzWXvREd0oJXBTbnLLVXJXgTIXJCzEkKVuVh2UoImCtcmYde1W4Ug==", "8b8cbe9d-61d9-41eb-b983-e5924d875239" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "280549d0-a41d-42e2-895e-599f191b2f71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fcefca7-d7f3-45f4-b37a-2c47268765ba", "AQAAAAEAACcQAAAAEJf0iaDzVVhw5tDBtgy9DSQblYq1rzMqedNdeN3czMM/5GqjckLsxKNghJawfQMdpg==", "28a44e4d-3c7e-4a88-a7bc-1a202c2c95c5" });
        }
    }
}
