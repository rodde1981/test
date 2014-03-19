using System;
using DomainLayer.Enums;

namespace DomainLayer
{
    public abstract class MediaItem
    {
        public string Title { get; set; }
        public int AgeLimit { get; set; }
        public MediaFormat ProductMediaFormat { get; set; }
        public int Id { get; set; }
        public DateTime Year { get; set; }

    }
}