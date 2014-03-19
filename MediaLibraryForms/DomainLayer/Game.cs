using DomainLayer.Enums;
using DomainLayer.Interface;

namespace DomainLayer
{
    public class Game : MediaItem, IGame
    {
        public Game(string title, int ageLimit, MediaFormat format, GameSystemEnum gameSystem)
        {
            this.Title = title;
            this.AgeLimit = ageLimit;
            this.ProductMediaFormat = format;
            this.System = gameSystem;
        }
        public GameSystemEnum System { get; set; }
    }
}