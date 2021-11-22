using System.ComponentModel.DataAnnotations;

namespace PCConfigurationTool.DataModel
{
    public class VideoCard : IPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Range(1, 1024)]
        public int Memory { get; set; }

        [Required]
        [StringLength(250)]
        public string Chipset { get; set; }
        public decimal Price { get; set; }
    }
}
