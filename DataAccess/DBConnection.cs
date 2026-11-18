using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PlacementDashboard.DataAccess
{
    public class DBConnection
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["PlacementDBConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
