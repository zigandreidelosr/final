using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appsdevproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals("Delosreyes")) && (textBox2.Text.Equals("zig123")))
            {
                Form f2 = new Form2();
                f2.Show();

                //MessageBox.Show("login Succesful");
            }
            else
            {

                MessageBox.Show("Username or Password is incorrect");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }
    }
}
