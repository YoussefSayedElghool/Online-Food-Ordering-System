using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Food_Ordering_System.Migrations
{
    /// <inheritdoc />
    public partial class changwrongdatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_CType_CTypeId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Veg_VegId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veg",
                table: "Veg");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CType",
                table: "CType");

            migrationBuilder.RenameTable(
                name: "Veg",
                newName: "Vegs");

            migrationBuilder.RenameTable(
                name: "CType",
                newName: "CTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Vegs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vegs",
                table: "Vegs",
                column: "VegId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CTypes",
                table: "CTypes",
                column: "CTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_CTypes_CTypeId",
                table: "Foods",
                column: "CTypeId",
                principalTable: "CTypes",
                principalColumn: "CTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Vegs_VegId",
                table: "Foods",
                column: "VegId",
                principalTable: "Vegs",
                principalColumn: "VegId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_CTypes_CTypeId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Vegs_VegId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vegs",
                table: "Vegs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CTypes",
                table: "CTypes");

            migrationBuilder.RenameTable(
                name: "Vegs",
                newName: "Veg");

            migrationBuilder.RenameTable(
                name: "CTypes",
                newName: "CType");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Veg",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "CType",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veg",
                table: "Veg",
                column: "VegId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CType",
                table: "CType",
                column: "CTypeId");

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
    }
}
