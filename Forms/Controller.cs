using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelindicator1.ForeColor = System.Drawing.Color.Red;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelindicator4.ForeColor = System.Drawing.Color.Black;
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void Controller_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            labelindicator2.ForeColor = System.Drawing.Color.Red;
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
            labelindicator4.ForeColor = System.Drawing.Color.Black;
            Add_Diagonisis add = new Add_Diagonisis();
            add.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelindicator3.ForeColor = System.Drawing.Color.Red;
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator4.ForeColor = System.Drawing.Color.Black;
            HISTORY_OF_PATIENT history = new HISTORY_OF_PATIENT();
            history.Show();
           
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            labelindicator4.ForeColor = System.Drawing.Color.Red;
            labelindicator1.ForeColor = System.Drawing.Color.Black;
            labelindicator2.ForeColor = System.Drawing.Color.Black;
            labelindicator3.ForeColor = System.Drawing.Color.Black;
             Doctor history  = new Doctor();
            history.Show();

            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

      

      

