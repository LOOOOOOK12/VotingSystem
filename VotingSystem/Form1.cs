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


namespace VotingSystem
{
    public partial class FRM_Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");


        public FRM_Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {

            //if admin will log in
            //string admin = userNametxtbx.Text;
            //string password = Password_txtbx.Text;

            //if (admin == "admin" && password == "admin")
            //{
            //    FRM_Home f3 = new FRM_Home();
            //    this.Hide();
            //    f3.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("incorrect username or password");
            //}

            //if voters will log in
            string admin = userNametxtbx.Text;
            string password = Password_txtbx.Text;

            if (admin == "admin" && password == "admin")
            {
                FRM_Home f3 = new FRM_Home();
                this.Hide();
                f3.ShowDialog();
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Register WHERE IDnumber = @Username AND password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", userNametxtbx.Text);
                    cmd.Parameters.AddWithValue("@Password", Password_txtbx.Text);

                    // Execute the query using a SqlDataReader or any other method
                    FRM_Home f3 = new FRM_Home();
                    this.Hide();
                    f3.ShowDialog();


                    con.Close(); // Close the connection after use

                }
            }
        }

            private void label4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {

        }

        private void userNametxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
