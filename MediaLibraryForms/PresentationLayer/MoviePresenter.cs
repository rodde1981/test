using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DomainLayer;

namespace PresentationLayer
{
   public class MoviePresenter
    {

       private readonly IMovieDal _movieDal;
       
       public MoviePresenter(IMovieDal mediaDal)
        {
            this._movieDal = mediaDal;
        }
        public void Save(Movie m)
        {
            _movieDal.Save(m);
        }

        public List<Movie> SearchByTitle(string seachCriteria)
        {
            return _movieDal.GetByTitle(seachCriteria);
        }
    }
}
