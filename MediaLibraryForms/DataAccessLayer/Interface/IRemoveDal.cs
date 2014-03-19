using DomainLayer;

namespace DataAccessLayer.Interface
{
    public interface IRemoveDal<T> where T: MediaItem
    {
        void Remove(Movie m);
    }
}