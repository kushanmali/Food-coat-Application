using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chawwa
{
    public partial class Order_Member : Form
    {
        public Order_Member()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(UserBox.Text!=" " && itemCodeBox.Text!=" " && QBox.Text!=" ")
            {
                string username = UserBox.Text;
                string itemcode = itemCodeBox.Text;
                int Quantity = int.Parse(QBox.Text);

                //Import the library file using System.Data.Sql.Client//

                //Import the sql connection data connection -----> right click ----> Connection String ----> Select all
                //copy and paste it in the @ and "Paste it"//

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\database 1.mdf';Integrated Security=True;Connect Timeout=30");


                string qry = "INSERT INTO OrderMember Values('" + username + "','" + itemcode + "','" + Quantity + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());


                }
                finally
                {
                    con.Close();

                }






            }
            else
            {
                MessageBox.Show("You Have to fill all the fields");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order_Now fm = new Order_Now();
            fm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(itemCodeBox.Text=="1S" || itemCodeBox.Text=="2S" || itemCodeBox.Text=="3S" || itemCodeBox.Text=="4S")
            {
                l2total.Text = "Rs.350/=";

            }

            else if(itemCodeBox.Text == "5S" || itemCodeBox.Text == "6S" || itemCodeBox.Text == "7S" || itemCodeBox.Text == "8S")
            {
                l2total.Text = "Rs.450/=";
            }

            else if(itemCodeBox.Text == "1M" || itemCodeBox.Text == "2M" || itemCodeBox.Text == "3M" || itemCodeBox.Text == "4M")
            {
                l2total.Text = "Rs.550/=";
            }
            else if(itemCodeBox.Text == "5M" || itemCodeBox.Text == "6M" || itemCodeBox.Text == "7M" || itemCodeBox.Text == "8M")
            {
                l2total.Text = "Rs.650/=";
            }
            else if(itemCodeBox.Text == "1L" || itemCodeBox.Text == "2L" || itemCodeBox.Text == "3L" || itemCodeBox.Text == "4L")
            {
                l2total.Text = "Rs.1350/=";
            }

            else if(itemCodeBox.Text == "5L" || itemCodeBox.Text == "6L" || itemCodeBox.Text == "7L" || itemCodeBox.Text == "8L")
            {
                l2total.Text = "Rs.1550/=";
            }

        }
    }
}
