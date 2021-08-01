using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SpecialPermitDBAccess
    {
        public bool InsertSpecialRequest(SpecialRequest request)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                   new SqlParameter("@StudentId", request.StudentId),
                   new SqlParameter("@VisitorId", request.VisitorId),
                   new SqlParameter("@FirstName", request.FirstName),
                   new SqlParameter("@LastName", request.LastName),
                   new SqlParameter("@Address", request.Address),
                   new SqlParameter("@SpecialRequest", request.SpecialRequests),
                   new SqlParameter("@StartDate", request.StartDate),
                   new SqlParameter("@EndDate", request.EndDate)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertSpecialPermit", CommandType.StoredProcedure, pars);
        }
		public List<SpecialPermit> GetAllSpecialPermits()
        {
            List<SpecialPermit> permit = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSpecialPermits", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    permit = new List<SpecialPermit>();
                    foreach (DataRow row in table.Rows)
                    {
                        SpecialPermit visit = new SpecialPermit();
                        visit.SleepOverId = row["SpecialPermitId"].ToString();
                        visit.Tenant = row["StudentName"].ToString() + " " + row["StudentSurname"].ToString();
                        visit.Visitor = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                        visit.Room = "Village: " + row["VillageNumber"].ToString() + " | Flat: " + row["FlatNumber"].ToString() + row["RoomDescription"].ToString();
                        visit.Description = row["SpecialRequest"].ToString();
                        visit.StartDate = row["StartDate"].ToString();
                        visit.EndDate = row["EndDate"].ToString();

                        permit.Add(visit);
                    }
                }
                return permit;
            }
        }
        public List<SpecialPermit> GetApprovedSpecialPermits()
        {
            List<SpecialPermit> permit = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAprrovedSpecialPermits", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    permit = new List<SpecialPermit>();
                    foreach (DataRow row in table.Rows)
                    {
                        SpecialPermit visit = new SpecialPermit();
                        visit.SleepOverId = row["SpecialPermitId"].ToString();
                        visit.Tenant = row["StudentName"].ToString() + " " + row["StudentSurname"].ToString();
                        visit.Visitor = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                        visit.Room = "Village: " + row["VillageNumber"].ToString() + " | Flat: " + row["FlatNumber"].ToString() + row["RoomDescription"].ToString();
                        visit.Description = row["SpecialRequest"].ToString();
                        visit.StartDate = row["StartDate"].ToString();
                        visit.EndDate = row["EndDate"].ToString();

                        permit.Add(visit);
                    }
                }
                return permit;
            }
        }
        public bool ApproveSpecialPermit(SpecialPermit permit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@SpecialPermitId", permit.SleepOverId)
            };
            return DBHelper.ExecuteNonQuery("sp_ApproveSpecialPermit", CommandType.StoredProcedure, pars);
        }
        public bool RejectSpecialPermit(SpecialPermit permit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@SpecialPermitId", permit.SleepOverId)
            };
            return DBHelper.ExecuteNonQuery("sp_RejectSpecialPermit", CommandType.StoredProcedure, pars);
        }

        public bool SignOutSpecialPermit(SpecialPermit permit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@SleepOverId", permit.SleepOverId)
            };
            return DBHelper.ExecuteNonQuery("sp_SignOutVisitorPermit", CommandType.StoredProcedure, pars);
        }
		
    }
}
