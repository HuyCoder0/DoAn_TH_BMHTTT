using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DoAn
{
    public class Database
    {
        public static OracleConnection Conn;

        public static string Host;
        public static string Port;
        public static string Sid;
        public static string User;
        public static string PassWord;
        public static void Set_Database(string user, string pass)
        {
            Database.Host = "localhost";  // Giá trị mặc định
            Database.Port = "1521";       // Giá trị mặc định
            Database.Sid = "orcl";        // Giá trị mặc định
            Database.User = user;
            Database.PassWord = pass;
        }

        public static bool Connect()
        {
            string consys = "";
            try
            {
                if (User.ToUpper().Equals("SYS"))
                {
                    consys = ";DBA Privilege=SYSDBA;";
                }
                string connString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = " + Host + ")(PORT = " + Port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                    + Sid + "))); USER ID =" + User + "; Password = " + PassWord + consys;

                Conn = new OracleConnection();
                Conn.ConnectionString = connString;
                Conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static OracleConnection Get_Connect()
        {
            if (Conn == null)
            {
                Connect();
            }
            return Conn;
        }

        //Hàm để thực hiện truy vấn query
        public static DataTable GetDataTable(string query)
        {
            try
            {
                OracleCommand command = new OracleCommand(query, Conn); // Sử dụng Conn đã kết nối
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public static DataTable ExecuteProcedure(string procedureName)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand(procedureName, Get_Connect()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu ra kiểu SYS_REFCURSOR
                    OracleParameter outputParam = new OracleParameter("result_cursor", OracleDbType.RefCursor)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    // Thực thi stored procedure và lấy dữ liệu
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi stored procedure: " + ex.Message);
                return null;
            }
        }
    }
}
