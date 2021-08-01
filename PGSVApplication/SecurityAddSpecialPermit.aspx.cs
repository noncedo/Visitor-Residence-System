using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace PGSVApplication
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SpecialPermitHandler bl = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SpecialPermit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                bl = new SpecialPermitHandler();
                DAL.SpecialPermit visit = new DAL.SpecialPermit();

                string SpecilaPermitId = bl.GetAllSpecialPermits()[e.NewEditIndex].SleepOverId;

                visit.SleepOverId = SpecilaPermitId;
                visit.SignOut = true;


                if (bl.SignOutSpecialPermit(visit))
                {
                    string message = "<script>alert('Visitor Successfuly Signed Out.')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);

                    Response.Redirect("SecurityHome.aspx", false);
                }
            }
            catch (Exception)
            {

            }
        }

        protected void SpecialPermit_PreRender(object sender, EventArgs e)
        {
            try
            {
                bl = new SpecialPermitHandler();
                SpecialPermit.DataSource = bl.GetApprovedSpecialPermits();
                SpecialPermit.DataBind();

                if (SpecialPermit.Rows.Count > 0)
                {
                    //This replaces <td> with <th> and adds the scope attribute
                    SpecialPermit.UseAccessibleHeader = true;

                    //This will add the <thead> and <tbody> elements
                    SpecialPermit.HeaderRow.TableSection = TableRowSection.TableHeader;
                }

            }
            catch (Exception)
            {

            }
        }
    }
}