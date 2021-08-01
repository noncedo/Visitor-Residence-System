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
using System.Data;
[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum)]

namespace PGSVApplication
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DirectorySearcher dSearcher = null;
        UtilityClass encryption = new UtilityClass();
        StudentDBAccess stdntDbAccess = new StudentDBAccess();
        StudentHandler stdntHandler = new StudentHandler();
        SignUpHandler checkIfUserExists = new SignUpHandler();
        StudentRoomHandler room = new StudentRoomHandler();
        string studentNumber, studentPassword;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SearchUserPanel.Visible = true;
                SignUpUserPanel.Visible = false;
                GetRoom();
                GetVillage();
                GetFlat();
                
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
        public void GetRoom()
        {
            DataTable dt = new DataTable();
            dt = room.GetRoom();
            cmbRoom.DataSource = dt;
            cmbRoom.DataTextField = "RoomDescription";
            cmbRoom.DataValueField = "RoomId";
            cmbRoom.DataBind();
            cmbRoom.Items.Insert(0, "---Select Room---");
        }
        public void GetVillage()
        {
            DataTable dt = new DataTable();
            dt = room.GetVillage();
            cmbVillage.DataSource = dt;
            cmbVillage.DataTextField = "VillageNumber";
            cmbVillage.DataValueField = "VillageId";
            cmbVillage.DataBind();
            cmbVillage.Items.Insert(0, "---Select Village---");
        }
        public void GetFlat()
        {
            DataTable dt = new DataTable();
            dt = room.GetFlat();
            cmbFlat.DataSource = dt;
            cmbFlat.DataTextField = "FlatNumber";
            cmbFlat.DataValueField = "FlatId";
            cmbFlat.DataBind();
            cmbFlat.Items.Insert(0, "---Select Flat---");
        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //txtUsername
            //txtFirstName
            //txtSurname
            //txtPassword
            //txtConfirmPassword
            if(txtUsername.Text != string.Empty && txtFirstName.Text != string.Empty && txtSurname.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty)
            {
                if (encryption.EncryptData(txtPassword.Text )== encryption.EncryptData(txtConfirmPassword.Text))
                {
                    //User user = new User();
                    DAL.Student student = new DAL.Student();
                    student.StudentName = txtFirstName.Text;
                    student.StudentSurname = txtSurname.Text;
                    
                    student.Password = encryption.EncryptData(txtPassword.Text);
                    
                    if (txtUsername.Text.Substring(0, 1)  == "s")
                    {
                        student.StudentNumber = txtUsername.Text.Substring(1, txtUsername.Text.Length - 1); 
                        student.UserName = txtUsername.Text;
                    }
                    else
                    {
                        student.StudentNumber = txtUsername.Text;
                        student.UserName = "s" + txtUsername.Text; 
                    }


                    //student.RoomNumber = txtRoomNumber.Text;
                    stdntHandler.InsertStudent(student);
                    //if  == true)
                    //{
                        
                    //}
                }
                StudentRoom students = new StudentRoom();
                StudentRoomHandler handler = new StudentRoomHandler();
                DataTable maxs = new DataTable();
                maxs = handler.GetMax();
                int studentId = int.Parse(maxs.Rows[0]["Max"].ToString());

                students.RoomId = int.Parse(cmbRoom.SelectedValue);
                students.FlatId = int.Parse(cmbFlat.SelectedValue);
                students.VillageId = int.Parse(cmbVillage.SelectedValue);
                students.StudentId = studentId;

                handler.InsertStudentRoom(students);

                Session["StudentName"] = txtFirstName.Text;
                Session["StudentSurname"] = txtSurname.Text;
                Session["Password"] = txtPassword.Text;
                Session["Username"] = txtUsername.Text;
                Response.Redirect("SignUpNotification.aspx");
            }
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
    }
}