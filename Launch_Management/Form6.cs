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
    public partial class Form6 : Form
    {
        string Gender;
        DataSet ds = new DataSet();
  
        public Form6()
        {
            InitializeComponent();
        }


        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=launch");


        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" || Gender == "" || comboBox4.Text == "" || comboBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || this.dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please Enter The Values....");
            }


            else
            {

                MySqlCommand cm = new MySqlCommand("SELECT * FROM view WHERE Cabin_No ='" + comboBox1.Text + "'", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                da.Fill(ds);
                
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show(" Cabin Name And NO  " + comboBox1.Text + " Alredy Exists");
                    ds.Clear();

                }
                else
                {
                    
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO `view`(`ID`, `Name`, `Age`, `Contact`, `Gender`, `Launches Name`, `Boarding Point`, `Cabin_No`, `Seat NO`, `TAKA`, `TIME` , `Date` ) VALUES  ('" + textBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + Gender + "','" + comboBox4.Text + "','" + comboBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "')", con);
                        cmd.ExecuteNonQuery();
                     
                      





                        MessageBox.Show("Succesful", "Message", MessageBoxButtons.OK);
                        con.Close();

                    
               }

            }

        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            endstep fh = new endstep();
            fh.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Other";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cabin f = new cabin();
            f.Show();
            this.Hide();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter md = new MySqlDataAdapter("SELECT max(cast(ID as int))+1 FROM view", con);
            DataTable dt = new DataTable();
            md.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToInt32(comboBox2.Text) * Convert.ToInt32(textBox1.Text);

            textBox2.Text = total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Launch Management System", new Font("Arial", 42, FontStyle.Regular), Brushes.Black, new Point(25, 25));
            e.Graphics.DrawString("Sadar Ghat Launch Terminal", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(120, 100));
            e.Graphics.DrawString("Phone : 01982641791,01625942595", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(110,150));

            e.Graphics.DrawString("Passenger Id    : " + textBox3.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 250));
            e.Graphics.DrawString("Passenger Name  : " + textBox7.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 300));
            e.Graphics.DrawString("Age             : " + textBox6.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 350));
            e.Graphics.DrawString("Contact Number  : " + textBox5.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 400));

            e.Graphics.DrawString("Launches Name   : " + comboBox4.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 450));
            e.Graphics.DrawString("Boarding point  : " + comboBox3.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 500));
            e.Graphics.DrawString("Cabin Name & NO : " + comboBox1.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 550));
            e.Graphics.DrawString("Seat NO         : " + comboBox2.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 600));
            e.Graphics.DrawString("Taka            : " + textBox2.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 650));
            e.Graphics.DrawString("Time            : " + dateTimePicker1.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 700));
            e.Graphics.DrawString("Date            : " + dateTimePicker2.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(40, 750));



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void printPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
