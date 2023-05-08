using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VotingSystem
{
    public partial class AddingPartyList_FRM : Form
    {
        public AddingPartyList_FRM()
        {
            InitializeComponent();
            
        }
        
        private void Partylist_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingPartyList_FRM_Load(object sender, EventArgs e)
        {

        }

        private void addPL_btn_Click(object sender, EventArgs e)
        {
            string PL_name = AddPartylist_txtbx.Text;
            FRM_Partylist PL = new FRM_Partylist();


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
