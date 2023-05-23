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

            //Log in ng admin
            string Idnum = userNametxtbx.Text;
            string password = Password_txtbx.Text;

            if (Idnum == "admin" && password == "admin")
            {
                FRM_Home f3 = new FRM_Home();
                this.Hide();
                f3.ShowDialog();
            }

            //log in ng voters
            else
            {
                string connectionString = @"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Voters WHERE ID = @Username AND password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", userNametxtbx.Text);
                    cmd.Parameters.AddWithValue("@Password", Password_txtbx.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Valid login credentials
                        FRM_Voting Voting = new FRM_Voting();
                        this.Hide();
                        Voting.ShowDialog();
                    }
                    else
                    {
                        // Invalid login credentials
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }

        }

        //pang gawa ng account
            private void label4_Click(object sender, EventArgs e)
        {
            FRM_CreateAcc f2 = new FRM_CreateAcc();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FRM_Login FL = new FRM_Login();
                Application.Exit();
            }
        }
    }
}
