using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MidtermReview.DataAccess;

namespace MidtermReview.GUI
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(UtilityDB.ConnectDB().State.ToString());

        }

        protected void CalendarDate_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = CalendarDate.SelectedDate;
            TextBoxDate.Text = date.ToShortDateString();
        }
    }
}