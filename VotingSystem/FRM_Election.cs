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
    public partial class FRM_Election : Form
    {
        public FRM_Election()
        {
            InitializeComponent();
        }

        private void BTN_SearchCandidates_Click(object sender, EventArgs e)
        {

        }

        private void BTN_AddElection_Click(object sender, EventArgs e)
        {
            FRM_AddElection AddElection = new FRM_AddElection();
            AddElection.ShowDialog();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
