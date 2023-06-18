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
using VotingSystem.VOTERS_UserControls;

namespace VotingSystem
{
    public partial class UC_Vote : UserControl
    {
        public UC_Vote()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            FL_Vote.Controls.Clear();

            ClassBLL_Election objbllElection = new ClassBLL_Election();

            DataTable dt = objbllElection.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UC_ElectionsView[] listitems = new UC_ElectionsView[dt.Rows.Count];


                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new UC_ElectionsView();


                            listitems[i].ElectionID = row["Election_ID"].ToString();
                            listitems[i].ViewElection = row["ElectionTitle"].ToString();
                           


                            FL_Vote.Controls.Add(listitems[i]);

                            listitems[i].Click += new System.EventHandler(this.UC_Vote_Load);

                        }
                    }
                }
            }
        }


        //private void GenerateDynamicUserControl()
        //{
        //    FL_Vote.Controls.Clear();

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


        //                    FL_Vote.Controls.Add(listitems[i]);

        //                    listitems[i].Click += new System.EventHandler(this.UC_Vote_Load);

        //                }
        //            }
        //        }
        //    }
        //}

        private void UC_Vote_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}
