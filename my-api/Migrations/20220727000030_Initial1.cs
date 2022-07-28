using Microsoft.EntityFrameworkCore.Migrations;

namespace my_api.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoverPHoto",
                table: "Books",
                newName: "CoverPhoto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoverPhoto",
                table: "Books",
                newName: "CoverPHoto");
        }
    }
}
