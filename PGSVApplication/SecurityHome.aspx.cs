using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Threading;

namespace PGSVApplication
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        DayVisitHandler bl = null;
        DAL.DayVisit visit = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DayVisit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                bl = new DayVisitHandler();
                visit = new DAL.DayVisit();

                string DayVisitId = bl.GetAllDayVisits()[e.NewEditIndex].DayVisitId;
                string timeOut = DateTime.Now.ToShortTimeString();

                visit.DayVisitId = DayVisitId;
                visit.EndTime = timeOut;


                if (bl.SignOutVisitor(visit))
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

        protected void DayVisit_PreRender(object sender, EventArgs e)
        {
            try
            {
                    bl = new DayVisitHandler();
                    DayVisit.DataSource = bl.GetAllDayVisits();
                    DayVisit.DataBind();

                    if(DayVisit.Rows.Count > 0)
                    {
                        //This replaces <td> with <th> and adds the scope attribute
                        DayVisit.UseAccessibleHeader = true;

                        //This will add the <thead> and <tbody> elements
                        DayVisit.HeaderRow.TableSection = TableRowSection.TableHeader;


                    }
                
            }
            catch (Exception)
            {

            }
        }
    }
}