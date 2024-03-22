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
    public partial class FInalOrder2 : Form
    {

        public static double due = 0;
        public static double dis;
        public FInalOrder2()
        {
            InitializeComponent();
        }

        private void FInalOrder2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nMuttonRice small     Rs.350/=";
            due = due + 350.00;
            ltotal2.Text = due.ToString();
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string message = "You haven't added anything to the order";
            string message2 = "You'order is accepted";
            if(richTextBox1.Text==" ")
            {
                MessageBox.Show(message);

            }

            else
            {
                MessageBox.Show(message2);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nMuttonRice Medium     Rs.550/=";
            due = due + 495;
            ltotal2.Text = due.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nMuttonRice Large      Rs.1350/=";
            due = due + 1215;
            ltotal2.Text = due.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nBuriyani small     Rs.350/=";
            due = due + 315;
            ltotal2.Text = due.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nBuriyani Medium     Rs.550/=";
            due = due + 495;
            ltotal2.Text = due.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nBuriyani Large     Rs.1350/=";
            due = due + 1215;
            ltotal2.Text = due.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nRoti small     Rs.350/=";
            due = due + 315;
            ltotal2.Text = due.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nRoti Medium     Rs.550/=";
            due = due + 495;
            ltotal2.Text = due.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nRoti Large    Rs.1350/=";
            due = due + 1215;
            ltotal2.Text = due.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Jalferi small     Rs.350/=";
            due = due + 315;
            ltotal2.Text = due.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Jalferi Medium    Rs.550/=";
            due = due + 495;
            ltotal2.Text = due.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Jalferi Large     Rs.1350/=";
            due = due + 1215;
            ltotal2.Text = due.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nKorma small     Rs.450/=";
            due = due + 405;
            ltotal2.Text = due.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nKorma Medium     Rs.650/=";
            due = due + 585;
            ltotal2.Text = due.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nKorma Large     Rs.1650/=";
            due = due + 1485;
            ltotal2.Text = due.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Masala  small     Rs.450/=";
            due = due + 405;
            ltotal2.Text = due.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Masala Medium     Rs.650/=";
            
            due = due + 585;

            ltotal2.Text = due.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChicken Masala Large     Rs.1550/=";
            due = due + 1395;
            ltotal2.Text = due.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChole Bharuthe small     Rs.450/=";
            due = due + 405;
            ltotal2.Text = due.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChole Bhathure Medium     Rs.650/=";
            due = due + 585;
            ltotal2.Text = due.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nChole Bhathure Large    Rs.1550/=";
            due = due + 1395;
            ltotal2.Text = due.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nLamb Curry small    Rs.450/=";
            due = due + 450;
            ltotal2.Text = due.ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nLamb Curry Medium    Rs.650/=";
            due = due + 585;
            ltotal2.Text = due.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nLamb Curry Large    Rs.1550/=";
            due = due + 1395;
            ltotal2.Text = due.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //discount is 10% in every item//
            richTextBox1.Text = "  ";
            ltotal2.Text = " ";



        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
           // double dis;
            //dis = 5 / 100;
            //double temp = double.Parse(due.ToString());
            //double discount = temp - dis;

            //labeld.Text = discount.ToString();
          //  labeld.Text = ltotal2.Text - dis;//


        }
    }
}
