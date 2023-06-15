using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.BLL;

namespace VotingSystem.ADMIN_AddUpdateElection
{
    public partial class FRM_ViewElectionParticipants : Form
    {
        public FRM_ViewElectionParticipants()
        {
            InitializeComponent();
        }



        public void displayfieldElectionMember(string electionid)
        {
            label2.Text = electionid;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FL_Elections_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_ViewElectionParticipants_Load(object sender, EventArgs e)
        {
            string searchTermsPL = label2.Text;

            FL_Elections.Controls.Clear();


            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.SearchItemsPL(searchTermsPL);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    UC_ElectionMembers ElectionMembers = new UC_ElectionMembers();

                    //MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                    //partylistMembers.MemberPicture = new Bitmap(ms);

                    ElectionMembers.PLID = row["Partylist_ID"].ToString();
                    //ElectionMembers.PartyName = row["Name"].ToString();
                   

                    FL_Elections.Controls.Add(ElectionMembers);
                    
                    ElectionMembers.Click += new System.EventHandler(this.Refresh_btn_Click);

                }
            }
            else
            {
                // Show a message or handle no data available
                MessageBox.Show("No data available.");
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
