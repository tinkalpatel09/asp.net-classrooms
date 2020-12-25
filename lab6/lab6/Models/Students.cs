using System;
using System.Collections.Generic;

namespace lab6.Models
{
    public partial class Students
    {
        public Students()
        {
            ProjectAssignments = new HashSet<ProjectAssignments>();
        }

        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<ProjectAssignments> ProjectAssignments { get; set; }
    }
}
