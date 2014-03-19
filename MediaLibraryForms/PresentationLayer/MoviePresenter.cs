using DomainLayer;

namespace PresentationLayer
{
    public class MoviePresenter
    {
        public void SaveMovie(Movie movie2Save, ISaveMovieMedia movieDal)
        {
            movieDal.Save(movie2Save);
        }
    }
}