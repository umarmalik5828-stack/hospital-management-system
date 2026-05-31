using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.database;
using WindowsFormsApp3.Forms;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBInitialize.CreateUsersTables();
            DBInitialize.CreateDiagonisisTables();
            DBInitialize.DoctorInfo();


            Application.Run(new Form1());
        }
    }
}
