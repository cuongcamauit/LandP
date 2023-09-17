namespace LandPApi.Models
{
    public class AttributeSpec
    {
        public Guid ProductId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public Product Product { get; set; }
        public Attribute Attribute { get; set; }
    }
}
