using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtBoxn.Text;
            String pass = txtBoxpas.Text;

            if (username == "admin" && pass == "pass")
            {
                MessageBox.Show("login successfully");

                Controller controller = new Controller();
                controller.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong user id or password");
            }
              
        


        }

        private void txtBoxpas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
