using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DataAccessLayer.Interface;
using DomainLayer;
using DomainLayer.Enums;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace DataAccessLayer
{
    public class GameDal : BaseDal<Game>, IGameDal
    {

        public Game Save(Game input)
        {
            using (DbCommand dbC = database.GetStoredProcCommand("SaveGame"))
            {
                database.AddInParameter(dbC, "@Title", DbType.AnsiString, input.Title);
                database.AddInParameter(dbC, "@Year", DbType.Date, input.Year);
                database.AddInParameter(dbC, "@AgeLimit", DbType.Int32, input.AgeLimit);
               
                input.Id = (int)(decimal)database.ExecuteScalar(dbC);

            }
            return input;
        }


        public System.Collections.Generic.List<Game> GetAll()
        {
           throw new NotImplementedException();
        }

        public System.Collections.Generic.List<Game> GetByTitle(string title)
        {
            var games = new List<Game>();
            using (DbCommand dbC = database.GetStoredProcCommand("GetGameByTitle", title))
            {
                var reader = database.ExecuteReader(dbC);
                while ((reader.Read()))
                {
                    games.Add(GetDataFromReader(reader));
                }

            }
            return games;
        }

        public Game GetById(int i)
        {
            Game game = null;
            using (DbCommand dbC = database.GetStoredProcCommand("GetGameById"))
            {
                database.AddInParameter(dbC, "@Id", DbType.Int32, i);
                var reader = database.ExecuteReader(dbC);
                while ((reader.Read()))
                {
                    game = (GetDataFromReader(reader));
                }

            }
            return game;
        }


        protected override Game GetDataFromReader(System.Data.IDataReader id)
        {
            return new Game(id["title"] as string, (int)id["AgeLimit"], MediaFormat.BlueRay, GameSystemEnum.Xbox, (DateTime)id["Year"] );
        }


        public Game Update(Game m)
        {
            throw new NotImplementedException();
        }

        public void Remove(Game m)
        {
            using (DbCommand dbC = database.GetStoredProcCommand("DeleteGame"))
            {
                database.AddInParameter(dbC, "@Id", DbType.Int32, m.Id);
                database.ExecuteNonQuery(dbC);
            }
        }
    }
}

