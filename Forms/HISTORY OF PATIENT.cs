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
    public partial class HISTORY_OF_PATIENT : Form
    {
        DBConnection db = new DBConnection();

        SQLiteConnection conn = DBConnection.GetConnection();
        public HISTORY_OF_PATIENT()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HISTORY_OF_PATIENT history = new HISTORY_OF_PATIENT();
            history.Show();
            this.Hide();
        }

        private void HISTORY_OF_PATIENT_Load(object sender, EventArgs e)
        {
            LoadPatient();
        }
        void LoadPatient()
        {
           
            string query = "SELECT * FROM  AddDiagonisis";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Diagonisis add = new Add_Diagonisis();
            add.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
