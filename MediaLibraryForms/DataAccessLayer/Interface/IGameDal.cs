using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace DataAccessLayer.Interface
{
    public interface IGameDal: IFetchMedia<Game>,ISaveMedia<Game>, IRemoveDal<Game>
    {
    }

}
