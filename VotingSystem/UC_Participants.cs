using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;

namespace VotingSystem
{

    
    public partial class UC_Participants : UserControl
    {
        public UC_Participants()
        {
            InitializeComponent();
        }
        private FlowLayoutPanel FL_Candidates;



        public string CandidateName
            {
            get { return LBL_CandidateName.Text; }
            set { LBL_CandidateName.Text = value; }
            }
        public string PartylistName
        {
            get { return LBL_CandidateName.Text; }
            set { LBL_CandidateName.Text = value; }
        }
        public string Postition
        {
            get { return LBL_CandidateName.Text; }
            set { LBL_CandidateName.Text = value; }
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
    }
}
