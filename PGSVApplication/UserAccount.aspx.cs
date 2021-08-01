using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

using System.Globalization;
namespace PGSVApplication
{
    public partial class UserAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetUserInfo();
        }
        public void GetUserInfo()
        {
            SecurityHandler sh = new SecurityHandler();
            DataTable dt = sh.SecuritySearchTenant(Session["StudentNumber"].ToString());

            lblFirstName.Text = Session["StudentName"].ToString();
            Session["StudentId"] = dt.Rows[0]["StudentId"].ToString();
            lblLastName.Text = Session["StudentSurname"].ToString();
            lblEmail.Text = Session["UserName"].ToString() + "@mandela.ac.za";
            Session["flat"] = dt.Rows[0]["FlatNumber"].ToString();
            Session["village"] = dt.Rows[0]["VillageNumber"].ToString();
            Session["room"] = dt.Rows[0]["RoomDescription"].ToString();
            lblRoom.Text = "Village:" + Session["village"].ToString() + "|Flat:" + Session["flat"].ToString() + "(" + Session["room"].ToString() + ")";
            //Session["signout"] = dt.Rows[0]["SignOut"].ToString();
            //Session["request"] = dt.Rows[0]["Approved"].ToString();

            //lblPerm.Text = Session["request"].ToString() + " " + Session["signout"].ToString();
            StudentHandler sd = new StudentHandler();
            DataTable dts = sd.GetUserInfo(int.Parse(Session["StudentId"].ToString()));
            if (dts.Rows.Count > 0)
            {
                Session["signOut"] = dts.Rows[0]["SignOut"].ToString();
                if (Session["signOut"].ToString() != "True")
                {
                    DateTimeFormatInfo date = new DateTimeFormatInfo();
                    string[] startDates = dts.Rows[0]["StartDate"].ToString().Split('-');
                    string[] endDates = dts.Rows[0]["EndDate"].ToString().Split('-');
                    string start = date.GetMonthName(int.Parse(startDates[1]));
                    string end = date.GetMonthName(int.Parse(endDates[1]));
                    lblSleep2.Text = "Your Permission starts from " + startDates[2] + " " + start + " " +  startDates[0]+ " and ends on the " + endDates[2] + " " + end + " " + endDates[0];
                }
                else
                {
                    lblSleep2.Text = "You do not have an active sleep permit.";
                }
            }
            else
            {
                lblSleep2.Text = "You do not have an active sleep permit.";
            }
            
            DataTable dtsp = sd.GetSpecialPermit(int.Parse(Session["StudentId"].ToString()));
            
            //Session["spStartDate"] = dtsp.Rows[0]["StartDate"].ToString();
            //Session["spEndDate"] = dtsp.Rows[0]["EndDate"].ToString();
            if (dtsp.Rows.Count > 0)
            {
                Session["approved"] = dtsp.Rows[0]["Approved"].ToString();
                if (Session["approved"].ToString() == "True")
                {
                    DateTimeFormatInfo date = new DateTimeFormatInfo();
                    string[] startDatees = dtsp.Rows[0]["StartDate"].ToString().Split('-');
                    string[] endDatees = dtsp.Rows[0]["EndDate"].ToString().Split('-');
                    string starte = date.GetMonthName(int.Parse(startDatees[1]));
                    string ende = date.GetMonthName(int.Parse(endDatees[1]));
                    lblPerm.Text = "Your Permission has been approved, starting from " +startDatees[0] +" "+ starte +" "+ startDatees[2]+" and ends on the "+endDatees[0]+" "+ ende+" "+endDatees[2];
                }
                else if (Session["approved"].ToString() == "False")
                {
                    lblPerm.Text = "Your Special Permission has been Rejected. Contact Admin to find out more. ";
                }
                else 
                {
                    lblPerm.Text = "You have a pending Special Permission slip, the Admin will look at it later.";
                }
            } 
            else 
            {
                lblPerm.Text = "You do not have an active special permission slip";
            }
        }
        protected void lnkUserInfo_Click(object sender, EventArgs e)
        {
            pnlPersonal.Visible = true;
            pnlPassword.Visible = false;
            GetUserInfo();
            liInfo.Attributes.Add("class", "active");
            liInfo.Attributes["class"] = "active";

            liManage.Attributes.Add("class", "no-active");
            liManage.Attributes["class"] = "no-active";

            liView.Attributes.Add("class", "no-active");
            liView.Attributes["class"] = "no-active";

            liHours.Attributes.Add("class", "no-active");
            liHours.Attributes["class"] = "no-active";
        }
        protected void lnkManage_Click(object sender, EventArgs e)
        {
            pnlPersonal.Visible = false;
            pnlPassword.Visible = true;
            liManage.Attributes.Add("class", "active");
            liManage.Attributes["class"] = "active";

            liView.Attributes.Add("class", "no-active");
            liView.Attributes["class"] = "no-active";

            liInfo.Attributes.Add("class", "no-active");
            liInfo.Attributes["class"] = "no-active";

            liHours.Attributes.Add("class", "no-active");
            liHours.Attributes["class"] = "no-active";
        }
        protected void lnkViewUser_Click(object sender, EventArgs e)
        {
            pnlPersonal.Visible = false;
            pnlPassword.Visible = false;
            liView.Attributes.Add("class", "active");
            liView.Attributes["class"] = "active";

            liInfo.Attributes.Add("class", "no-active");
            liInfo.Attributes["class"] = "no-active";

            liManage.Attributes.Add("class", "no-active");
            liManage.Attributes["class"] = "no-active";

            liHours.Attributes.Add("class", "no-active");
            liHours.Attributes["class"] = "no-active";
        }
        
        protected void lnkAddHours_Click(object sender, EventArgs e)
        {
            pnlPersonal.Visible = false;
            pnlPassword.Visible = false;
            liView.Attributes.Add("class", "no-active");
            liView.Attributes["class"] = "no-active";

            liInfo.Attributes.Add("class", "no-active");
            liInfo.Attributes["class"] = "no-active";

            liManage.Attributes.Add("class", "no-active");
            liManage.Attributes["class"] = "no-active";

            liHours.Attributes.Add("class", "active");
            liHours.Attributes["class"] = "active";
        }
    }
}