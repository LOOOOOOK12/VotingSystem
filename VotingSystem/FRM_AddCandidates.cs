using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VotingSystem
{
    public partial class FRM_AddCandidates : Form
    {
        public FRM_AddCandidates()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_AddCandidates_Load(object sender, EventArgs e)
        {
            try 
            {
                using (DB_VotingSystemEntities db = new DB_VotingSystemEntities())
                { 
                    CB_partylistNames.DataSource = db.Partylists.ToList();
                    CB_partylistNames.ValueMember = "Partylist_ID";
                    CB_partylistNames.DisplayMember = "PartylistName";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
