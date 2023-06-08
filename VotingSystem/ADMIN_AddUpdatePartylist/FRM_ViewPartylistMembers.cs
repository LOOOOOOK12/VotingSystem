﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.ADMIN_AddUpdateElection;
using VotingSystem.BLL;

namespace VotingSystem.ADMIN_AddUpdatePartylist
{
    public partial class FRM_ViewPartylistMembers : Form
    {
        public FRM_ViewPartylistMembers()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            FL_Members.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetItemsMembers();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    UC_PartylistMembers partylistMembers = new UC_PartylistMembers();

                    MemoryStream ms = new MemoryStream((byte[])row["CandidatePic"]);
                    partylistMembers.MemberPicture = new Bitmap(ms);

                    partylistMembers.PLID = row["Partylist_ID"].ToString();
                    partylistMembers.Name = row["Name"].ToString();
                    partylistMembers.Position = row["Position"].ToString();

                  
                    FL_Members.Controls.Add(partylistMembers);

                    partylistMembers.Click += new System.EventHandler(this.FRM_ViewPartylistMembers_Load);
                }
            }
            else
            {
                // Show a message or handle no data available
                MessageBox.Show("No data available.");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_ViewPartylistMembers_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}