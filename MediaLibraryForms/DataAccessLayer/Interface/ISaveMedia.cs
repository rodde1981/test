using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainLayer;

namespace DataAccessLayer
{
    public interface ISaveMedia<T> where T:  MediaItem
    {
        T Save(T g);
        T UpdateMovie(T m);
    }

   
}
