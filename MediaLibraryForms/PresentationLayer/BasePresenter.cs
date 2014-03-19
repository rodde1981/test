using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using PresentationLayer.Views;

namespace PresentationLayer
{
    public class BasePresenter
    {
        private IGameDal _gameDAL ;
        private IMovieDal _movieDAL;
        private IView _theView;

        public BasePresenter(IView theView, IGameDal gameDAL, IMovieDal movieDAL)
        {
            _theView = theView;
            _gameDAL = gameDAL;
            _movieDAL = movieDAL;

            _theView.SearchMovie+=_onView_SearchMovie;

        }

        private void _onView_SearchMovie(object sender, EventArgs e)
        {
            var result =  _movieDAL.GetByTitle(_theView.GetSearchTitle);
            _theView.DisplayMovie(result);

        }
    }
}
