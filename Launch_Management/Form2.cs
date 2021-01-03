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
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=launch");
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

            Form2 f = new Form2();
            f.Show();
            f.Refresh();
            this.Hide();
            
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string selectquery = "SELECT * FROM `view`";
            DataTable t = new DataTable();
            MySqlDataAdapter d = new MySqlDataAdapter(selectquery, con);
            d.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "delete from `view` where ID = '" + textBox3.Text + "'";
            MySqlDataAdapter md = new MySqlDataAdapter(cmd , con);
            md.SelectCommand.ExecuteNonQuery();
            con.Close();

           


            MessageBox.Show("Delete Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fh= new Form4();
            fh.Show();
           this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
