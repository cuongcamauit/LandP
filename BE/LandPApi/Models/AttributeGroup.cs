namespace LandPApi.Models
{
    public class AttributeGroup
    {
        public int AttributeId { get; set; }
        public Guid CategoryId { get; set; }
        public Attribute Attribute { get; set; }
        public Category Category { get; set; }
    }
}
