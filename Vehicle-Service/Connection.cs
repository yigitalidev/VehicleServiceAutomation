using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Connection Sql Connection

namespace Vehicle_Service
{
    class Connection
    {
        public DbVehicleServiceEntities2 EntityFramework()
        {
            DbVehicleServiceEntities2 db = new DbVehicleServiceEntities2();
            return db;
        }

        public static SqlConnection SqlServer()
        {
            SqlConnection connectionSql = new SqlConnection("Data Source=DESKTOP-N4P9SDV\\SQLEXPRESS;Initial Catalog=DbVehicleService;Integrated Security=True");
            connectionSql.Open();
            return connectionSql;
        }
    }
}
