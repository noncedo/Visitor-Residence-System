using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SignInHandler
    {
        SignInDBAccess signInDB = new SignInDBAccess();
        #region Check Admin & Sign In
        public bool CheckAdminSignIn(string myUsername, string myPassword)
        {
            return signInDB.CheckAdminSignIn(myUsername, myPassword);
        }
        public DataTable SignInAdmin(string myUsername, string myPassword)
        {
            return signInDB.SignInAdmin(myUsername, myPassword);
        }
        #endregion

        #region Check Security & Sign In
        public bool CheckSecuritySignIn(string myUsername, string myPassword)
        {
            return signInDB.CheckSecuritySignIn(myUsername, myPassword);
        }
        public DataTable SignInSecurity(string myUsername, string myPassword)
        {
            return signInDB.SignInSecurity(myUsername, myPassword);
        }
        #endregion

        #region Check Tenant & Sign In
        public bool CheckTenantSignIn(string myUsername, string myPassword)
        {
            return signInDB.CheckTenantSignIn(myUsername, myPassword);
        }
        public DataTable SignInTenant(string myUsername, string myPassword)
        {
            return signInDB.SignInTenant(myUsername, myPassword);
        }
        #endregion
    }
}
