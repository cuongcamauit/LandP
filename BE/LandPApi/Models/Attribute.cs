namespace LandPApi.Models
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<AttributeGroup> AttributeGroups { get; set; }
        public ICollection<AttributeSpec> AttributeSpecs { get; set; }
    }
}
