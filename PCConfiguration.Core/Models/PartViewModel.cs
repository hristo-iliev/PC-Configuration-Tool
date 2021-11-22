using System;

namespace PCConfiguration.Core.Models
{
    public class PartViewModel : IEquatable<PartViewModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public bool IsSelected { get; set; }

        public bool Equals(PartViewModel other)
        {
            return other.Id.Equals(this.Id) && other.Name.Equals(this.Name);
        }
    }
}
