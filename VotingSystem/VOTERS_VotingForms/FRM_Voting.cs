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
    public partial class FRM_Voting : Form
    {

        public FRM_Voting()
        {
            InitializeComponent();
        }

        
        public string VoterName {
               get { return LBL_User.Text;}
               set { LBL_User.Text = value;}
        }

        private void BTN_Voters_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Vote.Height;
            Sidepanel.Top = BTN_Vote.Top;
            UC_Vote Vote = new UC_Vote();
            VotingPanel.Controls.Clear();
            VotingPanel.Controls.Add(Vote);
            Vote.BringToFront();
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Voting_Load(object sender, EventArgs e)
        {
            timer2.Start();
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");

            //timer2.Start();

            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;

            //string query = "SELECT COUNT(votersID) FROM Voters";

            //try
            //{
            //    cmd = new SqlCommand(query, con);
            //    Int32 rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            //    cmd.Dispose();
            //    con.Close();

            //    label4.Text = rowCount.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortDateString();
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Home.Height;
            Sidepanel.Top = BTN_Home.Top;
            UC_Home Home = new UC_Home();
            VotingPanel.Controls.Clear();
            VotingPanel.Controls.Add(Home);
            Home.BringToFront();
            

            
        }

        private void BTN_Candidate_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Candidate.Height;
            Sidepanel.Top = BTN_Candidate.Top;
            UC_Candidates Candidates = new UC_Candidates();
            VotingPanel.Controls.Clear();
            VotingPanel.Controls.Add(Candidates);
            Candidates.BringToFront();
        }

        private void BTN_Election_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BTN_Election.Height;
            Sidepanel.Top = BTN_Election.Top;
            UC_Elections elections = new UC_Elections();
            VotingPanel.Controls.Clear();
            VotingPanel.Controls.Add(elections);
            elections.BringToFront();
            
        }

        private void UC_Vote_Load(object sender, EventArgs e)
        {
            
        }

        public void displayfieldVoter(string voterName)
        {
            VoterName = voterName;

        }

        private void LBL_User_Click(object sender, EventArgs e)
        {

        }
    }
}
