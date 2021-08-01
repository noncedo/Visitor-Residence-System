using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBHelper
    {
        //const string CONNECTION_STRING = "Data Source=localhost;Initial Catalog=PGSVVisitor;Integrated Security=True";
        public static string CONNECTION = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        //==================================================================================================================================================================================================//==================================================================================================================================================================================================
        #region ExecuteNonQuery()
        internal static bool ExecuteNonQuery(string commandName, CommandType cmdType,
            SqlParameter[] pars)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(CONNECTION))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(pars);

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        result = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return result > 0;
        }
        #endregion ExecuteNonQuery()
        //==================================================================================================================================================================================================//==================================================================================================================================================================================================
        #region ExecuteSelectCommand()
        internal static DataTable ExecuteSelectCommand(string commandName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(CONNECTION))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandName;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }
        #endregion ExecuteSelectCommand()
        //==================================================================================================================================================================================================//======================================================================================================================================
        #region ExecuteParamerizedSelectCommand()
        internal static DataTable ExecuteParamerizedSelectCommand(string commandName, CommandType cmdType, SqlParameter[] pars)
        {
            DataTable dt = new DataTable();
            using (SqlConnection dbConn = new SqlConnection(CONNECTION))
            {
                using (SqlCommand dbCmd = dbConn.CreateCommand())
                {
                    dbCmd.CommandType = cmdType;
                    dbCmd.CommandText = commandName;
                    dbCmd.Parameters.AddRange(pars);
                    try
                    {
                        if (dbConn.State == ConnectionState.Closed)
                        {
                            dbConn.Open();
                        }
                        using (SqlDataAdapter dbAdapter = new SqlDataAdapter(dbCmd))
                        {
                            dbAdapter.Fill(dt);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return dt;
        }
    }
}
#endregion