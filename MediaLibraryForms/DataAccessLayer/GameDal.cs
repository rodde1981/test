using System;
using DataAccessLayer.Interface;
using DomainLayer;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace DataAccessLayer
{
    public class GameDal : BaseDal<Game>, IGameDal
    {
        
        public  Game Save(Game input)
        {
            throw new NotImplementedException("");
        }


        public  System.Collections.Generic.List<Game> GetAll()
        {
            throw new NotImplementedException();
        }

        public  System.Collections.Generic.List<Game> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public  Game GetById(int i)
        {
            throw new NotImplementedException();
        }


        public override Game GetDataFromReader(System.Data.IDataReader id)
        {
            throw new NotImplementedException();
        }


        public Game Update(Game m)
        {
            throw new NotImplementedException();
        }

        public void Remove(Movie m)
        {
            throw new NotImplementedException();
        }

        public void Remove(Game m)
        {
            throw new NotImplementedException();
        }
    }
}

