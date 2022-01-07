using Microsoft.EntityFrameworkCore.Migrations;

namespace Martin_Manuel_proiect.Migrations
{
    public partial class removedelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Phone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Delivery",
                table: "Phone",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
