using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.name;
            label3.Text = Form1.address;
            label8.Text = Form1.phoneNum;
            label9.Text = Form1.email;
            label11.Text = Form1.age;
            label13.Text = Form1.sex;
            label7.Text = Form1.birthday;
            label16.Text = Form1.elementary;
            label18.Text = Form1.highschool;
            label20.Text = Form1.college;
            label22.Text = Form1.skills;
            pictureBox1.Image = Form1.picture;
            label2.Text = Form1.civil;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
