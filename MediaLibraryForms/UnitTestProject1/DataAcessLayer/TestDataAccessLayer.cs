using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DomainLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainLayer;
using DataAccessLayer.Interface;

namespace UnitTestProject1.DataAcessLayer
{
    [TestClass]
    public class TestDataAccessLayer
    {
        private IMovieDal _movieDal;
        private IGameDal _gameDal;
        private Movie _movie;
        private Game _game;
        [TestInitialize]
        public void Setup()
        {
            _movieDal = new MovieDal();
            _gameDal = new GameDal();
            _movie = new Movie("TestRulle1", 15, MediaFormat.BlueRay, new DateTime(2001,01,01));
            _game = new Game("Halo", 15, MediaFormat.Dvd, GameSystemEnum.Xbox, new DateTime(2001, 01, 01));
        }

        [TestMethod, Description("Test Database Movies CRUD Ops")]
        public void TestMovies()
        {
            var insertedMovie = InsertMovieIntoDatabase(_movie);
            SearchMovieDatabase(insertedMovie.Title);
            RemoveMovieFromDatabase(insertedMovie);


        }

        [TestMethod, Description("Test Database Games CRUD operations")]
        public void TestGames()
        {
            var insertedGame = InsertGameIntoDatabase(_game);
            SearchGameDatabase(_game.Title);
            RemoveGameFromDatabase(_game);
        }


        public Game InsertGameIntoDatabase(Game m)
        {
            Game savedMovie = _gameDal.Save(m);
            Assert.IsNotNull(savedMovie.Id);
            Assert.AreNotEqual(0, savedMovie.Id);
            return savedMovie;
        }

        public void SearchGameDatabase(string searchTitle)
        {
            var games = _gameDal.GetByTitle(searchTitle);
            Assert.IsNotNull(games);
            Assert.AreNotEqual(0, games.Count);
            Assert.IsTrue(games[0].Title.Contains(searchTitle));
        }

        public void RemoveGameFromDatabase(Game m)
        {
            _gameDal.Remove(m);
            var getByid = _gameDal.GetById(m.Id);
            Assert.IsNull(getByid);

        }

        public Game UpdateGameFromDatabase(Game m)
        {
            Game game = _gameDal.Update(m);
            Assert.IsNotNull(game);
            return game;
        }

        public Movie InsertMovieIntoDatabase(Movie m)
        {
            Movie savedMovie = _movieDal.Save(m);
            Assert.IsNotNull(savedMovie.Id);
            Assert.AreNotEqual(0, savedMovie.Id);
            return savedMovie;
        }

        public void SearchMovieDatabase(string searchTitle)
        {
            var movies = _movieDal.GetByTitle(searchTitle);
            Assert.IsNotNull(movies);
            Assert.AreNotEqual(0, movies.Count);
            Assert.IsTrue(movies[0].Title.Contains(searchTitle));
        }

        public void RemoveMovieFromDatabase(Movie m)
        {
            _movieDal.Remove(m);
            var getByid = _movieDal.GetById(m.Id);
            Assert.IsNull(getByid);

        }

        public Movie UpdateMovieFromDatabase(Movie m)
        {
            Movie updatedMovie = _movieDal.Update(m);
            Assert.IsNotNull(updatedMovie);
            return updatedMovie;
        }
    }
}
