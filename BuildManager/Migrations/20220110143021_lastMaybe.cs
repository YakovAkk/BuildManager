using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildManager.Migrations
{
    public partial class lastMaybe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "DataMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "DataMaterials");
        }
    }
}
