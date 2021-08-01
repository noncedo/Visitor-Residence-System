using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class StudentHandler
    {
        StudentDBAccess sd = new StudentDBAccess();
        public bool InsertStudent(Student student)
        {
            return sd.InsertStudent(student);
        }
        public DataTable GetUserInfo(int studentID)
        {
            return sd.GetUserInfo(studentID);
        }
        public DataTable GetSpecialPermit(int studentId)
        {
            return sd.GetSpecialPermit(studentId);
        }
    }
}
