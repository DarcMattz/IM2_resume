using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static string name = "";
        public static string address = "";
        public static string birthday = "";
        public static string email = ""; 
        public static string age = "";
        public static string phoneNum = "";
        public static string sex = "";
        public static string elementary = "";
        public static string highschool = "";
        public static string college = "";
        public static string skills = "";
        public static string civil = "";
        public static Image picture;


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox2.Text + " " + textBox3.Text + " " + textBox1.Text;
            address = textBox6.Text;
            age = textBox4.Text;
            phoneNum = maskedTextBox1.Text;
            email = textBox7.Text;

            if (radioButton1.Checked)
            {
                sex = "Male";
            }
            else if (radioButton2.Checked)
            {
                sex = "Female";
            }

            civil = comboBox1.Text;
            birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            elementary = textBox5.Text;
            highschool = textBox9.Text;
            college = textBox10.Text;
            skills = textBox11.Text;

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    picture = pictureBox1.Image;
                }
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
