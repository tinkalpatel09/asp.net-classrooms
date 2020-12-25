using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StroedProcedure.Business;
using StroedProcedure.DataAccess;

namespace StroedProcedure.Business
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }

        public int Duration { get; set; }

        public void SaveCourse(Course c) {
            CourseDB.SaveRecord(c);
        }
    }
}