using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;
using System.Data.SqlClient;

namespace VotingSystem
{
    public partial class UC_ElectionTitle : UserControl
    {
        private FlowLayoutPanel flowLayoutPanel3;

        public UC_ElectionTitle()
        {
            InitializeComponent();
            flowLayoutPanel3 = new FlowLayoutPanel();
        }

        public string ElectionID
        {
            get { return LBL_ElectionID.Text; }
            set { LBL_ElectionID.Text = value; }
        }

        public string ElectionTitle
        {
            get { return LBL_ElectionTitle.Text; }
            set { LBL_ElectionTitle.Text = value; }
        }

        public string Description
        {
            get { return LBL_Description.Text; }
            set { LBL_Description.Text = value; }
        }

        private void LBL_ElectionTitle_Click(object sender, EventArgs e)
        {

        }

        private void UC_ElectionTitle_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Delete data from the database
                DeleteDataFromDatabase();

                // Check if flowLayoutPanel1 is not null before removing the user control
                if (flowLayoutPanel3 != null)
                {
                    // Remove the user control from the FlowLayoutPanel
                    flowLayoutPanel3.Controls.Remove(this);
                }
            }
        }

        //
        private void DeleteDataFromDatabase()
        {
            // Establish the database connection and execute the delete operation
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM Election WHERE Election_ID = @Election_ID"; // Update with appropriate table and column names
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Election_ID", ElectionID);
                command.ExecuteNonQuery();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FRM_UpdateElection updateElection = new FRM_UpdateElection();
            updateElection.ShowDialog();
        }
    }
}
