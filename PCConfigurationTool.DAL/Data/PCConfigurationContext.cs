using Microsoft.EntityFrameworkCore;

namespace PCConfigurationTool.DataModel
{
    public class PCConfigurationContext : DbContext
    {
        public PCConfigurationContext(DbContextOptions<PCConfigurationContext> options) : base(options)
        {
        }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<RAM> RAM { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CPU>().HasData(
                new CPU() { Id = 1, CoreCount = 6, IntegratedGraphics = null, Name = "AMD Ryzen 5 5600X", PerformanceCoreClock = "3.7 GHz", Price = 294.00m },
                new CPU() { Id = 2, CoreCount = 8, IntegratedGraphics = null, Name = "AMD Ryzen 7 5800X", PerformanceCoreClock = "3.8 GHz", Price = 341.66m },
                new CPU() { Id = 3, CoreCount = 6, IntegratedGraphics = "Radeon Vega 7", Name = "AMD Ryzen 5 5600G", PerformanceCoreClock = "3.9 GHz", Price = 239.00m },
                new CPU() { Id = 4, CoreCount = 10, IntegratedGraphics = "Intel UHD Graphics 630", Name = "Intel Core i9-10900K", PerformanceCoreClock = "3.7 GHz", Price = 458.99m },
                new CPU() { Id = 5, CoreCount = 6, IntegratedGraphics = null, Name = "Intel Core i5-11400F", PerformanceCoreClock = "2.6 GHz", Price = 198.00m },
                new CPU() { Id = 6, CoreCount = 8, IntegratedGraphics = null, Name = "AMD Ryzen 7 1800X", PerformanceCoreClock = "3.6 GHz", Price = 430.56m }
                );

            builder.Entity<Motherboard>().HasData(
                new Motherboard() { Id = 1, MemoryMax = 128, MemorySlots = 4, Name = "Asus TUF GAMING X570-PLUS (WI-FI)", Price = 194.99m },
                new Motherboard() { Id = 2, MemoryMax = 128, MemorySlots = 4, Name = "MSI PRO Z690-A DDR4", Price = 209.99m },
                new Motherboard() { Id = 3, MemoryMax = 256, MemorySlots = 8, Name = "Asus ROG ZENITH II EXTREME ALPHA", Price = 870.99m },
                new Motherboard() { Id = 4, MemoryMax = 64, MemorySlots = 2, Name = "ASRock Fatal1ty B450 Gaming-ITX/ac", Price = 99.99m },
                new Motherboard() { Id = 5, MemoryMax = 2000, MemorySlots = 16, Name = "Supermicro MBD-X10DAX", Price = 564.25m },
                new Motherboard() { Id = 6, MemoryMax = 128, MemorySlots = 4, Name = "Gigabyte B560 AORUS PRO AX", Price = 219.99m },
                new Motherboard() { Id = 7, MemoryMax = 128, MemorySlots = 4, Name = "ASRock Z590M Pro4", Price = 129.99m }
                );

            builder.Entity<RAM>().HasData(
                new RAM() { Id = 1, Memory = 16, Name = "Corsair Vengeance LPX", Price = 67.81m },
                new RAM() { Id = 2, Memory = 32, Name = "G.Skill Ripjaws V Series", Price = 114.97m },
                new RAM() { Id = 3, Memory = 64, Name = "G.Skill Trident Z RGB", Price = 305.99m },
                new RAM() { Id = 4, Memory = 128, Name = "G.Skill Trident Z Royal", Price = 1159.00m },
                new RAM() { Id = 5, Memory = 16, Name = "ADATA XPG Z1", Price = 49.99m },
                new RAM() { Id = 6, Memory = 8, Name = "Corsair Vengeance LPX", Price = 32.99m },
                new RAM() { Id = 7, Memory = 16, Name = "Crucial Ballistix RGB", Price = 74.98m },
                new RAM() { Id = 8, Memory = 256, Name = "Corsair Vengeance RGB Pro", Price = 1309.99m }
                );

            builder.Entity<Storage>().HasData(
                new Storage() { Id = 1, Cache= "256 MB",  Capacity = 2000, Name= "Seagate Barracuda Compute", Price = 46.99m  },
                new Storage() { Id = 2, Cache = "1024 MB", Capacity = 1000, Name = "Samsung 970 Evo Plus", Price = 136.94m },
                new Storage() { Id = 3, Capacity = 15300, Name = "Team QX", Price = 3461.99m },
                new Storage() { Id = 4, Capacity = 8000, Name = "Sabrent Rocket Q", Price = 1299.99m },
                new Storage() { Id = 5, Cache = "512 MB", Capacity = 18000, Name = "Western Digital Gold", Price = 485.99m },
                new Storage() { Id = 6, Capacity = 1000, Name = "Team MP33", Price = 72.98m },
                new Storage() { Id = 7, Cache = "8 MB", Capacity = 320, Name = "Toshiba MQ01ABD032", Price = 14.80m },
                new Storage() { Id = 8, Cache = "2048 MB", Capacity = 2000, Name = "Samsung 870 Evo", Price = 235.48m }
                );

            builder.Entity<VideoCard>().HasData(
                new VideoCard() { Id = 1, Chipset = "GeForce RTX 3060", Memory = 12, Name = "EVGA XC GAMING", Price = 915.99m },
                new VideoCard() { Id = 2, Chipset = "GeForce RTX 3060", Memory = 12, Name = "MSI GAMING X", Price = 949.99m },
                new VideoCard() { Id = 3, Chipset = "GeForce GTX 1660 SUPER", Memory = 6, Name = "Asus TUF GAMING OC", Price = 649.95m },
                new VideoCard() { Id = 4, Chipset = "GeForce RTX 3080 Ti", Memory = 12, Name = "EVGA FTW3 ULTRA GAMING LE iCX3", Price = 2492.98m },
                new VideoCard() { Id = 5, Chipset = "Radeon RX 6600 XT", Memory = 8, Name = "XFX Speedster QICK 308 Black", Price = 821.79m },
                new VideoCard() { Id = 6, Chipset = "Radeon RX 580", Memory = 8, Name = "XFX GTR XXX", Price = 865.99m },
                new VideoCard() { Id = 7, Chipset = "GeForce GT 1030", Memory = 2, Name = "Asus GT1030-2G-CSM", Price = 137.68m },
                new VideoCard() { Id = 8, Chipset = "GeForce RTX 3090", Memory = 24, Name = "Gigabyte AORUS XTREME WATERFORCE", Price = 3490.00m }
                );
        }
    }
}
