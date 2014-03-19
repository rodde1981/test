using System;
using DataAccessLayer.Interface;

namespace PresentationLayer
{
    [TestClass]
    public class BasePresenterTest
    {
        private Mock<IGameDal> _gameDal;
        private Mock<IMovieDal> _movieDal;
        private Mock<IView> _iView;
        [TestInitialize]
        public void InitiaLizeTest()
        {
            _gameDal = new Mock<IGameDal>(MockBehavior.Strict);
            _movieDal = new Mock<IMovieDal>(MockBehavior.Strict);
            _iView = new Mock<IView>(MockBehavior.Strict);
        }
        
        [TestMethod]
        public void RaiseGetAllMovies()
        {
            //act
            
            //Arrange
            _iView.Raise(x=>x.SearchMovie+=null, new EventArgs());

            //Action
            BasePresenter basePresenter = new BasePresenter(_iView.Object, _movieDal.Object, _gameDal.Object);



        }



    }
}
