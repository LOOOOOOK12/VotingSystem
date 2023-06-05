﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FRM_UpdateCandidates : Form
    {
        public FRM_UpdateCandidates()
        {
            InitializeComponent();
            fillcombobox();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTN_AddCandidate_Click(object sender, EventArgs e)
        {
            ClassBLL_Cadidates objC = new ClassBLL_Cadidates();

            int candidateID; // Variable to store the Partylist ID

            if (int.TryParse(TXTBX_CandidateID.Text, out candidateID))
            {
                if (objC.UpdateItems(candidateID, TXTBX_Name.Text,  CB_Course.Text, CB_Position.Text, PB_Candidate.Image,CB_Partylist.Text))
                {
                    MessageBox.Show("Record Successful!");
                }
                else
                {
                    MessageBox.Show("Record Failed!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Partylist ID!");
            }



        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
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
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    CB_Partylist.Items.Add(sname);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FRM_UpdateCandidates_Load(object sender, EventArgs e)
        {

        }
    }
}