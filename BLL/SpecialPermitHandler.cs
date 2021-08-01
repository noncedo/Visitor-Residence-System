using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SpecialPermitHandler
    {
        SpecialPermitDBAccess DA = new SpecialPermitDBAccess();
        public List<SpecialPermit> GetAllSpecialPermits()
        {
            return DA.GetAllSpecialPermits();
        }
        public bool SignOutSpecialPermit(SpecialPermit permit)
        {
            return DA.SignOutSpecialPermit(permit);
        }
        public List<SpecialPermit> GetApprovedSpecialPermits()
        {
            return DA.GetApprovedSpecialPermits();
        }
        public bool ApproveSpecialPermit(SpecialPermit permit)
        {
            return DA.ApproveSpecialPermit(permit);
        }
        public bool RejectSpecialPermit(SpecialPermit permit)
        {
            return DA.RejectSpecialPermit(permit);
        }
    }
}
