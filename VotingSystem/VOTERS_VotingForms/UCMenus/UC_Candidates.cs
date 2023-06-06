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
        private void GenerateDynamicUserControl()
        {
            FL_Candidates.Controls.Clear();

            ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();
            

            DataTable dt = objBLLC.GetItemsVoters();
           

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UC_Participants[] listitems = new UC_Participants[dt.Rows.Count];
                    

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listitems[i] = new UC_Participants();

                            MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                            MemoryStream ms2 = new MemoryStream((byte[])row["PartylistLogo"]);

                            listitems[i].PartylistLogo = new Bitmap(ms2);
                            listitems[i].CandidatePicture = new Bitmap(ms);
                            listitems[i].Name = row["Name"].ToString();
                            listitems[i].Postition = row["Position"].ToString();
                            listitems[i].ElectionTitle = row["ElectionTitle"].ToString();
                            listitems[i].PartylistName = row["PartylistName"].ToString();
                            

                            FL_Candidates.Controls.Add(listitems[i]);

                            listitems[i].Click += new System.EventHandler(this.UC_Candidates_Load);

                        }
                    }
                }
            }
        }
        private void UC_Candidates_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }



    }
}
