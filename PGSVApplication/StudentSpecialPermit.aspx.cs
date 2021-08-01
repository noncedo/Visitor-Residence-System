using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using System.Data;
using System.Text;

namespace PGSVApplication
{
    public partial class StudentSpecialPermit : System.Web.UI.Page
    {
        public int StudentNo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnCreateRequest.Enabled = false;

            txtAddress.Enabled = false;
            txtEndDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtRequest.Enabled = false;
            txtStartDate.Enabled = false;
            txtStudentNumber.Enabled = true;
            txtStuVis.Enabled = false;
            btnSearch.Enabled = true;
            //StudentHandler sd = new StudentHandler();
            //DataTable dtsp = sd.GetSpecialPermit(int.Parse(Session["StudentId"].ToString()));

            ////Session["spStartDate"] = dtsp.Rows[0]["StartDate"].ToString();
            ////Session["spEndDate"] = dtsp.Rows[0]["EndDate"].ToString();
            //if (dtsp.Rows.Count > 0)
            //{
            //    Session["approved"] = dtsp.Rows[0]["Approved"].ToString();
            //    if (Session["approved"].ToString() == "True")
            //    {
            //        lblVis.Visible = true;
            //        lblVis.Text = "You already have a permit.";
            //        btnSearch.Enabled = false;
            //    }
            //}
        }

        protected void btnCreateRequest_Click(object sender, EventArgs e)
        {
            SpecialRequest request = new SpecialRequest();
            SpecialRequestHandler db = new SpecialRequestHandler();

            request.StudentId = int.Parse(Session["StudentId"].ToString());
            request.VisitorId = txtStuVis.Text;
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.Address = txtAddress.Text;
            request.SpecialRequests = txtRequest.Text;
            request.StartDate = txtStartDate.Text;
            request.EndDate = txtEndDate.Text;
            db.InsertSpecialRequest(request);
            Response.Redirect("StudentHome.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
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
                btnCancel.Enabled = true;
                btnCreateRequest.Enabled = true;

                txtAddress.Enabled = true;
                txtEndDate.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtRequest.Enabled = true;
                txtStartDate.Enabled = true;
                txtStudentNumber.Enabled = false;
                txtStuVis.Enabled = true; 
                btnSearch.Enabled = false;
                string name = "";
                Session["StudentId"] = Convert.ToInt32(dt.Rows[0]["StudentId"].ToString());
                name = dt.Rows[0]["StudentName"].ToString() + " " + dt.Rows[0]["StudentSurname"].ToString();
                lblName.Text = "Name: "+ name;
                lblRoom.Text = "Room: "+ dt.Rows[0]["RoomDescription"].ToString();
                lblVillage.Text = "Village: " + dt.Rows[0]["VillageNumber"].ToString();
                lblFlat.Text = "Flat: " + dt.Rows[0]["FlatNumber"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnCreateRequest.Enabled = false;

            txtAddress.Enabled = false;
            txtEndDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtRequest.Enabled = false;
            txtStartDate.Enabled = false;
            txtStudentNumber.Enabled = true;
            txtStuVis.Enabled = false;
            btnSearch.Enabled = true;
        }
    }
}