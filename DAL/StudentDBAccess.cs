using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDBAccess
    {
        public bool InsertStudent(Student student)
        {
            SqlParameter[] pars = new SqlParameter[]
            {

                   new SqlParameter("@StudentName", student.StudentName),
                   new SqlParameter("@StudentSurname", student.StudentSurname),
                   new SqlParameter("@StudentNumber", student.StudentNumber),
                   new SqlParameter("@Username", student.UserName),
                   new SqlParameter("@Password", student.Password),
            };
            return DBHelper.ExecuteNonQuery("sp_InsertStudent", CommandType.StoredProcedure, pars);
        }
        public DataTable GetUserInfo(int studentID)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StudentId", studentID)
            };
            return DBHelper.ExecuteParamerizedSelectCommand("sp_GetUserInfo", CommandType.StoredProcedure, pars);
        }
        public DataTable GetSpecialPermit(int studentID)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@StudentId", studentID)
            };
            return DBHelper.ExecuteParamerizedSelectCommand("sp_GetSpecialPermit", CommandType.StoredProcedure, pars);
        }
    }
}
