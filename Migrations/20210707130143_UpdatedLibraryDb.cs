using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class UpdatedLibraryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksViewModel");

            migrationBuilder.DropTable(
                name: "LibraryMember");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "CheckedOutBooks");

            migrationBuilder.DropColumn(
                name: "Name_Id",
                table: "CheckedOutBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReturned",
                table: "CheckedOutBooks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "CheckedOutBooks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "CheckedOutBooks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCopies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutBooks_BookId",
                table: "CheckedOutBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutBooks_MemberId",
                table: "CheckedOutBooks",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedOutBooks_Books_BookId",
                table: "CheckedOutBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedOutBooks_Members_MemberId",
                table: "CheckedOutBooks",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckedOutBooks_Books_BookId",
                table: "CheckedOutBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckedOutBooks_Members_MemberId",
                table: "CheckedOutBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropIndex(
                name: "IX_CheckedOutBooks_BookId",
                table: "CheckedOutBooks");

            migrationBuilder.DropIndex(
                name: "IX_CheckedOutBooks_MemberId",
                table: "CheckedOutBooks");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "CheckedOutBooks");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "CheckedOutBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReturned",
                table: "CheckedOutBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "CheckedOutBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Name_Id",
                table: "CheckedOutBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BooksViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCopies = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryMember", x => x.Id);
                });
        }
    }
}
