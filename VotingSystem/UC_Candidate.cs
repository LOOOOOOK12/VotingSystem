using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;

namespace VotingSystem
{
    public partial class UC_Candidate : UserControl
    {
        private FlowLayoutPanel flowLayoutPanel2;

        public UC_Candidate()
        {
            InitializeComponent();

        }

        public string Candidate_ID
        {
            get { return LBL_Candidate_ID.Text; }
            set { LBL_Candidate_ID.Text = value; }
        }

        public string Election
        {
            get { return LBL_Election.Text; }
            set { LBL_Election.Text = value; }
        }

        public string Name
        {
            get { return LBL_Name.Text; }
            set { LBL_Name.Text = value; }
        }

       
        public string Course
        {
            get { return LBL_Course.Text; }
            set { LBL_Course.Text = value; }
        }

        public string Partylist
        {
            get { return LBL_Partylist.Text; }
            set { LBL_Partylist.Text = value; }
        }

        public string Position
        {
            get { return LBL_Position.Text; }
            set { LBL_Position.Text = value; }
        }

        public Image CandidatePic
        {
            get { return PB_Clogo.Image; }
            set { PB_Clogo.Image = value; }
        }

        private void DeleteDataFromDatabase()
        {
            // Establish the database connection and execute the delete operation
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM Candidates WHERE Candidate_ID = @Candidate_ID"; // Update with appropriate table and column names
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Candidate_ID", Candidate_ID);
                command.ExecuteNonQuery();
            }
        }


        private void UC_Candidate_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
                if (flowLayoutPanel2 != null)
                {
                    // Remove the user control from the FlowLayoutPanel
                    flowLayoutPanel2.Controls.Remove(this);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FRM_UpdateCandidates updateCandidates = new FRM_UpdateCandidates();
            updateCandidates.ShowDialog();
        }

        private void LBL_Candidate_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
