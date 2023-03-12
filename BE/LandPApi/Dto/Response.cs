﻿namespace LandPApi.Dto
{
    public class Response
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
