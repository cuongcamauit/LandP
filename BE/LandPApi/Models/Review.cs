﻿using System.ComponentModel.DataAnnotations;

namespace LandPApi.Models
{
    public class Review
    {
        [Range(0, 5)]
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public Guid ProductId { get; set; }
        public string? CustomerId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
    }
}
