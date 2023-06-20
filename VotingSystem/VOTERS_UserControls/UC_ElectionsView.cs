using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.VOTERS_VotingForms;

namespace VotingSystem.VOTERS_UserControls
{
    public partial class UC_ElectionsView : UserControl
    {
        public UC_ElectionsView()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel FL_Vote;

        private string voterNAME;

        public string ViewElection 
        {
            get { return LBL_ElectionTitle.Text; }
            set { LBL_ElectionTitle.Text = value; }
        }

        public string ElectionID
        {
            get { return LBL_ElectionID.Text; }
            set { LBL_ElectionID.Text = value; }
        }

        private void BTN_View_Click(object sender, EventArgs e)
        {
            FRM_VotingForm votingForm = new FRM_VotingForm();
            votingForm.displayfieldPartylistMember(ViewElection);
            votingForm.displayfieldVoterName(voterNAME);
            votingForm.ShowDialog();
        }

        private void LBL_ElectionTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
