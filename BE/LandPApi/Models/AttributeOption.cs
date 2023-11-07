namespace LandPApi.Models
{
    public class AttributeOption
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
        public String Value { get; set; }
        public ICollection<AttributeSpec>? AttributeSpecs { get; set; }
    }
}
