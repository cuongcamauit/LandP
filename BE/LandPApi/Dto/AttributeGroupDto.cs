namespace LandPApi.Dto
{
    public class AttributeGroupDto
    {
        public int AttributeId { get; set; }
        public Guid CategoryId { get; set; }
        public AttributeDto Attribute { get; set; }
        public CategoryDto Category { get; set; }
    }
}
