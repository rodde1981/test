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
        [TestInitialize]
        public void Setup()
        {
            _movieDal = new MovieDal();
            _gameDal = new GameDal();
            _movie = new Movie("TestRulle1", 15, MediaFormat.BlueRay, new DateTime(2001,01,01));
        }

        [TestMethod, Description("Test Database Movies CRUD Ops")]
        public void TestMovies()
        {
            var insertedMovie = InsertMovieIntoDatabase(_movie);
            SearchMovieDatabase(insertedMovie.Title);
            RemoveMovieFromDatabase(insertedMovie);


        }

        [TestMethod, Description("Test Database Games")]
        public void TestGames()
        {


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
            Movie updatedMovie = _movieDal.UpdateMovie(m);
            Assert.IsNotNull(updatedMovie);
            return updatedMovie;
        }
    }
}
