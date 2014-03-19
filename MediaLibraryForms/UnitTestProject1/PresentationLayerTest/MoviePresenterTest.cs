using System;
using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.InterFace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PresentationLayer;

namespace UnitTestProject1.PresentationLayerTest
{
    [TestClass]
    public class MoviePresenterTest
    {

        [TestMethod]
        public void SaveAMovie()
        {
            var movieDal = new Mock<IMovieDal>(MockBehavior.Strict);

            Movie movie = new Movie("Gladiator", 15, MediaFormat.BlueRay, new DateTime(1999,12,01));

            movieDal.Setup(x => x.Save(It.IsAny<Movie>())).Returns(movie);

            PresentationLayer.MoviePresenter moviePresenter = new MoviePresenter(movieDal.Object);
            moviePresenter.Save(movie);

            movieDal.Verify(x => x.Save(movie), Times.Once);

        }
        [TestMethod]
        public void SearchMovieByTitle()
        {
            var movieDal = new Mock<IMovieDal>(MockBehavior.Strict);
            string seachCriteria = "Gladiator";
            movieDal.Setup(x => x.GetByTitle(seachCriteria)).Returns((List<Movie>)null);

            MoviePresenter moviePresenter = new MoviePresenter(movieDal.Object);
            moviePresenter.SearchByTitle(seachCriteria);

            movieDal.VerifyAll();
        }


    }
}
