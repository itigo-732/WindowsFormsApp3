using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label1.Text = date.ToLongTimeString();
            timer1.Start();
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.AutoSize = false;
            if (date.Hour >= 9 & date.Hour < 12)
            {
                label2.Text = "おはようございます！";
            }
            else if (date.Hour >= 12 & date.Hour < 16)
            {
                label2.Text = "こんにちは！";
            }
            else
            {
                label2.Text = "こんばんは！";
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label1.Text = date.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void menu_add_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
