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
    public partial class Collection : Form
    {
        public Collection()
        {
            InitializeComponent();
        }

        private void Collection_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items fm = new Items();
            fm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            item2 fm = new item2();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            item3 fm = new item3();
            fm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            item4 fm = new item4();
            fm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            item5 fm = new item5();
            fm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            item6 fm = new item6();
            fm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            item7 fm = new item7();
            fm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            item8 fm = new item8();
            fm.Show();
            this.Hide();
        }
    }
}
