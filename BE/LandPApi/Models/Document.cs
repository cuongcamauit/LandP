namespace LandPApi.Models
{
    public class Document
    {
        public string? Id { get; set; }    
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
