namespace LandPApi.View
{
    public class ReviewView
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
    }
}
