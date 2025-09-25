using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystemEF.Migrations
{
    /// <inheritdoc />
    public partial class AppliedISoftDeletableForBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookDetailsId",
                table: "BorrowedBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 25, 16, 45, 49, 996, DateTimeKind.Local).AddTicks(3151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 16, 45, 49, 993, DateTimeKind.Local).AddTicks(2740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 305, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 25, 16, 45, 49, 996, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfMembership",
                value: new DateTime(2024, 9, 25, 16, 45, 49, 996, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfEmployment",
                value: new DateTime(2024, 9, 25, 16, 45, 49, 994, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookDetailsId",
                table: "BorrowedBooks",
                column: "BookDetailsId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookDetailsId",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfMembership",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 308, DateTimeKind.Local).AddTicks(3639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 25, 16, 45, 49, 996, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowedBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 18, 33, 43, 305, DateTimeKind.Local).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 16, 45, 49, 993, DateTimeKind.Local).AddTicks(2740));

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
                name: "FK_BorrowedBooks_Books_BookDetailsId",
                table: "BorrowedBooks",
                column: "BookDetailsId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
