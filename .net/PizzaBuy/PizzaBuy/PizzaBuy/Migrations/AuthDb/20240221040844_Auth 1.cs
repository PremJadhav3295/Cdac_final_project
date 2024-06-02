using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaBuy.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Auth1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "280549d0-a41d-42e2-895e-599f191b2f71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a48b371-9085-4ce7-a468-3edbe4c2cfec", "AQAAAAEAACcQAAAAELnexh0PLH8K/7GUcmLGAo41+L7l++aR4hroZqbMy//4p6TM9mNEPPKYtwghIkc80w==", "4e89f70c-0207-4be0-9d63-ac50ef70f9f4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "280549d0-a41d-42e2-895e-599f191b2f71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0715b387-4be5-4eca-ac99-8a2e4862fe54", "AQAAAAEAACcQAAAAEIINZyxbk7tOGUzWXvREd0oJXBTbnLLVXJXgTIXJCzEkKVuVh2UoImCtcmYde1W4Ug==", "8b8cbe9d-61d9-41eb-b983-e5924d875239" });
        }
    }
}
