using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdminDBAccess
    {
        public bool InsertAdmin(Admin admin)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@AdminFirstName", admin.AdminFirstName),
                new SqlParameter("@AdminLastName", admin.AdminLastName),
                new SqlParameter("@AdminStudentNumber", admin.AdminStudentNumber),
                new SqlParameter("@AdminPassword", admin.AdminPassword)
            };
            return DBHelper.ExecuteNonQuery("sp_AddAdmin", CommandType.StoredProcedure, pars);
        }
    }
}
