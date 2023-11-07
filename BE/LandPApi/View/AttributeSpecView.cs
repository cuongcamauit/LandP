namespace LandPApi.View
{
    public class AttributeSpecView
    {
        public Guid ProductId { get; set; }
        public int AttributeId { get; set; }
        public string? Value { get; set; }
        public int? OptionID { get; set; } = null;
    }
}
