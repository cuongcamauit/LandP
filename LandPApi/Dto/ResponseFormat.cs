namespace LandPApi.Dto
{
    public class ResponseFormat
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public object? Data { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Message { get; set; }

    }
}
