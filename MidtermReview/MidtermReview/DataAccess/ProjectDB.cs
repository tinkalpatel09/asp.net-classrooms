using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermReview.Business;
using System.Data.SqlClient;

namespace MidtermReview.DataAccess
{
    public static  class ProjectDB
    {
        public static List<Project> ListRecord()
        {
            List<Project> listRecord = new List<Project>();
            //Your code here
            return listRecord;
        }

        public static Project SearchRecord(string code)
        {
            Project aProject = new Project();
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from Projects where ProjectCode = @ProjectCode";
                cmd.Parameters.AddWithValue("@ProjectCode", code);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    aProject.ProjectCode =  reader["ProjectCode"].ToString();
                    aProject.ProjectTitle = reader["ProjectTitle"].ToString();
                    aProject.DueDate = Convert.ToDateTime(reader["DueDate"]);
                }
                else
                {
                    aProject = null;
                }
            }
            return aProject;
        }
    }
}