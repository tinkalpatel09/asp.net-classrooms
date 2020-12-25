using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StroedProcedure.Business;
using StroedProcedure.DataAccess;
using System.Data.SqlClient;

namespace StroedProcedure.DataAccess
{
    public class CourseDB
    {
        public static void SaveRecord(Course course) {
            SqlConnection connectDB = UtilityDB.ConnDB();
            SqlCommand cmd = new SqlCommand("SaveCourse",connectDB);
            cmd.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            cmd.Parameters.AddWithValue("@CourseTitle", course.CourseTitle);
            cmd.Parameters.AddWithValue("@Duration", course.Duration);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            connectDB.Close();


        }
    }
}