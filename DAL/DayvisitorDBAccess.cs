using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DayvisitorDBAccess
    {
        public DataTable GetResidentInformation(string stuNumber)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@Username", stuNumber)
            };
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetResidentInformation", CommandType.StoredProcedure, pars))
            {
                if (table.Rows.Count > 0)
                {
                    return table;
                }
                else
                {
                    return null;
                }
                    
            }
        }
        public List<DayVisit> GetAllDayVisits()
        {
            List<DayVisit> allDayVisitsList = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllDayVisits", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    allDayVisitsList = new List<DayVisit>();
                    foreach (DataRow row in table.Rows)
                    {
                        DayVisit visit = new DayVisit();
                        visit.DayVisitId = row["DayVisitId"].ToString();
                        visit.Tenant = row["StudentName"].ToString() + " " + row["StudentSurname"].ToString();
                        visit.Visitor = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                        visit.Room = "Village: " + row["VillageNumber"].ToString() + " | Flat: " + row["FlatNumber"].ToString() + row["RoomDescription"].ToString();
                        visit.StartTime = row["StartTime"].ToString();
                        visit.EndTime = row["EndTime"].ToString();
                        if (visit.EndTime == "")
                            visit.EndTime = "~~~~~~";
                        allDayVisitsList.Add(visit);
                    }
                }
                return allDayVisitsList;
            }
        }
        public bool InsertDayVisitor(DayVisit visit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StudentId", visit.StudentId),
                new SqlParameter("@IdentityId", visit.IdentifierType),
                new SqlParameter("@FirstName", visit.FirstName),
                new SqlParameter("@LastName", visit.LastName),
                new SqlParameter("@StartTime", visit.StartTime)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertDayVisitor", CommandType.StoredProcedure, pars);
        }
        public bool SignOutVisitor(DayVisit visit)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@DayVisitorId", visit.DayVisitId),
                 new SqlParameter("@EndTime", visit.EndTime)
            };
            return DBHelper.ExecuteNonQuery("sp_SignOutVisitor", CommandType.StoredProcedure, pars);
        }

    }
}
