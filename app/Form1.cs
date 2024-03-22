using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chawwa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            REgister fm = new REgister();
            fm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Collection fm = new Collection();
            fm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order_Now fm = new Order_Now();
            fm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/CholaRest/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/indianhutbangkok/?hl=en");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=fsirryKyBN8");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Members fm = new Members();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order_Now fm = new Order_Now();
            fm.Show();
            this.Hide();
        }
    }
}
