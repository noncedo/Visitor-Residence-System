using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class AdminHandler
    {
        AdminDBAccess admins = new AdminDBAccess();
        public bool InsertAdmin(Admin admin)
        {
            return admins.InsertAdmin(admin);
        }

        //public bool InsertAdmin(global::PGSVApplication.Admin admin)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
