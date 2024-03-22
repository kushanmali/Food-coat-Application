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
    public partial class Order_Now : Form
    {
        public Order_Now()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FInalOrder2 fm = new FInalOrder2();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinalOrder fm = new FinalOrder();
            fm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //imagine sanjanu is  a registerd member in the system so when he eneters his details this message box will show
            //the results and direct him to the member ordering system
            //order page.and he will get the discount.
            //this is only an assumption we don't know how to check.
            if (usernameBox.Text=="sanjanu" && passwordBox.Text=="sanjanu1234")
            {
                MessageBox.Show("Hii ..Sanjanu");

                FInalOrder2 fm = new FInalOrder2();
                fm.Show();
                this.Hide();
            }

            if(usernameBox.Text=="kushan")
            {
                MessageBox.Show("Sign up to be a member");

                FinalOrder fm = new FinalOrder();
                fm.Show();
                this.Hide();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }
    }
}
