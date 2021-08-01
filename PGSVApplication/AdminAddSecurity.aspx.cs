using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

namespace PGSVApplication
{
    public partial class AdminAddSecurity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Security security = new Security();
            SecurityDBAccess db = new SecurityDBAccess();
            UtilityClass utilityClass = new UtilityClass();

            security.StaffNumber = txtUsername.Text;
            security.SecurityFirstName = txtFirstName.Text;
            security.SecurityLastName = txtSurname.Text;
            security.SecurityPassword = utilityClass.EncryptData(txtPassword.Text);

            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtUsername.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            db.InsertSecurity(security);
        }
    }
}