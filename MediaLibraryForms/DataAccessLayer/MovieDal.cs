using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DataAccessLayer.Interface;
using DomainLayer;
using DomainLayer.Enums;

namespace DataAccessLayer
{
    public class MovieDal : BaseDal<Movie>, IMovieDal
    {

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetByTitle(string title)
        {
            List<Movie> movies = new List<Movie>();
            using (DbCommand dbC = database.GetStoredProcCommand("GetMovieByTitle", title))
            {
                var reader = database.ExecuteReader(dbC);
                while ((reader.Read()))
                {
                    movies.Add(GetDataFromReader(reader));
                }

            }
            return movies;
        }

        public Movie GetById(int i)
        {
            Movie movie = null;
            using (DbCommand dbC = database.GetStoredProcCommand("GetMovieById"))
            {
                database.AddInParameter(dbC,"@Id", DbType.Int32, i);
                var reader = database.ExecuteReader(dbC);
                while ((reader.Read()))
                {
                    movie = (GetDataFromReader(reader));
                }

            }
            return movie;
        }

        public override Movie GetDataFromReader(System.Data.IDataReader id)
        {
            return new Movie(id["Title"] as string, (int)id["AgeLimit"], MediaFormat.BlueRay, (DateTime)id["Year"] );
        }

        public Movie Save(Movie g)
        {
            
            using (DbCommand dbC = database.GetStoredProcCommand("SaveMovie"))
            {
                database.AddInParameter(dbC, "@Title", DbType.AnsiString, g.Title);
                database.AddInParameter(dbC,"@Year", DbType.Date, g.Year);
                database.AddInParameter(dbC,"@AgeLimit", DbType.Int32, g.AgeLimit);

               g.Id =(int)(decimal)database.ExecuteScalar(dbC);
               
            }
            return g;
        }

        public void Remove(Movie m)
        {
            using (DbCommand dbC = database.GetStoredProcCommand("DeleteMovie"))
            {
                database.AddInParameter(dbC, "@Id", DbType.Int32, m.Id);
                database.ExecuteNonQuery(dbC);
            }
        }


        public Movie Update(Movie m)
        {
            throw new NotImplementedException();
        }
    }
}