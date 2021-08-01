using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Net.Mail;

namespace PGSVApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UtilityClass encryption = new UtilityClass();
        SignInHandler signInTenant = new SignInHandler();

        DataTable dt = new DataTable();
        DataTable dts = new DataTable();
        DataTable dtz = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please enter valid username and password.');", true);
            }
            if (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                dt = signInTenant.SignInTenant(txtUsername.Text, encryption.EncryptData(txtPassword.Text));
                dts = signInTenant.SignInAdmin(txtUsername.Text, encryption.EncryptData(txtPassword.Text));
                dtz = signInTenant.SignInSecurity(txtUsername.Text, encryption.EncryptData(txtPassword.Text));

                int countTen = dt.Rows.Count;
                int countAdmin = dts.Rows.Count;
                int countSec = dtz.Rows.Count;

                if (dt.Rows.Count >0)
                {
                    Session["Username"] = dt.Rows[0]["Username"].ToString();
                    Session["StudentNumber"] = dt.Rows[0]["StudentNumber"].ToString();
                    Session["Password"] = dt.Rows[0]["Password"].ToString();
                    Session["StudentName"] = dt.Rows[0]["StudentName"].ToString();
                    Session["StudentSurname"] = dt.Rows[0]["StudentSurname"].ToString();
                    Session["StudentId"] = dt.Rows[0]["StudentId"].ToString();

                    Response.Redirect("StudentHome.aspx");
                }
                else if (dts.Rows.Count >0)
                {
                    Session["admin"] = dts.Rows[0]["AdminId"].ToString();
                    //Session["UserFirstnames"] = dts.Rows[0]["AdminFirstname"].ToString();
                    //Session["UserLastnames"] = dts.Rows[0]["AdminLastname"].ToString();
                    //Session["StudentNumbers"] = dts.Rows[0]["AdminStudentNumber"].ToString();

                    Response.Redirect("AdminInsert.aspx");
                }
                else if (dtz.Rows.Count >0)
                {
                    Session["security"] = dtz.Rows[0]["SecurityId"].ToString();
                    //Session["UserFirstnamez"] = dtz.Rows[0]["SecurityFirstname"].ToString();
                    //Session["UserLastnamez"] = dtz.Rows[0]["SecurityLastname"].ToString();
                    //Session["StudentNumberz"] = dtz.Rows[0]["StaffNumber"].ToString();

                    Response.Redirect("SecurityHome.aspx");
                }
                else
                {
                    lblNo.Visible = true;
                    lblNo.Text = "Incorrect Username or Password.";
                }
                //bool compareTenant = signInTenant.CheckTenantSignIn(txtUsername.Text, encryption.EncryptData(txtPassword.Text));
                //if (compareTenant == true)
                //{


                //}
                //else if (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty)
                //{



                //}
                //else if (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty)
                //{



                //}
                //else
                //{
                //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Username and Password are incorrect. Please enter valid username and password.');", true);
                //    txtUsername.Text = string.Empty;
                //    txtPassword.Text = string.Empty;
                //}
            }
        }

        
    }
}