using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermReview.Business;
using System.Data.SqlClient;

namespace MidtermReview.DataAccess
{
    public static class StudentDB
    {
        public static List<Student> ListRecord()
        {
            List<Student> listRecord = new List<Student>();

            return listRecord;
        }

        public static Student SearchRecord(int id)
        {
            Student aStudent = new Student();
            using (SqlConnection connDB = UtilityDB.ConnectDB())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connDB;
                cmd.CommandText = "SELECT * FROM Students " +
                                  " WHERE StudentNumber = @StudentNumber" ;
                cmd.Parameters.AddWithValue("@StudentNumber", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    aStudent.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    aStudent.Firstname = reader["FirstName"].ToString();
                    aStudent.Lastname = reader["LastName"].ToString();
                    aStudent.Email = reader["Email"].ToString();
                }
                else
                {
                    aStudent = null;
                }

            }

            return aStudent;
        }
    }
}