using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void exit_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {

        }

        private void Partylist_btn_Click(object sender, EventArgs e)
        {
            FRM_Partylist PT = new FRM_Partylist();
            PT.Owner = this;
            PT.ShowDialog();
        }

        private void Position_btn_Click(object sender, EventArgs e)
        {
            FRM_Position PL = new FRM_Position();
            PL.Owner = this;
            PL.ShowDialog();
        }

        private void Voters_btn_Click(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Log out","You want to Log out?",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FRM_Login FL = new FRM_Login();
                Hide();
                FL.Show();
            }
           
        }
    }
}
