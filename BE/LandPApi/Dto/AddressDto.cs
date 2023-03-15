﻿namespace LandPApi.Dto
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? Detail { get; set; }
        public string? CustomerId { get; set; }
    }
}
