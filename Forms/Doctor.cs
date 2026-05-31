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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Patient history = new Add_Patient();
           history.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Doctor(name, id, address, contact,age,gender,blood_group) values (@name, @id, @address, @contact,@age,@gender,@bloodgroup);";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
                cmd.Parameters.AddWithValue("id", txtBoxID.Text);
                cmd.Parameters.AddWithValue("@address", txtBoxAd.Text);
                cmd.Parameters.AddWithValue("@contact", txtBoxPh.Text);
                cmd.Parameters.AddWithValue("@age", txtBoxAg.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                cmd.Parameters.AddWithValue("@bloodgroup", cmbBg.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("save Successfully", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxn.Clear();
                txtBoxID.Clear();
                txtBoxAd.Clear();
                cmbGen.Items.Clear();
                cmbBg.Items.Clear();
                txtBoxPh.Clear();
                txtBoxAg.Clear();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();


                string query = "UPDATE Doctor SET name=@name, phone=@contact, address=@address, gender=@gender, age=@age WHERE ID=@id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtBoxID.Text);
                cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
                cmd.Parameters.AddWithValue("@contact", txtBoxPh.Text);
                cmd.Parameters.AddWithValue("@address", txtBoxAd.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
                cmd.Parameters.AddWithValue("@age", txtBoxAg.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();




                string query = "delete from Doctor where Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtBoxID.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)

                {
                    MessageBox.Show("Record Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Diagonisis add = new Add_Diagonisis();
            add.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

