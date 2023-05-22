﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VotingSystem.BLL;

namespace VotingSystem
{
    public partial class FRM_AddCandidatesBox : Form
    {
        public FRM_AddCandidatesBox()
        {
            InitializeComponent();
            fillcombobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_AddCandidates_Load(object sender, EventArgs e)
        {

        }

        private void BTN_InsertPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                PB_Candidate.Image = image;
            }
        }

        private void BTN_AddCandidate_Click(object sender, EventArgs e)
        {
            ClassBLL_Cadidates objBLLC = new ClassBLL_Cadidates();

            if (objBLLC.SaveItems(TXTBX_Firstname.Text, TXTBX_Middlename.Text, TXTBX_Lastname.Text,CB_Course.Text, CB_Position.Text,PB_Candidate.Image))
            {
                MessageBox.Show("Record Successful!");
            }
            else
            {
                MessageBox.Show("Record Failed!");
            }
        }

        public void fillcombobox() 
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
            string sql = "SELECT * FROM Partylist";
            SqlCommand cmd = new SqlCommand(sql, con); ;
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while(myreader.Read()) 
                {
                    string sname = myreader.GetString(1);
                    CB_Partylist.Items.Add(sname);

                }
                 
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CB_Partylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
