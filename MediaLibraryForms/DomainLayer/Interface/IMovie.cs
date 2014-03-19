using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Enums;


namespace DomainLayer.InterFace
{
    public interface IMovie
    {
        int RunningLength { get; set; }
        List<MovieGenre> MovieGenres { get; set; } 
    }
}
