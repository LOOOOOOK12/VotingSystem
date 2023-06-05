using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.BLL;

namespace VotingSystem
{
    public partial class FRM_UpdateElection : Form
    {
        public FRM_UpdateElection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addPL_btn_Click(object sender, EventArgs e)
        {
            ClassBLL_Election objbll = new ClassBLL_Election();

            int electionID; // Variable to store the Partylist ID

            if (int.TryParse(TXTBX_ElectionID.Text, out electionID))
            {
                if (objbll.UpdateItems(electionID, TXTBX_ElectionTitle.Text, TXTBX_ElectionDesc.Text))
                {
                    MessageBox.Show("Record Successful!");
                }
                else
                {
                    MessageBox.Show("Record Failed!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Partylist ID!");
            }
        }
    }
}
