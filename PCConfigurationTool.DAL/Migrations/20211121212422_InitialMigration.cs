using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConfigurationTool.DataModel.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreCount = table.Column<int>(type: "int", nullable: false),
                    PerformanceCoreClock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntegratedGraphics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.CPUId);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemoryMax = table.Column<int>(type: "int", nullable: false),
                    MemorySlots = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    RAMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.RAMId);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Cache = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    VideoCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.VideoCardId);
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "CPUId", "CoreCount", "IntegratedGraphics", "Name", "PerformanceCoreClock", "Price" },
                values: new object[,]
                {
                    { 1, 6, null, "AMD Ryzen 5 5600X", "3.7 GHz", 294.00m },
                    { 2, 8, null, "AMD Ryzen 7 5800X", "3.8 GHz", 341.66m },
                    { 3, 6, "Radeon Vega 7", "AMD Ryzen 5 5600G", "3.9 GHz", 239.00m },
                    { 4, 10, "Intel UHD Graphics 630", "Intel Core i9-10900K", "3.7 GHz", 458.99m },
                    { 5, 6, null, "Intel Core i5-11400F", "2.6 GHz", 198.00m },
                    { 6, 8, null, "AMD Ryzen 7 1800X", "3.6 GHz", 430.56m }
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "MotherboardId", "MemoryMax", "MemorySlots", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 128, 4, "Asus TUF GAMING X570-PLUS (WI-FI)", 194.99m },
                    { 2, 128, 4, "MSI PRO Z690-A DDR4", 209.99m },
                    { 3, 256, 8, "Asus ROG ZENITH II EXTREME ALPHA", 870.99m },
                    { 4, 64, 2, "ASRock Fatal1ty B450 Gaming-ITX/ac", 99.99m },
                    { 5, 2000, 16, "Supermicro MBD-X10DAX", 564.25m },
                    { 6, 128, 4, "Gigabyte B560 AORUS PRO AX", 219.99m },
                    { 7, 128, 4, "ASRock Z590M Pro4", 129.99m }
                });

            migrationBuilder.InsertData(
                table: "RAM",
                columns: new[] { "RAMId", "Memory", "Name", "Price" },
                values: new object[,]
                {
                    { 8, 256, "Corsair Vengeance RGB Pro", 1309.99m },
                    { 7, 16, "Crucial Ballistix RGB", 74.98m },
                    { 5, 16, "ADATA XPG Z1", 49.99m },
                    { 6, 8, "Corsair Vengeance LPX", 32.99m },
                    { 3, 64, "G.Skill Trident Z RGB", 305.99m },
                    { 2, 32, "G.Skill Ripjaws V Series", 114.97m },
                    { 1, 16, "Corsair Vengeance LPX", 67.81m },
                    { 4, 128, "G.Skill Trident Z Royal", 1159.00m }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "StorageId", "Cache", "Capacity", "Name", "Price" },
                values: new object[,]
                {
                    { 8, "2048 MB", 2000, "Samsung 870 Evo", 235.48m },
                    { 7, "8 MB", 320, "Toshiba MQ01ABD032", 14.80m },
                    { 5, "512 MB", 18000, "Western Digital Gold", 485.99m },
                    { 6, null, 1000, "Team MP33", 72.98m },
                    { 3, null, 15300, "Team QX", 3461.99m },
                    { 2, "1024 MB", 1000, "Samsung 970 Evo Plus", 136.94m },
                    { 1, "256 MB", 2000, "Seagate Barracuda Compute", 46.99m },
                    { 4, null, 8000, "Sabrent Rocket Q", 1299.99m }
                });

            migrationBuilder.InsertData(
                table: "VideoCards",
                columns: new[] { "VideoCardId", "Chipset", "Memory", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "GeForce GT 1030", 2, "Asus GT1030-2G-CSM", 137.68m },
                    { 1, "GeForce RTX 3060", 12, "EVGA XC GAMING", 915.99m },
                    { 2, "GeForce RTX 3060", 12, "MSI GAMING X", 949.99m },
                    { 3, "GeForce GTX 1660 SUPER", 6, "Asus TUF GAMING OC", 649.95m },
                    { 4, "GeForce RTX 3080 Ti", 12, "EVGA FTW3 ULTRA GAMING LE iCX3", 2492.98m },
                    { 5, "Radeon RX 6600 XT", 8, "XFX Speedster QICK 308 Black", 821.79m },
                    { 6, "Radeon RX 580", 8, "XFX GTR XXX", 865.99m },
                    { 8, "GeForce RTX 3090", 24, "Gigabyte AORUS XTREME WATERFORCE", 3490.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "VideoCards");
        }
    }
}
