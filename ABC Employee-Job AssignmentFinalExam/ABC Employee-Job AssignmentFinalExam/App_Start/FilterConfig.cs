﻿using System.Web;
using System.Web.Mvc;

namespace ABC_Employee_Job_AssignmentFinalExam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
