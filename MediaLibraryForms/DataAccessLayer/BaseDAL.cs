using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DomainLayer;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace DataAccessLayer
{
    public abstract class BaseDal<T> : MediaItem
    {
        protected Database database;
        protected BaseDal()
        {
            database = new SqlDatabase(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        }

        public abstract T GetDataFromReader(IDataReader id);

    }
}
