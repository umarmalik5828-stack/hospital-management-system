using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.database;

namespace WindowsFormsApp3.Forms
{
    public partial class history_of_the_patient : Form
    {
        DBConnection db = new DBConnection();

        SQLiteConnection conn = DBConnection.GetConnection();
        public history_of_the_patient()
        {
            InitializeComponent();
        }
    }
}
