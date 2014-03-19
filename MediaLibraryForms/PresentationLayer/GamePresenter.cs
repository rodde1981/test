using System.Collections.Generic;
using System.Diagnostics;
using DataAccessLayer;
using DomainLayer;

namespace PresentationLayer
{
    public class GamePresenter
    {
        private readonly ISaveMedia<Game> _saveMediaDal;
        public GamePresenter(ISaveMedia<Game> mediaDal)
        {
            this._saveMediaDal = mediaDal;
        }
        public void Save(Game g)
        {
            _saveMediaDal.Save(g);
        }

        
    }
}
