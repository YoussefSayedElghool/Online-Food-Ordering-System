using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Food_Ordering_System.Migrations
{
    /// <inheritdoc />
    public partial class solvemistakedatabasedesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CType",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Veg_Non",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "CTypeId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VegId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CType",
                columns: table => new
                {
                    CTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CType", x => x.CTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Veg",
                columns: table => new
                {
                    VegId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veg", x => x.VegId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CTypeId",
                table: "Foods",
                column: "CTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_VegId",
                table: "Foods",
                column: "VegId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_CType_CTypeId",
                table: "Foods",
                column: "CTypeId",
                principalTable: "CType",
                principalColumn: "CTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Veg_VegId",
                table: "Foods",
                column: "VegId",
                principalTable: "Veg",
                principalColumn: "VegId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_CType_CTypeId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Veg_VegId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "CType");

            migrationBuilder.DropTable(
                name: "Veg");

            migrationBuilder.DropIndex(
                name: "IX_Foods_CTypeId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_VegId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CTypeId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VegId",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "CType",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Veg_Non",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
