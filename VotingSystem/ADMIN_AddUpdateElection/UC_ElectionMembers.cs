using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem.ADMIN_AddUpdateElection
{
    public partial class UC_ElectionMembers : UserControl
    {
        public UC_ElectionMembers()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel FL_Elections;

        public string PLID
        {
            get { return LBL_PLID.Text; }
            set { LBL_PLID.Text = value; }
        }
        public string PartyName
        {
            get { return LBL_PLName.Text; }
            set { LBL_PLName.Text = value; }
        }

        public Image PartlistPicture
        {
            get { return PB_Partylist.Image; }
            set { PB_Partylist.Image = value; }
        }   
    }
}
