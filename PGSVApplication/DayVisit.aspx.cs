using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.Threading;

namespace PGSVApplication
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SleepOverHandler sleepOver = null;
        SignUpHandler checkIfUserExists = null;
        DAL.DayVisit dayVisit = null;
        DayVisitHandler residentInfo = null;
        DataTable residentInformation = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sleepOver = new SleepOverHandler();
                cmbIdentifier.Enabled = false;
                cmbIdentifier.CssClass = "form-control";
                txtFirstName.Enabled = false;
                txtFirstName.CssClass = "form-control";
                txtLastName.Enabled = false;
                txtLastName.CssClass = "form-control";
                txtStartTime.Enabled = false;
                txtStartTime.CssClass = "form-control";
                btnCreateDayVisit.Enabled = false;
                btnCancel.Visible = false;

                Label1.Visible = false;
                Label2.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;

                cmbIdentifier.DataSource = sleepOver.GetAllIdentities();
                cmbIdentifier.DataTextField = "IdentityDescription";
                cmbIdentifier.DataValueField = "IdentityId";
                cmbIdentifier.DataBind();
                cmbIdentifier.Items.Insert(0, "Please Select Identity");
            }

        }


        protected void btnPersonal_Click(object sender, EventArgs e)
        {
            checkIfUserExists = new SignUpHandler();
            residentInfo = new DayVisitHandler();
            if (txtStudentNumber.Text != string.Empty)
            {
                if (checkIfUserExists.CheckIfUserExists(txtStudentNumber.Text) == true)
                {
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    btnPersonal.Enabled = false;
                    txtStudentNumber.Enabled = false;

                    residentInformation = new DataTable();
                    residentInformation = residentInfo.GetResidentInformation(txtStudentNumber.Text);

                    Session["StudentId"] = residentInformation.Rows[0]["StudentId"].ToString();
                    lblFirstname.Text = residentInformation.Rows[0]["StudentName"].ToString();
                    lblSurname.Text = residentInformation.Rows[0]["StudentSurname"].ToString();
                    lblVillage.Text = residentInformation.Rows[0]["VillageNumber"].ToString();
                    lblFlat.Text = residentInformation.Rows[0]["FlatNumber"].ToString() + " (" + residentInformation.Rows[0]["RoomDescription"].ToString() + ")";

                    lblFirstname.Visible = true;
                    lblSurname.Visible = true;
                    lblVillage.Visible = true;
                    lblFlat.Visible = true;

                    txtStartTime.Text = DateTime.Now.ToShortTimeString().ToString();
                    cmbIdentifier.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtLastName.Enabled = true;
                    btnCreateDayVisit.Enabled  = true;
                    btnCancel.Visible = true;
                }
                else
                {
                    string message = "<script>alert('Username does not exist. Please enter valid username.')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
            }
        }

        protected void btnCreateDayVisit_Click(object sender, EventArgs e)
        {
           try
           {
                if(cmbIdentifier.SelectedValue != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtStartTime.Text != "")
                {
                    residentInfo = new DayVisitHandler();
                    dayVisit = new DAL.DayVisit();
                    dayVisit.StudentId = Session["StudentId"].ToString();
                   
                    dayVisit.IdentifierType = cmbIdentifier.SelectedValue.ToString();
                    dayVisit.FirstName = txtFirstName.Text;
                    dayVisit.LastName = txtLastName.Text;
                    dayVisit.StartTime = txtStartTime.Text;

                    if(residentInfo.InsertDayVisitor(dayVisit))
                    {
                        string message = "<script>alert('Created Successfuly.')</script>";
                        ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);

                        Label1.Visible = false;
                        Label2.Visible = false;
                        Label4.Visible = false;
                        Label5.Visible = false;

                        lblFirstname.Text = "";
                        lblFirstname.Visible = false;
                        lblSurname.Text = "";
                        lblSurname.Visible = false;
                        lblVillage.Text = "";
                        lblVillage.Visible = false;
                        lblFlat.Text = "";
                        lblFlat.Visible = false;

                        cmbIdentifier.Enabled = false;
                        txtFirstName.Text = "";
                        txtFirstName.Enabled = false;
                        txtLastName.Text = "";
                        txtLastName.Enabled = false;
                        txtStartTime.Text = "";
                        txtStartTime.Enabled = false;
                        txtStudentNumber.Text = "";
                        txtStudentNumber.Enabled = true;

                        btnPersonal.Enabled = true;
                        btnCreateDayVisit.Enabled = false;
                        btnCancel.Visible = false;
                        Session["StudentId"] = "";

                    }
                    else
                    {
                        string message = "<script>alert('Not Successful - Something went wrong on the server.')</script>";
                        ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                    }
                    
                }
                else
                {
                    string message = "<script>alert('Please make you provide all required fields.')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
           }
           catch(Exception)
           {

           }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;

            lblFirstname.Text = "";
            lblFirstname.Visible = false;
            lblSurname.Text = "";
            lblSurname.Visible = false;
            lblVillage.Text = "";
            lblVillage.Visible = false;
            lblFlat.Text = "";
            lblFlat.Visible = false;

            cmbIdentifier.Enabled = false;
            txtFirstName.Text = "";
            txtFirstName.Enabled = false;
            txtLastName.Text = "";
            txtLastName.Enabled = false;
            txtStartTime.Text = "";
            txtStartTime.Enabled = false;
            txtStudentNumber.Text = "";
            txtStudentNumber.Enabled = true;

            btnPersonal.Enabled = true;
            btnCreateDayVisit.Enabled = false;
            btnCancel.Visible = false;
            Session["StudentId"] = "";
        }
    }
}