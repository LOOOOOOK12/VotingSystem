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
    public partial class FRM_ManageCandidates : Form
    {
        public FRM_ManageCandidates()
        {
            InitializeComponent();
        }
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel2.Controls.Clear();

            ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();

            DataTable dt = objBLLC.GetItems();


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UC_Candidate[] listitems = new UC_Candidate[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new UC_Candidate();



                            MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                            listitems[i].CandidatePic = new Bitmap(ms);

                            listitems[i].Candidate_ID = row["Candidate_ID"].ToString();
                            listitems[i].Firstname = row["Firstname"].ToString();
                            listitems[i].Middlename = row["Middlename"].ToString();
                            listitems[i].Lastname = row["Lastname"].ToString();
                            listitems[i].Course = row["Course"].ToString();
                            listitems[i].Position = row["Position"].ToString();
                            listitems[i].Partylist = row["Partylist"].ToString();




                            flowLayoutPanel2.Controls.Add(listitems[i]);

                            listitems[i].Click += new System.EventHandler(this.Refresh_btn_Click);

                        }
                    }
                }
            }
        }




        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartylist_btn_Click(object sender, EventArgs e)
        {
            FRM_AddCandidatesBox FRM_ACandidates = new FRM_AddCandidatesBox();
            FRM_ACandidates.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            string searchCandidate = TXTBX_SearchCandidates.Text.Trim();


            ClassBLL_Cadidates objBLLCandidates = new ClassBLL_Cadidates();
            DataTable searchResult = objBLLCandidates.SearchItems(searchCandidate);

            flowLayoutPanel2.Controls.Clear();

            if (searchResult != null && searchResult.Rows.Count > 0)
            {
                foreach (DataRow row in searchResult.Rows)
                {
                    UC_Candidate CandidateItem = new UC_Candidate();

                    MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                    CandidateItem.CandidatePic = new Bitmap(ms);

                    CandidateItem.Candidate_ID = row["Candidate_ID"].ToString();
                    CandidateItem.Firstname = row["Firstname"].ToString();
                    CandidateItem.Middlename = row["Middlename"].ToString();
                    CandidateItem.Lastname = row["Lastname"].ToString();
                    CandidateItem.Course = row["Course"].ToString();
                    CandidateItem.Position = row["Position"].ToString();
                    CandidateItem.Partylist = row["Partylist"].ToString();


                    flowLayoutPanel2.Controls.Add(CandidateItem);

                    CandidateItem.Click += new System.EventHandler(this.Refresh_btn_Click);
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

