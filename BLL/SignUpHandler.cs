using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SignUpHandler
    {
        SignUpDBAccess signUpUser = new SignUpDBAccess();

        public bool CheckIfUserExists(string userName)
        {
            return signUpUser.CheckIfUserExists(userName);
        }
        //public bool InsertAdminUser(Admin admin)
        //{
        //    return signUpUser.InsertAdminUser(admin);
        //}

        //public bool InsertSecurityUser(Security security)
        //{
        //    return signUpUser.InsertSecurityUser(security);
        //}

        public bool InsertStudentUser(User user, Student student)
        {
            return signUpUser.InsertStudentUser(user, student);
        }
    }
}
