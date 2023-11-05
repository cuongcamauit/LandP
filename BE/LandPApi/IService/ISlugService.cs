﻿using LandPApi.Dto;
using LandPApi.View;

namespace LandPApi.IService
{
    public interface ISlugService
    {
        List<SlugDto> GetAll();
        SlugDto GetById(String id);
        void Add(SlugView slug);
        void UpdateCache(string cacheName);
        List<SlugDto> GetSliders();
    }
}