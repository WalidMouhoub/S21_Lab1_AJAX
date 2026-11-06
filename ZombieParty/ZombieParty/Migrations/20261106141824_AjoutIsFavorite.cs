using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIsFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Zombies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsFavorite",
                value: false);

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsFavorite",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Zombies");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);
        }
    }
}
