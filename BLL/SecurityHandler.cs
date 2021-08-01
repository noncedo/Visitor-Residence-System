using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class SecurityHandler
    {
        SecurityDBAccess secrity = new SecurityDBAccess();
        public DataTable SecuritySearchTenant(string myUsername)
        {
            return secrity.SecuritySearchTenant(myUsername);
        }
        public bool InsertSecurity(Security security)
        {
            return secrity.InsertSecurity(security);
        }
    }
}
