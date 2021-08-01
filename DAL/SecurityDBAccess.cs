using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SecurityDBAccess
    {
        #region Search Tenant for Visit
        public DataTable SecuritySearchTenant(string myUsername)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenantUsername", myUsername)
            };
            DataTable dtTenant = DBHelper.ExecuteParamerizedSelectCommand("[dbo].[sp_SecuritySearchTenant]", CommandType.StoredProcedure, parameters);
            return dtTenant;
        }
        public bool InsertSecurity(Security security)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StaffNumber", security.StaffNumber),
                new SqlParameter("@SecurityFirstName", security.SecurityFirstName),
                new SqlParameter("@SecurityLastName", security.SecurityLastName),
                new SqlParameter("@SecurityPassword", security.SecurityPassword)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertSecurity", CommandType.StoredProcedure, pars);
        }
        #endregion
    }
}
