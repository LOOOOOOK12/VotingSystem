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
    public partial class UC_PartylistMembers : UserControl
    {
        public UC_PartylistMembers()
        {
            InitializeComponent();
        }

        private FlowLayoutPanel FL_Members;
        
        //public string PLID 
        //{
        //    get { return LBL_ID.Text; }
        //    set { LBL_ID.Text = value; }
        //}
        public string Name
        {
            get { return LBL_Name.Text; }
            set { LBL_Name.Text = value; }
        }

        public string Position
        {
            get { return LBL_Position.Text; }
            set { LBL_Position.Text = value; }
        }

        public Image MemberPicture
        {
            get { return PB_Member.Image; }
            set { PB_Member.Image = value; }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
