using System;
using System.Collections.Generic;
using DataAccessLayer.Interface;
using DomainLayer;
using DomainLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PresentationLayer;
using PresentationLayer.Views;

namespace UnitTestProject1.PresentationLayerTest
{
    [TestClass]
    public class BasePresenterTest
    {
        private Mock<IGameDal> _gameDal;
        private Mock<IMovieDal> _movieDal;
        private Mock<IView> _iView;
        private List<Movie> returnMovies = new List<Movie>();
        [TestInitialize]
        public void InitiaLizeTest()
        {
            _gameDal = new Mock<IGameDal>(MockBehavior.Strict);
            _movieDal = new Mock<IMovieDal>(MockBehavior.Strict);
            _iView = new Mock<IView>(MockBehavior.Strict);

            returnMovies.Add(new Movie("Gladiator",15, MediaFormat.BlueRay, new DateTime(1999,01,01)));

            Movie movie = new Movie("Gladiator", 15, MediaFormat.BlueRay, new DateTime(1999, 01, 01));

            // _movieDal.Setup(x => x.GetByTitle()).Returns(movie);
        }

        [TestMethod]
        public void RaiseGetMovie()
        {
            //act
            
            //Arrange
            _movieDal.Setup(x => x.GetByTitle("Gladiator")).Returns(returnMovies);
            _iView.Setup(x => x.GetSearchTitle).Returns("Gladiator");
            _iView.Setup(x => x.DisplayMovie(returnMovies));
            //_iView.Setup(x => x.DisplayMovie(It.IsAny<Movie>()));

            //Action
            BasePresenter basePresenter = new BasePresenter(_iView.Object, _gameDal.Object, _movieDal.Object);
            _iView.Raise(x => x.SearchMovie += null, new EventArgs());
            _iView.VerifyAll();


        }



    }
}
