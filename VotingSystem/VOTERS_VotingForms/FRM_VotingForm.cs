using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.BLL;

namespace VotingSystem.VOTERS_VotingForms
{
    public partial class FRM_VotingForm : Form
    {
        public FRM_VotingForm()
        {
            InitializeComponent();
        }

        public void displayfieldPartylistMember(string electionTitle)
        {
            label2.Text = electionTitle;
        }

        //private void GenerateDynamicUserControl()
        //{


        //    FL_Voting.Controls.Clear();

        //    ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();


        //    DataTable dt = objBLLC.GetItemsVoters();


        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            UC_VotingBtn[] listitems = new UC_VotingBtn[dt.Rows.Count];


        //            for (int i = 0; i < 1; i++)
        //            {
        //                foreach (DataRow row in dt.Rows)
        //                {
        //                    listitems[i] = new UC_VotingBtn();

        //                    MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
        //                    MemoryStream ms2 = new MemoryStream((byte[])row["PartylistLogo"]);

        //                    listitems[i].PartylistLogo = new Bitmap(ms2);
        //                    listitems[i].CandidatePicture = new Bitmap(ms);
        //                    listitems[i].Name = row["Name"].ToString();
        //                    listitems[i].PosName = row["Position"].ToString();
        //                    listitems[i].ElectionTitle = row["ElectionTitle"].ToString();
        //                    listitems[i].Pname = row["PartylistName"].ToString();


        //                    FL_Voting.Controls.Add(listitems[i]);

        //                    listitems[i].Click += new System.EventHandler(this.FRM_VotingForm_Load);

        //                }
        //            }
        //        }
        //    }
        //}

        private void GenerateDynamicUserControlSearch()
        {

            string searchTermsParticipants = label2.Text;

            FL_Voting.Controls.Clear();

            ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();


            DataTable dt = objBLLC.SearchItemsElectionP(searchTermsParticipants);


            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UC_VotingBtn[] listitems = new UC_VotingBtn[dt.Rows.Count];


                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new UC_VotingBtn();

                            MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                            MemoryStream ms2 = new MemoryStream((byte[])row["PartylistLogo"]);

                            listitems[i].PartylistLogo = new Bitmap(ms2);
                            listitems[i].CandidatePicture = new Bitmap(ms);
                            listitems[i].CandidateName = row["Name"].ToString();
                            listitems[i].PosName = row["Position"].ToString();
                            listitems[i].ElectionTitle = row["ElectionTitle"].ToString();
                            listitems[i].Pname = row["PartylistName"].ToString();


                            FL_Voting.Controls.Add(listitems[i]);

                            listitems[i].Click += new System.EventHandler(this.FRM_VotingForm_Load);

                        }
                    }
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FRM_VotingForm_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControlSearch();
            //GenerateDynamicUserControl();
        }
    }
}
