using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystemEF.Migrations
{
    /// <inheritdoc />
    public partial class AddValueOnAddOnAllPKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(6802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 500, DateTimeKind.Local).AddTicks(8225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 125, DateTimeKind.Local).AddTicks(4161));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(8877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 503, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 125, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 23, 22, 33, 16, 500, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfEmployment",
                value: new DateTime(2024, 9, 23, 21, 50, 59, 126, DateTimeKind.Local).AddTicks(6632));
        }
    }
}
