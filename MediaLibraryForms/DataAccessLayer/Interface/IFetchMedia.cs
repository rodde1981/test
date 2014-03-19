using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataAccessLayer.Interface
{
    public interface IFetchMedia<T> where T : MediaItem
    {
        List<T> GetAll();
        List<T> GetByTitle(string title);
        T GetById(int i);

    }
}
