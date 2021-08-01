using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Text;

namespace PGSVApplication
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        SecurityHandler securityHandler = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                EmptyPanelSearchUserForDayVisit.Visible = true;
                PopulatedSearchUserForDayVisit.Visible = false;

                txtStuVis.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtAddress.Enabled = false;
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;
                btnEmptyPanelSearchUserForDayVisit.Enabled = false;
            }
        }
        private void GetRegisteredUserStudentInformation(string username)
        {
            SecurityHandler securityHandler = new SecurityHandler();
            DataTable dt = securityHandler.SecuritySearchTenant(username);
            if (dt.Rows.Count == 0)
            {

            }
            else
            {
                //Populate the values
                txtSearchedName.Text = dt.Rows[0]["UserFirstname"].ToString();
                txtSearchedSurname.Text = dt.Rows[0]["UserLastname"].ToString();
                txtSearchedVillage.Text = "PGSV";
                txtSearchedRoom.Text = dt.Rows[0]["RoomNumber"].ToString();
                //Show populated
                PopulatedSearchUserForDayVisit.Visible = true;
                EmptyPanelSearchUserForDayVisit.Visible = false;
                btnSearchRegTenant.Enabled = false;
                txtSearchField.Enabled = false;
            }
                
        }
        //private string EncryptData(string password)
        //{
        //    // Adopted here: http://www.dotnetfunda.com/forums/show/16822/decrypt-password-in-aspnet

        //    string ms = string.Empty;
        //    byte[] encode = new byte[password.Length];
        //    encode = Encoding.UTF8.GetBytes(password);
        //    ms = Convert.ToBase64String(encode);
        //    return ms;
        //}

        protected void btnEmptyPanelSearchUserForDayVisit_Click(object sender, EventArgs e)
        {
            //if()
        }

        protected void btnSearchRegTenant_Click(object sender, EventArgs e)
        {
            btnSearchRegTenant.Enabled = false;
        }

        protected void btnPersonal_Click(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text.Trim().Length != 0)
            {
                GetRegisteredUserStudentInformation(txtStudentNumber.Text.Trim());
            }
            else
            {
                Response.Write("<script>alert('Please enter your student number')</script>");
            }
        }

        //protected void cmbIdentifier_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}