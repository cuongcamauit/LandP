﻿namespace LandPApi.View
{
    public class SlugView
    {
        // use to show in url and
        public String? Id { get; set; }
        // use to show title of group products
        public String? Title { get; set; }
        public String? Image { get; set; } = null;
        public bool IsSilder { get; set; } = false;
    }
}
