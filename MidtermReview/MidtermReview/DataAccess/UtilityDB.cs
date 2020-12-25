using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace MidtermReview.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.
                ConnectionStrings["StudentProjectsDBConnection"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}