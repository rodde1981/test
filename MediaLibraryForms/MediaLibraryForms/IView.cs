using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaLibraryForms
{
    public interface IView
    {
        event EventHandler ShowAllMovies;
        event EventHandler SearchMovie;
        event EventHandler SearchAllGames;
        event EventHandler SearchGame;
    }
}
