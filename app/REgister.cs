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
    public partial class REgister : Form
    {
        public REgister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        
       /* public bool Gender()
        {
            if(rbmale.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   */

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != " "  && GmailBox.Text != " "  && PasswordBox.Text != " " && ContactBox.Text != " "
                && AddressBox.Text != " ")
            {
                //declaring the variables in the register form //

                string username = usernameBox.Text;
                string gmail = GmailBox.Text;
                string password = PasswordBox.Text;
                string gender = GenderBox.Text;

                //is this date time picker correct  ??????????????????????????????//

                int contact = int.Parse(ContactBox.Text);
                string address = AddressBox.Text;
                string gn;

                //int birthday = int.Parse(BirthdayBox.Text);
                
                //how to enter the gender as a radio button //
                /*if (rbmale.Checked)
                {
                    gn = "male";
                }
                else
                {
                    gn = "female";
                } */
               
                //take the date time value in the date time picker//
                //DateTime birthday;

                //birthday = dateTimePicker1.Value;//
               



                //import the library file --> System.Data.SqlClient;//

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\newdatabase.mdf;Integrated Security=True;Connect Timeout=30");

                string qry = "INSERT INTO UserData Values('" + username + "','" + gmail + "','" + password + "','" + contact + "','" + address + "','" + gender + "')";

                SqlCommand cmd = new SqlCommand(qry, con);




                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    //give the feedback to user that data inserted succusfully//

                    MessageBox.Show("Data Inserted successfully");

                }

                catch(SqlException ex)
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
                MessageBox.Show("You have to enter all forms of data");
            }
              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ueat.io/docs/terms_and_conditions.pdf");
        }
    }
}
