using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace PGSVApplication
{
    public partial class ProcessRequest : System.Web.UI.Page
    {
        SpecialPermitHandler bl = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    ListRequests();
                }
            }
            catch(Exception)
            {

            }
        }

        protected void lstRequest_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ListRequests();
        }
        public void ListRequests()
        {
            bl = new SpecialPermitHandler();
            DAL.SpecialPermit visit = new DAL.SpecialPermit();
            lstRequest.DataSource = bl.GetAllSpecialPermits();
            lstRequest.DataBind();
        }

        protected void lstRequest_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            try
            {
                bl = new SpecialPermitHandler();
                DAL.SpecialPermit permit = new DAL.SpecialPermit();

                int SpecialPermitId = int.Parse(bl.GetAllSpecialPermits()[e.ItemIndex].SleepOverId);
                permit.SleepOverId = SpecialPermitId.ToString();
                if(bl.ApproveSpecialPermit(permit))
                {
                    string message = "<script>alert('Successfuly Approved')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
                else
                {
                    string message = "<script>alert('Not Successful')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
                ListRequests();
            }
            catch(Exception)
            {

            }
            
        }

        protected void lstRequest_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {
            try
            {
                bl = new SpecialPermitHandler();
                DAL.SpecialPermit permit = new DAL.SpecialPermit();

                int SpecialId = int.Parse(bl.GetAllSpecialPermits()[e.ItemIndex].SleepOverId);

                permit.SleepOverId = SpecialId.ToString();
                if(bl.RejectSpecialPermit(permit))
                {
                    string message = "<script>alert('Successfuly Rejected')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
                else
                {
                    string message = "<script>alert('Not Successful')</script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "JSScript", message);
                }
                ListRequests();
            }
            catch(Exception)
            {

            }
        }
    }
}