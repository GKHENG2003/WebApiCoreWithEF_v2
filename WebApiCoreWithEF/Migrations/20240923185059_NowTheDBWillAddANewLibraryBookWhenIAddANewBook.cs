using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystemEF.Migrations
{
    /// <inheritdoc />
    public partial class NowTheDBWillAddANewLibraryBookWhenIAddANewBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Biography = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfMembership = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(8877)),
                    MembershipDuration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Books_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookDetailsId = table.Column<int>(type: "int", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    TitleSnapshot = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    YearSnapshot = table.Column<int>(type: "int", nullable: false),
                    GenreSnapshot = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 9, 23, 21, 50, 59, 125, DateTimeKind.Local).AddTicks(4161)),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_BookDetailsId",
                        column: x => x.BookDetailsId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBooks", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_LibraryBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Science Fiction" },
                    { 3, "Art" },
                    { 4, "Gazetteers" },
                    { 5, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "Email", "Name", "Password", "UserType" },
                values: new object[,]
                {
                    { 1, "Author One Biography", "AuthorOne@exmaple.com", "Author One", "password", "Author" },
                    { 2, "Author Two Biography", "AuthorTwo@exmaple.com", "Author Two", "password", "Author" },
                    { 3, "Author Three Biography", "AuthorThree@exmaple.com", "Author Three", "password", "Author" },
                    { 4, "Author Four Biography", "AuthorFour@exmaple.com", "Author Four", "password", "Author" },
                    { 5, "Author Five Biography", "AuthorFive@exmaple.com", "Author Five", "password", "Author" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfMembership", "Email", "MembershipDuration", "Name", "Password", "UserType" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(9904), "johnDoe@example.com", 30, "John Doe", "john123", "Member" },
                    { 7, new DateTime(2024, 9, 23, 21, 50, 59, 127, DateTimeKind.Local).AddTicks(9921), "janDoe@example.com", 30, "Jane Doe", "jane123", "Member" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfEmployment", "Email", "Name", "Password", "Salary", "UserType" },
                values: new object[] { 8, new DateTime(2024, 9, 23, 21, 50, 59, 126, DateTimeKind.Local).AddTicks(6632), "ahmedSmith@exmaple.com", "Ahmed Smith", "ahmed123", 5000, "Librarian" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "GenreId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, "The Great Gatsby", 1925 },
                    { 2, 2, 2, "To Kill a Mockingbird", 1960 },
                    { 3, 3, 3, "1984", 1949 },
                    { 4, 4, 4, "Pride and Prejudice", 1813 },
                    { 5, 5, 5, "The Catcher in the Rye", 1951 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookDetailsId",
                table: "BorrowedBooks",
                column: "BookDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_MemberId",
                table: "BorrowedBooks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "LibraryBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
