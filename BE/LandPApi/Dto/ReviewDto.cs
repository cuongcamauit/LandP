﻿using LandPApi.Models;

namespace LandPApi.Dto
{
    public class ReviewDto
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public string? Name { get; set; }
        public Guid ProductId { get; set; }
        public DateTime Date { get; set; }

    }
}
