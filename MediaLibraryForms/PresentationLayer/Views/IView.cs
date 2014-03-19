using System;
using System.Collections.Generic;
using DomainLayer;

namespace PresentationLayer.Views
{
    public interface IView
    {
        event EventHandler ShowAllMovies;
        event EventHandler SearchMovie;
        event EventHandler SearchAllGames;
        event EventHandler SearchGame;
        string GetSearchTitle { get; }

        void DisplayMovie(List<Movie> movies);
    }
}
