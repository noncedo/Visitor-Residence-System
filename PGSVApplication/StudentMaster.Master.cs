using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PGSVApplication
{
    public partial class StudentMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentName"] != null)
            {
                lblName.Text = "Welcome (" + Session["StudentSurname"].ToString() + ", " + Session["StudentName"].ToString() + ")";
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }
            btnLogout.ServerClick += new EventHandler(btnLogout_ServerClick);
        }
        private void btnLogout_ServerClick(object sender, EventArgs e)
        {
            //Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }
}