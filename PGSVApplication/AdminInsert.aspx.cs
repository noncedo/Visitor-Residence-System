using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using System.Windows.Forms;
using System.Security.Permissions;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum)]

namespace PGSVApplication
{
    public partial class AdminInsert : System.Web.UI.Page
    {
        DirectorySearcher dSearcher = null;
        UtilityClass encryption = new UtilityClass();
        StudentDBAccess stdntDbAccess = new StudentDBAccess();
        StudentHandler stdntHandler = new StudentHandler();
        SignUpHandler checkIfUserExists = new SignUpHandler();
        string studentNumber, studentPassword;
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchUserPanel.Visible = true;
            SignUpUserPanel.Visible = false;
        }
        private void GetUserInformation(string username, string passowrd, string domain)
        {
            Cursor.Current = Cursors.WaitCursor;


            SearchResult rs = null;
            studentNumber = "s" + txtSearchUsername.Text;
            rs = SearchUserByUserName(GetDirectorySearcher(username, passowrd, domain), studentNumber.Trim()); //search student number

            if (rs != null)
            {
                ShowUserInformation(rs);
                SignUpUserPanel.Visible = true;
                SearchUserPanel.Visible = false;
            }
            else
            {
                //Response.Write("<script>alert('Student is not currently registered.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Student is not currently registered.');", true);
                txtSearchUsername.Text = "";
                SearchUserPanel.Visible = true;
                SignUpUserPanel.Visible = false;
            }
        }
        private void ShowUserInformation(SearchResult rs)
        {
            Cursor.Current = Cursors.Default;
            txtUsername.Text = studentNumber;
            if (rs.GetDirectoryEntry().Properties["givenName"].Value != null)
                txtFirstName.Text = rs.GetDirectoryEntry().Properties["givenName"].Value.ToString();
            if (rs.GetDirectoryEntry().Properties["sn"].Value != null)
                txtSurname.Text = rs.GetDirectoryEntry().Properties["sn"].Value.ToString();

        }
        private DirectorySearcher GetDirectorySearcher(string username, string passowrd, string domain)
        {
            if (dSearcher == null)
            {
                try
                {
                    dSearcher = new DirectorySearcher(
                        new DirectoryEntry("LDAP://" + domain, username, passowrd));
                }
                catch (DirectoryServicesCOMException e)
                {
                    MessageBox.Show("Couldn't connect to the Active Directory.", "Error Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Message.ToString();
                }
                return dSearcher;
            }
            else
            {
                return dSearcher;
            }
        }
        private SearchResult SearchUserByUserName(DirectorySearcher ds, string username)
        {

            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);
            SearchResult userObject = ds.FindOne();
            if (userObject != null)
                return userObject;
            else
                return null;

        }
        private string GetSystemDomain()
        {
            try
            {
                return Domain.GetComputerDomain().ToString().ToLower();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return string.Empty;
            }
        }

        protected void btnSearchUsername_Click(object sender, EventArgs e)
        {
            Session["name"] = txtSearchUsername.Text;
            string username = "s214036960"; //Type in your student number here, prefix with s
            string password = "SiveGwija"; //your password here
            string address = GetSystemDomain();
            if (txtSearchUsername.Text.Trim().Length != 0)
            {
                //Check if user does not exist in database
                if (checkIfUserExists.CheckIfUserExists(txtSearchUsername.Text) == true)
                {
                    //Response.Write("<script>alert('User already exists in system.')</script>");
                    //Response.Write("<script>BootstrapDialog.alert('User already exists in system.');</script>");
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('User already exists in system');", true);
                    txtSearchUsername.Text = string.Empty;
                }
                //Sign Up user
                else
                {
                    GetUserInformation(username.Trim(), password.Trim(), "mandela.ac.za".ToString());
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Please enter your student number');", true);
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtFirstName.Text != string.Empty && txtSurname.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty)
            {
                if (encryption.EncryptData(txtPassword.Text) == encryption.EncryptData(txtConfirmPassword.Text))
                {
                    DAL.Admin admin = new DAL.Admin();
                    AdminHandler admins = new AdminHandler();
                    User user = new User();

                    admin.AdminFirstName = txtFirstName.Text;
                    admin.AdminLastName = txtSurname.Text;

                    admin.AdminPassword = encryption.EncryptData(txtPassword.Text);
                    DAL.Student student = new DAL.Student();
                    if (txtUsername.Text.Substring(0, 1) == "s")
                    {
                        admin.AdminStudentNumber = txtUsername.Text.Substring(1, txtUsername.Text.Length - 1);
                        admin.AdminStudentNumber = txtUsername.Text;
                    }
                    else
                    {
                        admin.AdminStudentNumber = txtUsername.Text;
                        admin.AdminStudentNumber = "s" + txtUsername.Text;
                    }
                    
                    if (admins.InsertAdmin(admin) == true)
                    {
                        Response.Redirect("SignUpNotification.aspx");
                    }
                }
            }
        }
    }
}