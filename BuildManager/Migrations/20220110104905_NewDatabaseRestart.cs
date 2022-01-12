using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildManager.Migrations
{
    public partial class NewDatabaseRestart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataMaterial_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "dataPerson",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "JobPerson_id",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Material_id",
                table: "DataMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "DataMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobPerson_id",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Material_id",
                table: "DataMaterials");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "DataMaterials");

            migrationBuilder.AddColumn<int>(
                name: "dataMaterial_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "dataPerson",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
