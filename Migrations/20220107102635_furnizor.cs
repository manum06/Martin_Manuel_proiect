using Microsoft.EntityFrameworkCore.Migrations;

namespace Martin_Manuel_proiect.Migrations
{
    public partial class furnizor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Supplier",
                table: "Phone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Phone",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phone_SupplierID",
                table: "Phone",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Supplier_SupplierID",
                table: "Phone",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Supplier_SupplierID",
                table: "Phone");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Phone_SupplierID",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "Supplier",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Phone");
        }
    }
}
