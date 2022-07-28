using Microsoft.EntityFrameworkCore.Migrations;

namespace my_api.Migrations
{
    public partial class MtoManyInitail1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_publisherId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "publisherId",
                table: "Books",
                newName: "PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_publisherId",
                table: "Books",
                newName: "IX_Books_PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Books",
                newName: "publisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                newName: "IX_Books_publisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_publisherId",
                table: "Books",
                column: "publisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
