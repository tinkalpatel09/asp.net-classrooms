using System;
using System.Collections.Generic;

namespace lab6.Models
{
    public partial class Projects
    {
        public Projects()
        {
            ProjectAssignments = new HashSet<ProjectAssignments>();
        }

        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime DueDate { get; set; }

        public virtual ICollection<ProjectAssignments> ProjectAssignments { get; set; }
    }
}
