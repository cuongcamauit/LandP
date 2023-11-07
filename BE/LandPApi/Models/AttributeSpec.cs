namespace LandPApi.Models
{
    public class AttributeSpec
    {
        public Guid ProductId { get; set; }
        public int AttributeId { get; set; }
        public string? Value { get; set; }
        public int? OptionID { get; set; } = null;
        public Product? Product { get; set; }
        public Attribute? Attribute { get; set; }
        public AttributeOption? Option { get; set; } = null;
    }
}
