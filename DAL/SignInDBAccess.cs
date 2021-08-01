using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SignInDBAccess
    {
        #region Check Admin & Sign In
        public bool CheckAdminSignIn(string myUsername, string myPassword)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@AdminUsername", myUsername),
                new SqlParameter("@AdminPassword", myPassword)

            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_CheckAdminSignIn", CommandType.StoredProcedure, pars);
            if (dtAdmin.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable SignInAdmin(string myUsername, string myPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("@AdminUsername", myUsername),
                new SqlParameter("@AdminPassword", myPassword)
            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_SignInAdmin", CommandType.StoredProcedure, parameters);
            return dtAdmin;
        }    
        #endregion

        #region Check Security & Sign In
        public bool CheckSecuritySignIn(string myUsername, string myPassword)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StaffNumber", myUsername),
                new SqlParameter("@SecurityPassword", myPassword)

            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_SignInSecurity", CommandType.StoredProcedure, pars);
            if (dtAdmin.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable SignInSecurity(string myUsername, string myPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StaffNumber", myUsername),
                new SqlParameter("@Password", myPassword)
            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_SignInSecurity", CommandType.StoredProcedure, parameters);
            return dtAdmin;
        }
        #endregion

        #region Check Tenant & Sign In
        public bool CheckTenantSignIn(string myUsername, string myPassword)
        {
            SqlParameter[] par1 = new SqlParameter[]
            {
                new SqlParameter("@TenantUsername", myUsername),
                new SqlParameter("@TenantPassword", myPassword)

            };
            SqlParameter[] par2 = new SqlParameter[]
            {
                new SqlParameter("@TenantUsername", myUsername),
                new SqlParameter("@TenantPassword", myPassword)

            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_CheckTenantSignInStudentUsername", CommandType.StoredProcedure, par1);
            DataTable dtStudent = DBHelper.ExecuteParamerizedSelectCommand("sp_CheckTenantSignInStudentNumber", CommandType.StoredProcedure, par2);

            if (dtAdmin.Rows.Count == 1 || dtStudent.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable SignInTenant(string myUsername, string myPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenantUsername", myUsername),
                new SqlParameter("@TenantPassword", myPassword)
            };
            DataTable dtAdmin = DBHelper.ExecuteParamerizedSelectCommand("sp_SignInTenant", CommandType.StoredProcedure, parameters);
            return dtAdmin;
        }
        #endregion
    }
}
