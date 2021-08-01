using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class DayVisitHandler
    {
        DayvisitorDBAccess dvd = new DayvisitorDBAccess();
        public bool InsertDayVisitor(DayVisit day)
        {
            return dvd.InsertDayVisitor(day);
        }
        public List<DayVisit> GetAllDayVisits()
        {
            return dvd.GetAllDayVisits();
        }
        public DataTable GetResidentInformation(string stuNumber)
        {
            return dvd.GetResidentInformation(stuNumber);
        }
		public bool SignOutVisitor(DayVisit visit)
        {
            return dvd.SignOutVisitor(visit);
        }
    }
}
