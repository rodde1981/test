using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainLayer;

namespace PresentationLayer
{
    interface ISaveMovieMedia
    {
       Movie SaveMovie(Movie m);
    }
}
