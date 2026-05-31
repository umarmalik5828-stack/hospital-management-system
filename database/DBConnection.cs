using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp3.database
{
    internal class DBConnection
    {
        private static string connectionstring = "Data Source=\"E:\\Blood Bank\\database\\Hospital.db\";Version=3;";
            

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);

            return conn;
        }
    }
}
