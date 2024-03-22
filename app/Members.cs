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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBox1.Text);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\newdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM UserData where Id='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "UserData");
            if (ds.Tables[0].Rows.Count != 0)
            {
                usernameBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                GmailBox1.Text = ds.Tables[0].Rows[0][2].ToString();
                PasswordBox1.Text = ds.Tables[0].Rows[0][3].ToString();
                ContactBox1.Text = ds.Tables[0].Rows[0][4].ToString();
                AddressBox1.Text = ds.Tables[0].Rows[0][5].ToString();
                GenderBox1.Text = ds.Tables[0].Rows[0][6].ToString();
               

            }
            else
            {
                MessageBox.Show("Invaid id");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\newdatabase.mdf;Integrated Security=True;Connect Timeout=30");
                string del = "DELETE FROM UserData where Id='" + int.Parse(idBox1.Text) + "'";
                SqlCommand cmd = new SqlCommand(del, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully!");
                    Members_Load(this, null);
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
                MessageBox.Show("Enter valid id number\n");

            }
                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\newdatabase.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "UPDATE UserData set username='" + usernameBox1.Text + "',gmail='" + GmailBox1.Text + "',password ='" + PasswordBox1.Text + "',contact='" + ContactBox1.Text + "',address='" + AddressBox1.Text + "',gender ='" + GenderBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully!");
                    Members_Load(this, null);
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
                MessageBox.Show("Enter ID first");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            usernameBox1.Text = " ";
            GmailBox1.Text = " ";
            PasswordBox1.Text = " ";
            ContactBox1.Text = " ";
            AddressBox1.Text = " ";
            GenderBox1.Text = " ";
        }
    }
}
