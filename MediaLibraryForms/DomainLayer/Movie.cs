using System;
using System.Collections.Generic;
using DomainLayer.Enums;
using DomainLayer.InterFace;

namespace DomainLayer
{
    public class Movie : MediaItem, IMovie
    {
        public Movie(string title, int ageLimit, MediaFormat format, DateTime year)
        {
            this.Title = title;
            this.AgeLimit = ageLimit;
            this.ProductMediaFormat = format;
            this.Year = year;
        }

        public int RunningLength
        { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }

    }

    
}