using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class SpecialRequestHandler
    {
        SpecialPermitDBAccess spd = new SpecialPermitDBAccess();
        public bool InsertSpecialRequest(SpecialRequest request)
        {
            return spd.InsertSpecialRequest(request);
        }
		public List<SpecialPermit> GetAllSpecialPermits()
        {
            return spd.GetAllSpecialPermits();
        }
		public bool SignOutSpecialPermit(SpecialPermit permit)
		{
			return spd.SignOutSpecialPermit(permit);
		}
    }
}
