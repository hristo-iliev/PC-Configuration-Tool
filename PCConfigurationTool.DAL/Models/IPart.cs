namespace PCConfigurationTool.DataModel
{
    public interface IPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
