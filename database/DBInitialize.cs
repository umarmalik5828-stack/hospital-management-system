using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net.Sockets;

namespace WindowsFormsApp3.database
{
    internal class DBInitialize
    {
        public static void CreateUsersTables()
        {
            DBConnection db = new DBConnection();

            SQLiteConnection conn = DBConnection.GetConnection();
            {
                conn.Open();
                string query = @" CREATE TABLE IF NOT EXISTS ADDPATIENT
                (
                    name TEXT NOT NULL,
                    id TEXT NOT NULL,
                    address TEXT NOT NULL,
                    phone TEXT NOT NULL,
                    age TEXT NOT NULL,
                    gender TEXT NOT NULL,
                    blood_group TEXT NOT NULL
                    );";


                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


            }
        }
        public static void CreateDiagonisisTables()
        {
            DBConnection db = new DBConnection();

            SQLiteConnection conn = DBConnection.GetConnection();
            {
                conn.Open();
                string query = @" CREATE TABLE IF NOT EXISTS AddDiagonisis
                (
                    Pid INTEGER NOT NULL,
                    Symptoms TEXT NOT NULL,
                    Diagnosis TEXT NOT NULL,
                    Medicines TEXT NOT NULL,
                    Ward_Required TEXT NOT NULL,
                    Ward TEXT NOT NULL);";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
        public static void DoctorInfo()
        {
            

            SQLiteConnection conn = DBConnection.GetConnection();
            {
                conn.Open();
                string query = @" CREATE TABLE IF NOT EXISTS Doctor
                (
                    Name TEXT NOT NULL,
                    ID TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    contact NOT NULL,
                    Age TEXT NOT NULL,
                    Gender TEXT NOT NULL,
                    Blood_Group TEXT NOT NULL
                    );";


                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


            }
        }
    }
}