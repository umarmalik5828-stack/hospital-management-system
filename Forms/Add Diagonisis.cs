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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.Forms
{

    public partial class Add_Diagonisis : Form
    {
        DBConnection db = new DBConnection();

        SQLiteConnection conn = DBConnection.GetConnection();
        public Add_Diagonisis()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Diagonisis add = new Add_Diagonisis();
            add.Show();
            this.Hide();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Diagonisis_Load(object sender, EventArgs e)
        {
            LoadPatient();
        }
        void LoadPatient()
        {

            string query = "SELECT * FROM  AddDiagonisis";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO AddDiagonisis(Pid, Symptoms, Diagnosis, Medicines,Ward_Required,Ward) values (@pid, @symptoms,@diagonisis, @medicines,@ward,@type);";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.Parameters.AddWithValue("@pid", txtBoxid.Text);
            cmd.Parameters.AddWithValue("@symptoms", txtBoxsmp.Text);
            cmd.Parameters.AddWithValue("@diagonisis", txtBoxdg.Text);
            cmd.Parameters.AddWithValue("@medicines", txtBoxmd.Text);
            cmd.Parameters.AddWithValue("@ward", cmbwr.Text);
            cmd.Parameters.AddWithValue("@type", cmbtow.Text);


            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("save Successfully", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPatient();
        }
        //abqwertyuiasdfghj
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "delete from AddDiagonisis where Pid = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtBoxid.Text);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)

                {
                    MessageBox.Show("Record Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                LoadPatient();
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = DBConnection.GetConnection())
            {
                conn.Open();


                string query = "UPDATE AddDiagonisis SET  symptoms=@smp,Diagnosis=@dg, medicines=@md, ward_required=@wr,ward=@top WHERE Pid=@id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtBoxid.Text);
                cmd.Parameters.AddWithValue("@smp", txtBoxsmp.Text);
                cmd.Parameters.AddWithValue("@dg", txtBoxdg.Text);
                cmd.Parameters.AddWithValue("@md", txtBoxmd.Text);
                cmd.Parameters.AddWithValue("@wr", cmbwr.Text);
                cmd.Parameters.AddWithValue("@top", cmbtow.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                LoadPatient();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Patient add = new Add_Patient();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HISTORY_OF_PATIENT history = new HISTORY_OF_PATIENT();
            history.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Hide();
        }
    }
    }

