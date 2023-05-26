using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class FRM_Home : Form
    {
        public FRM_Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Home.Height;
            Sidepanel.Top = BTN_Home.Top;
        }


        // BTN_Candidates
        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Candidate.Height;
            Sidepanel.Top = BTN_Candidate.Top;
            FRM_ManageCandidates FMC = new FRM_ManageCandidates();
            FMC.Owner = this;
            FMC.ShowDialog();
        }

        //BTN_Partylist
        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Partylist.Height;
            Sidepanel.Top = BTN_Partylist.Top;
            FRM_Partylist PT = new FRM_Partylist();
            PT.Owner = this;
            PT.ShowDialog();
        }


        //BTN_Voters
        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Voters.Height;
            Sidepanel.Top = BTN_Voters.Top;
            FRM_Voters Voters = new FRM_Voters();
            Voters.Owner = this;
            Voters.ShowDialog();
        }

        //BTN_Election
        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Election.Height;
            Sidepanel.Top = BTN_Election.Top;
            FRM_Election Election = new FRM_Election();
            Election.Owner = this;
            Election.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_LogOut.Height;
            Sidepanel.Top = BTN_LogOut.Top;
            DialogResult result = MessageBox.Show("Log out", "You want to Log out?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FRM_Login FL = new FRM_Login();
                Hide();
                FL.Show();
            }
        }

        private void BTN_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_Home_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");

            timer1.Start();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            string query = "SELECT COUNT(votersID) FROM Voters";

            try
            { 
                cmd = new SqlCommand(query, con);
                Int32 rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                label4.Text = rowCount.ToString();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortDateString();
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
