using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SignUpDBAccess
    {
        public bool CheckIfUserExists(string userName)
        {
            SqlParameter[] pars = new SqlParameter[]
           {
                new SqlParameter("@Username", userName)
           };
            DataTable dt = DBHelper.ExecuteParamerizedSelectCommand("sp_CheckIfUserExists", CommandType.StoredProcedure, pars);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool InsertAdminUser(Admin admin)
        //{
        //    SqlParameter[] pars = new SqlParameter[]
        //    {
        //        new SqlParameter("@AdminUsername", admin.Username),
        //        new SqlParameter("@AdminPassword", admin.Password),
        //        new SqlParameter("@AdminUserFirstName", admin.UserFirstName),
        //        new SqlParameter("@AdminUserLastName", admin.UserLastName),
        //        new SqlParameter("@AdminStaffNumber", admin.StaffNumber)
        //    };
        //    return DBHelper.ExecuteNonQuery("sp_InsertAdminUser", CommandType.StoredProcedure, pars);
        //}

        //public bool InsertSecurityUser(Security security)
        //{
        //    SqlParameter[] pars = new SqlParameter[]
        //    {
        //        new SqlParameter("@SecurityUsername", security.Username),
        //        new SqlParameter("@SecurityPassword", security.Password),
        //        new SqlParameter("@SecurityUserFirstName", security.UserFirstName),
        //        new SqlParameter("@SecurityUserLastName", security.UserLastName),
        //        new SqlParameter("@SecurityStaffNumber", security.StaffNumber),
        //        new SqlParameter("@SecurityPositionDescription", security.PositionDescription)
        //    };
        //    return DBHelper.ExecuteNonQuery("sp_InsertSecurityUser", CommandType.StoredProcedure, pars);
        //}

        public bool InsertStudentUser(User user, Student student)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StudentUsername", user.Username),
                new SqlParameter("@StudentPassword", user.Password),
                new SqlParameter("@StudentUserFirstName", user.UserFirstName),
                new SqlParameter("@StudentUserLastName", user.UserLastName),
                new SqlParameter("@StudentStudentNumber", student.StudentNumber),
                //new SqlParameter("@StudentRoomNumber", student.RoomNumber)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertStudentUser", CommandType.StoredProcedure, pars);
        }
    }
}
