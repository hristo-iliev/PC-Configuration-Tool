using System.ComponentModel.DataAnnotations;

namespace PCConfigurationTool.DataModel
{
    public class CPU : IPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Range(1, 256)]
        public int CoreCount { get; set; }
        public string PerformanceCoreClock { get; set; }
        public string IntegratedGraphics { get; set; }
        public decimal Price { get; set; }
    }
}
