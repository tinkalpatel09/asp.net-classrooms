using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MidtermReview.Business;
using System.Windows.Forms;


namespace MidtermReview.GUI
{
    public partial class WebFormProjectAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownListStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int indexSelected= DropDownListStudent.SelectedIndex;
            int tempId =Convert.ToInt32( DropDownListStudent.SelectedItem.Value);
            //MessageBox.Show(tempId.ToString());
            Student aStudent = new Student();
            aStudent = aStudent.SearchStudent(tempId);
            if (aStudent !=null)
            {
                LabelStudentInfo.Text = aStudent.StudentNumber + "\n" +
                                        aStudent.Firstname + "\n" +
                                        aStudent.Lastname + "\n" +
                                        aStudent.Email;
            }
            else
            {
                MessageBox.Show("Student not Found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        protected void DropDownListProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = DropDownListProject.SelectedItem.Value;
            Project aproject = new Project();
            aproject = aproject.SearchProject(code);
            if (aproject != null)
            {
                LabelProjectInfo.Text = aproject.ProjectCode + "\n" +
                                        aproject.ProjectTitle + "\n" +
                                        aproject.DueDate.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Project not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}