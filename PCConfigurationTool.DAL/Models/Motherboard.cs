using System.ComponentModel.DataAnnotations;

namespace PCConfigurationTool.DataModel
{
    public class Motherboard : IPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        public int MemoryMax { get; set; }
        public int MemorySlots { get; set; }
        public decimal Price { get; set; }
    }
}
