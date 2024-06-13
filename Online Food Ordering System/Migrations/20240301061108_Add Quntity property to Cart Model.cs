using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Food_Ordering_System.Migrations
{
    /// <inheritdoc />
    public partial class AddQuntitypropertytoCartModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quntity",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quntity",
                table: "Carts");
        }
    }
}
