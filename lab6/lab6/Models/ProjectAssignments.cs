using System;
using System.Collections.Generic;

namespace lab6.Models
{
    public partial class ProjectAssignments
    {
        public int StudentNumber { get; set; }
        public string ProjectCode { get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }

        public virtual Projects ProjectCodeNavigation { get; set; }
        public virtual Students StudentNumberNavigation { get; set; }
    }
}
