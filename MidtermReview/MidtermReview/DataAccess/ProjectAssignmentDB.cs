using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermReview.Business;

namespace MidtermReview.DataAccess
{
    public static class ProjectAssignmentDB
    {
        public static void Assign (ProjectAssignment prjAssign)
        {


        }
        /// <summary>
        /// This method returns the list of projects assigned to a student
        /// given StudentNumber; eg, 1234567
        /// </summary>
        /// <param name="stNumber"></param>
        /// <returns></returns>
        public static List<Project> ListProjectRecord (int stNumber)
        {
            List<Project> listP = new List<Project>();

            return listP;

        }

        /// <summary>
        /// This method returns the list of students assigned to a project
        /// given project code ; e.g PRJ101
        /// </summary>
        /// <param name="prjCode"></param>
        /// <returns></returns>
        public static List<Student> ListStudentRecord(string prjCode)
        {
            List<Student> listS = new List<Student>();

            return listS;

        }
    }
}