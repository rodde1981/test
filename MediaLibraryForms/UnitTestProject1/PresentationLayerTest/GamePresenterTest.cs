using DataAccessLayer;
using DataAccessLayer.Interface;
using DomainLayer;
using DomainLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using PresentationLayer;

namespace UnitTestProject1.PresentationLayerTest
{
    [TestClass]
    public class GamePresenterTest
    {
        [TestMethod]
        public void SaveAGame()
        {
            List<MediaItem> medias2Save;
            var saveMedia = new Mock<IGameDal>(MockBehavior.Strict);
            Game game = new Game("Halo", 15, MediaFormat.BlueRay, GameSystemEnum.Xbox, new DateTime(2003,01,01));

            saveMedia.Setup(x => x.Save(It.IsAny<Game>())).Returns(game);

            PresentationLayer.GamePresenter gamePresenter = new GamePresenter(saveMedia.Object);
            gamePresenter.Save(game);

            saveMedia.Verify(x => x.Save(game), Times.Once);
        }
    }
}
