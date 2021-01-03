using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Launch_Management
{
    public partial class endstep : Form
    {
        int count = 0;
        public endstep()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=launch");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void endstep_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `view` ";
           

            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            string selectquery = "SELECT * FROM `view` WHERE Date= '" +this. dateTimePicker1.Text + "'";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);

            dataGridView1.DataSource = t;

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            endstep f = new endstep();
            f.Show();
            this.Close();
        }
    }
}
