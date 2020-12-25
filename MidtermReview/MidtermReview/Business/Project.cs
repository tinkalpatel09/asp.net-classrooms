using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermReview.DataAccess;

namespace MidtermReview.Business
{
    public class Project
    {
        private string projectCode;
        private string projectTitle;
        private DateTime dueDate;

        public string ProjectCode { get => projectCode; set => projectCode = value; }
        public string ProjectTitle { get => projectTitle; set => projectTitle = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }

        public Project SearchProject(string projectCode)
        {
            return ProjectDB.SearchRecord(projectCode);
        }
    }
}