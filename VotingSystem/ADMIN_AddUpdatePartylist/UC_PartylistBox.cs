using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;

namespace VotingSystem
{
    public partial class UC_Partylist : UserControl
    {
        private FlowLayoutPanel flowLayoutPanel1;

        public UC_Partylist()
        {
            
            InitializeComponent();
            flowLayoutPanel1 = new FlowLayoutPanel();
        }

        public string PartylistID
        {
            get { return PartylistID_lbl.Text; }
            set { PartylistID_lbl.Text = value; }
        }

        public string PartylistName
        {
            get { return PartylistName_lbl.Text; }
            set { PartylistName_lbl.Text = value; }
        }

        public Image PartylistLogo
        {
            get { return PB_PLlogo.Image; }
            set { PB_PLlogo.Image = value; }
        }

        



        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Delete data from the database
                DeleteDataFromDatabase();

                // Remove the user control from the FlowLayoutPanel
                flowLayoutPanel1.Controls.Remove(this);
            }

        }

        private void DeleteDataFromDatabase()
        {
            // Establish the database connection and execute the delete operation
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM Partylist WHERE Partylist_ID = @Partylist_ID"; // Update with appropriate table and column names
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Partylist_ID", PartylistID);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateDataFromDatabase() 
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM Partylist WHERE Partylist_ID = @Partylist_ID"; // Update with appropriate table and column names
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Partylist_ID", PartylistID);
                command.ExecuteNonQuery();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FRM_EditPartylist FRM_EditPL = new FRM_EditPartylist();
            FRM_EditPL.displayfieldPartylist(PartylistID, PartylistName, PartylistLogo);
            FRM_EditPL.ShowDialog();
        }

        private void UC_Partylist_Load(object sender, EventArgs e)
        {

        }

        private void PB_PLlogo_Click(object sender, EventArgs e)
        {

        }

        private void PartylistID_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
