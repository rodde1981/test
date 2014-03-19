using DomainLayer;

namespace DataAccessLayer.Interface
{
    public interface IMovieDal: IFetchMedia<Movie>, ISaveMedia<Movie>, IRemoveDal<Movie>
    {
        
    }
}
