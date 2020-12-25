using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidtermReview.Business
{
    public class ProjectAssignment
    {
        private int studentNumber;
        private string projectCode;
        private DateTime assignedDate;
        private DateTime submittedDate;

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string ProjectCode { get => projectCode; set => projectCode = value; }
        public DateTime AssignedDate { get => assignedDate; set => assignedDate = value; }
        public DateTime SubmittedDate { get => submittedDate; set => submittedDate = value; }
    }
}