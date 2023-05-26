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
    public partial class UC_Candidates : UserControl
    {
        public UC_Candidates()
        {
            InitializeComponent();
        }
        //private void GenerateDynamicUserControl()
        //{
        //    FL_Candidates.Controls.Clear();

        //    ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();
        //    ClassBLL objBLLPartylist = new ClassBLL();

        //    DataTable dt = objBLLC.GetItems();


        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            UC_Participants[] listitems = new UC_Participants[dt.Rows.Count];


        //            for (int i = 0; i < 1; i++)
        //            {
        //                foreach (DataRow row in dt.Rows)
        //                {
        //                    listitems[i] = new UC_Participants();



        //                    //MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
        //                    //listitems[i].CandidatePic = new Bitmap(ms);

        //                    //listitems[i].Candidate_ID = row["Candidate_ID"].ToString();
        //                    listitems[i].CandidateName = row["Firstname"].ToString();
        //                    listitems[i].CandidateName = row["Middlename"].ToString();
        //                    listitems[i].CandidateName = row["Lastname"].ToString();
        //                    listitems[i].Course = row["Course"].ToString();
        //                    listitems[i].Position = row["Position"].ToString();
        //                    listitems[i].Partylist = row["Partylist"].ToString();

        //                    FL_Candidates.Controls.Add(listitems[i]);

        //                    listitems[i].Click += new System.EventHandler(this.UC_Candidates_Load);

        //                }
        //            }
        //        }
        //    }
        //}
        private void UC_Candidates_Load(object sender, EventArgs e)
        {

        }



    }
}
