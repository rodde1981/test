using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using MediaLibraryForms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1.PresentationLayerTest
{
    [TestClass]
    public class BasePresenterTest
    {
        private Mock<IGameDal> _gameDalRepository;
        private Mock<IMovieDal> _movieDal;
        private Mock<IView> _iView;
        [TestInitialize]
        public void InitiaLizeTest()
        {
            _gameDalRepository = new Mock<IGameDal>(MockBehavior.Strict);
            _movieDal = new Mock<IMovieDal>(MockBehavior.Strict);
            _iView = new Mock<IView>(MockBehavior.Strict);
        }
        
        [TestMethod]
        public void 



    }
}
