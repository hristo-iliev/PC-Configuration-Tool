using System.ComponentModel.DataAnnotations;

namespace PCConfigurationTool.DataModel
{
    public class Storage : IPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Range(20, 100000)]
        public int Capacity { get; set; }
        public string Cache { get; set; }
        public decimal Price { get; set; }
    }
}
