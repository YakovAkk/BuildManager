using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildManager.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataMaterials_Materials_materialid",
                table: "DataMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_DataMaterials_Users_userid",
                table: "DataMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Categories_CategoryId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_JobPeople_personid",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Users_userid",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CategoryId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_DataMaterials_materialid",
                table: "DataMaterials");

            migrationBuilder.DropIndex(
                name: "IX_DataMaterials_userid",
                table: "DataMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_personid",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_userid",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "materialid",
                table: "DataMaterials");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "DataMaterials");

            migrationBuilder.DropColumn(
                name: "personid",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "DataPeople");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataPeople",
                table: "DataPeople",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DataPeople",
                table: "DataPeople");

            migrationBuilder.RenameTable(
                name: "DataPeople",
                newName: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "materialid",
                table: "DataMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "DataMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "personid",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CategoryId",
                table: "Materials",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataMaterials_materialid",
                table: "DataMaterials",
                column: "materialid");

            migrationBuilder.CreateIndex(
                name: "IX_DataMaterials_userid",
                table: "DataMaterials",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_personid",
                table: "Persons",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_userid",
                table: "Persons",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_DataMaterials_Materials_materialid",
                table: "DataMaterials",
                column: "materialid",
                principalTable: "Materials",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataMaterials_Users_userid",
                table: "DataMaterials",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Categories_CategoryId",
                table: "Materials",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_JobPeople_personid",
                table: "Persons",
                column: "personid",
                principalTable: "JobPeople",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Users_userid",
                table: "Persons",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
