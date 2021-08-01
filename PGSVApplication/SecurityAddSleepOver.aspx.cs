using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace PGSVApplication
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        SleepOverHandler bl = null;
        DAL.SpecialPermit visit = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SleepOvers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                bl = new SleepOverHandler();
                visit = new DAL.SpecialPermit();

                string SpecilaPermitId = bl.GetApprovedSleepOvers()[e.NewEditIndex].SleepOverId;

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

        protected void SleepOvers_PreRender(object sender, EventArgs e)
        {
            try
            {
                bl = new SleepOverHandler();
                SleepOvers.DataSource = bl.GetApprovedSleepOvers();
                SleepOvers.DataBind();

                if (SleepOvers.Rows.Count > 0)
                {
                    //This replaces <td> with <th> and adds the scope attribute
                    SleepOvers.UseAccessibleHeader = true;

                    //This will add the <thead> and <tbody> elements
                    SleepOvers.HeaderRow.TableSection = TableRowSection.TableHeader;
                }

            }
            catch (Exception)
            {

            }
        }
    }
}