using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class SleepOverHandler
    {
        SleepoverDBAccess sod = new SleepoverDBAccess();
        public bool InsertSleepOver(SleepOver sleep)
        {
            return sod.InsertSleepOver(sleep);
        }
        public DataTable GetAllIdentities()
        {
            return sod.GetAllIdentities();
        }
		public bool SignOutSpecialPermit(SpecialPermit permit)
        {
            return sod.SignOutSpecialPermit(permit);
        }
        public List<SpecialPermit> GetApprovedSleepOvers()
        {
            return sod.GetApprovedSleepOvers();
        }
    }
}
