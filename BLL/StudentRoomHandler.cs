using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class StudentRoomHandler
    {
        StudentRoomDBAccess rooms = new StudentRoomDBAccess();
        public DataTable GetRoom()
        {
            return rooms.GetRoom();
        }
        public DataTable GetFlat()
        {
            return rooms.GetFlat();
        }
        public DataTable GetVillage()
        {
            return rooms.GetVillage();
        }
        public DataTable GetMax()
        {
            return rooms.GetMax();
        }
        public bool InsertStudentRoom(StudentRoom room)
        {
            return rooms.InsertStudentRoom(room);
        }
    }
}
