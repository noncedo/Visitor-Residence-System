using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace DAL
{
    public class SleepoverDBAccess
    {
        public bool InsertSleepOver(SleepOver sleepOver)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@VisitorSleepOverNumber", sleepOver.VisitorNumber),
                new SqlParameter("@StudentId", sleepOver.StudentNumber),
                new SqlParameter("@FirstName", sleepOver.FirstName), 
                new SqlParameter("@LastName", sleepOver.LastName), 
                new SqlParameter("@Address", sleepOver.Address),
                new SqlParameter("@StartDate", sleepOver.StartDate), 
                new SqlParameter("@EndDate", sleepOver.EndDate)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertSleepOver", CommandType.StoredProcedure, pars);
        }
        public DataTable GetAllIdentities()
        {
            return DBHelper.ExecuteSelectCommand("sp_GetAllIdentities", CommandType.StoredProcedure);
        }
		//public DataTable GetAllIdentities()
  //      {
  //          return DBHelper.ExecuteSelectCommand("sp_GetAllIdentities", CommandType.StoredProcedure);
  //      }
        public List<SpecialPermit> GetApprovedSleepOvers()
        {
            List<SpecialPermit> sleepOver = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetApprovedSleepOvers", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    sleepOver = new List<SpecialPermit>();
                    foreach (DataRow row in table.Rows)
                    {
                        SpecialPermit visit = new SpecialPermit();
                        visit.SleepOverId = row["TwoNightSleepOverId"].ToString();
                        visit.Tenant = row["StudentName"].ToString() + " " + row["StudentSurname"].ToString();
                        visit.Visitor = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                        visit.Room = "Village: " + row["VillageNumber"].ToString() + " | Flat: " + row["FlatNumber"].ToString() + row["RoomDescription"].ToString();
                        visit.StartDate = row["StartDate"].ToString();
                        visit.EndDate = row["EndDate"].ToString();
                        
                        sleepOver.Add(visit);
                    }
                }
                return sleepOver;
            }
        }
        public bool SignOutSpecialPermit(SpecialPermit permit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@SleepOverId", permit.SleepOverId)
            };
            return DBHelper.ExecuteNonQuery("sp_SignOutSleepOver", CommandType.StoredProcedure, pars);
        }
    }
}
