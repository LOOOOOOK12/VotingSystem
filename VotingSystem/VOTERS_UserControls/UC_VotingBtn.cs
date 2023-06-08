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
    public partial class UC_VotingBtn : UserControl
    {
        public UC_VotingBtn()
        {
            InitializeComponent();
        }
        private FlowLayoutPanel FL_Vote;

        public string ElectionTitle
        {
            get { return LBL_EletionTitle.Text; }
            set { LBL_EletionTitle.Text = value; }
        }

        public string Name
        {
            get { return LBL_Name.Text; }
            set { LBL_Name.Text = value; }
        }

        public string Pname
        {
            get { return LBL_PartylistName.Text; }
            set { LBL_PartylistName.Text = value; }
        }

        public string PosName
        {
            get { return LBL_Position.Text; }
            set { LBL_Position.Text = value; }
        }
        public Image CandidatePicture
        {
            get { return PB_CandidatePic.Image; }
            set { PB_CandidatePic.Image = value; }
        }

        public Image PartylistLogo
        {
            get { return PB_PartylistLogo.Image; }
            set { PB_PartylistLogo.Image = value; }
        }

        private void BTN_Vote_Click(object sender, EventArgs e)
        {
            
        }
    }
}
