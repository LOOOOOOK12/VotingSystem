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

namespace VotingSystem
{
    public partial class FRM_Election : Form
    {
        public FRM_Election()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel3.Controls.Clear();

            ClassBLL_Election objbll = new ClassBLL_Election();

            DataTable dt = objbll.GetItems();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    UC_ElectionTitle ElectionItem = new UC_ElectionTitle();



                    ElectionItem.ElectionID = row["Election_ID"].ToString();
                    ElectionItem.ElectionTitle = row["ElectionTitle"].ToString();
                    ElectionItem.Description = row["Description"].ToString();
                    flowLayoutPanel3.Controls.Add(ElectionItem);

                    ElectionItem.Click += new System.EventHandler(this.BTN_Refresh_Click);
                }
            }
            else
            {
                // Show a message or handle no data available
                MessageBox.Show("No data available.");
            }
        }


        private void BTN_SearchCandidates_Click(object sender, EventArgs e)
        {
            string SearchElection = TXTBX_SearchElection.Text.Trim();


            ClassBLL_Election objbllEelction = new ClassBLL_Election();
            DataTable searchResults = objbllEelction.SearchItems(SearchElection);

            flowLayoutPanel3.Controls.Clear(); // Clear existing controls

            if (searchResults != null && searchResults.Rows.Count > 0)
            {
                foreach (DataRow row in searchResults.Rows)
                {
                    UC_ElectionTitle electionItem = new UC_ElectionTitle();



                    electionItem.ElectionID = row["Election_ID"].ToString();
                    electionItem.ElectionTitle = row["ElectionTitle"].ToString();

                    flowLayoutPanel3.Controls.Add(electionItem);

                    electionItem.Click += new System.EventHandler(this.BTN_Refresh_Click);
                }
            }
            else
            {
                // Show a message or handle no search results
                MessageBox.Show("No search results found.");
            }
        }

        private void BTN_AddElection_Click(object sender, EventArgs e)
        {
            FRM_AddElection AddElection = new FRM_AddElection();
            AddElection.ShowDialog();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void TXTBX_SearchElection_TextChanged(object sender, EventArgs e)
        {
            string SearchElection = TXTBX_SearchElection.Text.Trim();


            ClassBLL_Election objbllEelction = new ClassBLL_Election();
            DataTable searchResults = objbllEelction.SearchItems(SearchElection);

            flowLayoutPanel3.Controls.Clear(); // Clear existing controls

            if (searchResults != null && searchResults.Rows.Count > 0)
            {
                foreach (DataRow row in searchResults.Rows)
                {
                    UC_ElectionTitle electionItem = new UC_ElectionTitle();



                    electionItem.ElectionID = row["Election_ID"].ToString();
                    electionItem.ElectionTitle = row["ElectionTitle"].ToString();

                    flowLayoutPanel3.Controls.Add(electionItem);

                    electionItem.Click += new System.EventHandler(this.BTN_Refresh_Click);
                }
            }
            else
            {
                // Show a message or handle no search results
                MessageBox.Show("No search results found.");
            }
        }
    }
}
