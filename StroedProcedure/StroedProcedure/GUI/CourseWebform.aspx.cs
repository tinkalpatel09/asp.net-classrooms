using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using StroedProcedure.DataAccess;
using StroedProcedure.Business;

namespace StroedProcedure.GUI
{
    public partial class CourseWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(UtilityDB.connect)
            Course aCourse = new Course();
            aCourse.CourseCode = txtboxCourseCode.Text.Trim();
            aCourse.CourseTitle = txtboxCTitle.Text.Trim();
            aCourse.Duration = Convert.ToInt32(txtboxduration.Text);
            aCourse.SaveCourse(aCourse);
            MessageBox.Show("the course info saved successfully saved","saved");
        }

        protected void Btnupdate_Click(object sender, EventArgs e)
        {

        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}