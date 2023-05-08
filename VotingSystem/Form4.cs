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
    public partial class FRM_Partylist : Form
    {
        public FRM_Partylist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_Partylist_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartylist_btn_Click(object sender, EventArgs e)
        {
            AddingPartyList_FRM AddPL = new AddingPartyList_FRM();
            AddPL.ShowDialog();
        }

        private void listViewPartylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
