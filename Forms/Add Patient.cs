using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp3.database;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3.Forms
{
    public partial class Add_Patient : Form
    {
        //    DBConnection db = new DBConnection();

        //SQLiteConnection conn = DBConnection.GetConnection();
        public Add_Patient()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
               using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ADDPATIENT(name, id, address, phone,age,gender,blood_group) values (@name, @id, @address, @phone,@age,@gender,@bloodgroup);";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
                cmd.Parameters.AddWithValue("id", txtBoxID.Text);
                cmd.Parameters.AddWithValue("@address", txtBoxAd.Text);
                cmd.Parameters.AddWithValue("@phone", txtBoxPh.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Diagonisis add = new Add_Diagonisis();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HISTORY_OF_PATIENT history = new HISTORY_OF_PATIENT();
            history.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();




                string query = "delete from ADDPATIENT where Id = @id";
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

        private void button7_Click(object sender, EventArgs e)
        {
            
               using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

              
                   string query= "UPDATE ADDPATIENT SET name=@name, phone=@contact, address=@address, gender=@gender, age=@age WHERE ID=@id";

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
                    conn.Close()
;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection("YOUR_CONNECTION_STRING");

            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(
            //        "UPDATE ADDPATIENT SET Name=@name, Contact=@contact, Address=@address, Gender=@gender, Age=@age WHERE PatientID=@id", con);

            //    cmd.Parameters.AddWithValue("@id", txtBoxID.Text);
            //    cmd.Parameters.AddWithValue("@name", txtBoxn.Text);
            //    cmd.Parameters.AddWithValue("@contact", txtBoxPh.Text);
            //    cmd.Parameters.AddWithValue("@address", txtBoxAd.Text);
            //    cmd.Parameters.AddWithValue("@gender", cmbGen.Text);
            //    cmd.Parameters.AddWithValue("@age", txtBoxAg.Text);

            //    int rows = cmd.ExecuteNonQuery();

            //    if (rows > 0)
            //    {
            //        MessageBox.Show("Record Updated Successfully");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Record Not Found");
            //    }

            //    con.Close();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Patient add= new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


