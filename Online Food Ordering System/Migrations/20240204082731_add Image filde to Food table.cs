using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Food_Ordering_System.Migrations
{
    /// <inheritdoc />
    public partial class addImagefildetoFoodtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Foods");
        }
    }
}
