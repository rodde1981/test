using System;
using DomainLayer.Enums;
using DomainLayer.Interface;

namespace DomainLayer
{
    public class Game : MediaItem, IGame
    {
        public Game(string title, int ageLimit, MediaFormat format, GameSystemEnum gameSystem, DateTime date)
        {
            this.Title = title;
            this.AgeLimit = ageLimit;
            this.ProductMediaFormat = format;
            this.System = gameSystem;
            this.Year = date;
        }
        public GameSystemEnum System { get; set; }
    }
}