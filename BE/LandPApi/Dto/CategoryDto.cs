﻿namespace LandPApi.Dto
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
