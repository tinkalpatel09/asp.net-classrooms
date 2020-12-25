using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace StroedProcedure.DataAccess
{
    public class UtilityDB
    {
        public static SqlConnection ConnDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectCourseDB"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}