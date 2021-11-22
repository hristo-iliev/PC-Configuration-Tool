using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConfigurationTool.DataModel.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoCardId",
                table: "VideoCards",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StorageId",
                table: "Storages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RAMId",
                table: "RAM",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MotherboardId",
                table: "Motherboards",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CPUId",
                table: "CPUs",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VideoCards",
                newName: "VideoCardId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Storages",
                newName: "StorageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RAM",
                newName: "RAMId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Motherboards",
                newName: "MotherboardId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CPUs",
                newName: "CPUId");
        }
    }
}
