﻿namespace HHBW
{
    public class News
    {
        public string imageurl = SiteInfo.PlaceHolderImage;
        public string Headline   = "Updates!";
        public string Description = "This is just and update news article.";
        public DateTime DateTime = DateTime.UtcNow;
        public DateTime DateTimeOffset = default;
    }
}