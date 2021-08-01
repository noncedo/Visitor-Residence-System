using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data;
using System.Text;


namespace PGSVApplication
{
    
    public partial class VisitorSleep : System.Web.UI.Page
    {
        public int StudentsNo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnFinish.Enabled = false;
            txtAddress.Enabled = false;
            txtEndDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStartDate.Enabled = false;
            txtStudentNumber.Enabled = true;
            txtStuVis.Enabled = false;
            StudentHandler sd = new StudentHandler();
            DataTable dts = sd.GetUserInfo(int.Parse(Session["StudentId"].ToString()));
            if (dts.Rows.Count > 0)
            {
                Session["signOut"] = dts.Rows[0]["SignOut"].ToString();
                if (Session["signOut"].ToString() != "True")
                {
                    lblVis.Visible = true;
                    lblVis.Text = "You already have a permit.";
                    btnPersonal.Enabled = false;
                }
            }
            //DateBefore();
            //DateAfter();
        }
        //public void DateBefore()
        //{
        //    txtStartDate.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");
        //}
        //public void DateAfter()
        //{
        //    txtEndDate.Attributes["max"] = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd");
        //}
        protected void btnFinish_Click(object sender, EventArgs e)
        {
            SleepOver sleep = new SleepOver();
            SleepOverHandler sh = new SleepOverHandler();

            sleep.VisitorNumber = txtStuVis.Text;
            sleep.StudentNumber = int.Parse(Session["StudentsId"].ToString());
            sleep.FirstName = txtFirstName.Text;
            sleep.LastName = txtLastName.Text;
            sleep.Address = txtAddress.Text;
            sleep.StartDate = txtStartDate.Text;
            sleep.EndDate = txtEndDate.Text;
            sh.InsertSleepOver(sleep);
            Response.Redirect("StudentHome.aspx");
        }
        private void GetRegisteredUserStudentInformation(string username)
        {
            string name = "";
            SecurityHandler securityHandler = new SecurityHandler();
            DataTable dt = securityHandler.SecuritySearchTenant(username);
            if (dt.Rows.Count == 0)
            {

            }
            else
            {
                //Populate the values
                btnPersonal.Enabled = false;
                btnCancel.Visible = true;
                btnFinish.Enabled = true;
                txtAddress.Enabled = true;
                txtEndDate.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtStartDate.Enabled = true;
                txtStudentNumber.Enabled = false;
                txtStuVis.Enabled = true;
                Session["StudentsId"] = Convert.ToInt32(dt.Rows[0]["StudentId"].ToString());
                name = dt.Rows[0]["StudentName"].ToString()+" "+dt.Rows[0]["StudentSurname"].ToString();

                lblName.Text ="Name: "+ name;
                //lblRoom.Text ="Room: "+ dt.Rows[0]["RoomNumber"].ToString();
                lblRoom.Text = "Room: " + dt.Rows[0]["RoomDescription"].ToString();
                lblVillage.Text = "Village: " + dt.Rows[0]["VillageNumber"].ToString();
                lblFlat.Text = "Flat: " + dt.Rows[0]["FlatNumber"].ToString();
            }
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnPersonal.Enabled = true;
            btnCancel.Visible = false;
            btnFinish.Enabled = false;
            txtAddress.Enabled = false;
            txtEndDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStartDate.Enabled = false;
            txtStudentNumber.Enabled = true;
            txtStuVis.Enabled = false;
        }
    }
}