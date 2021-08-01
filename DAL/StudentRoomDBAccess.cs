using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentRoomDBAccess
    {
        public DataTable GetVillage()
        {
            DataTable dt = DBHelper.ExecuteSelectCommand("sp_GetVillage", CommandType.StoredProcedure);
            return dt;
        }
        public DataTable GetFlat()
        {
            DataTable dt = DBHelper.ExecuteSelectCommand("sp_GetFlat", CommandType.StoredProcedure);
            return dt;
        }
        public DataTable GetRoom()
        {
            DataTable dt = DBHelper.ExecuteSelectCommand("sp_GetRoom", CommandType.StoredProcedure);
            return dt;
        }
        public DataTable GetMax()
        {
            return DBHelper.ExecuteSelectCommand("sp_Max", CommandType.StoredProcedure);
        }
        public bool InsertStudentRoom(StudentRoom room)
        {
            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@RoomId", room.RoomId),
                new SqlParameter("@StudentId", room.StudentId),
                new SqlParameter("@FlatId", room.FlatId),
                new SqlParameter("@VillageId", room.VillageId)
            };
            return DBHelper.ExecuteNonQuery("sp_InsertStudentRoom", CommandType.StoredProcedure, pars);
        }
    }
}
