﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.BLL;

namespace VotingSystem
{
    public partial class FRM_Partylist : Form
    {
        public FRM_Partylist()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl() 
        {
            flowLayoutPanel1.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetItems();


            if(dt != null ) 
            {
                if (dt.Rows.Count > 0)
                {
                    UC_Partylist[] listitems = new UC_Partylist[dt.Rows.Count];

                    for (int i = 0; i< 1; i++) 
                    {
                        foreach(DataRow row in dt.Rows) 
                        {
                            listitems[i] = new UC_Partylist();

                           
                                MemoryStream ms = new MemoryStream((byte[])row["PartylistLogo"]);
                                listitems[i].PartylistLogo = new Bitmap(ms);
                            

                            listitems[i].PartylistID = row["Partylist_ID"].ToString();
                            listitems[i].PartylistName = row["PartylistName"].ToString();

                            flowLayoutPanel1.Controls.Add(listitems[i]);

                            listitems[i].Click += new System.EventHandler(this.Refresh_btn_Click);

                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FRM_Partylist_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartylist_btn_Click(object sender, EventArgs e)
        {
            AddingPartyList_FRM AddPL = new AddingPartyList_FRM();
            AddPL.ShowDialog();
        }

        private void listViewPartylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();     
        }
        
      
    }
}
