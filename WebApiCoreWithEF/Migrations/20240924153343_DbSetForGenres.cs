using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystemEF.Migrations
{
    /// <inheritdoc />
    public partial class DbSetForGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(3639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 305, DateTimeKind.Local).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 500, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfEmployment",
                value: new DateTime(2024, 9, 24, 18, 33, 43, 307, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(6802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 500, DateTimeKind.Local).AddTicks(8225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 305, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfEmployment",
                value: new DateTime(2024, 9, 23, 22, 33, 16, 502, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
