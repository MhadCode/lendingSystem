using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lending_System;
using MySql.Data.MySqlClient;

namespace Lending_System
{
    public class DBCon
    {
        public static string Server = "localhost";
        public static string Database = "dblending";
        public static string User = "root";
        public static string Password = "";
        public static string Port = "3306";

        public static string constring = "Server=" + Server + ";" + "Database=" + Database + ";" + "Uid=" + User + ";" + "Password=" + Password + ";";
        public static MySqlConnection sql_con = new MySqlConnection(constring);

        public static string msg;
        public static MySqlCommand sql_cmd;
        private static string user, pass;

        public static string Login(string qry)
        {
            sql_cmd = new MySqlCommand(qry, sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                user = rd["UA_Username"].ToString();
                pass = rd["UA_Password"].ToString();
            }
            rd.Close();
            return user;
        }

        public static void open()
        {
            if (sql_con.State == ConnectionState.Open)
            {
               sql_con.Close();
            }
            sql_con.Open();
        }
    }
}
