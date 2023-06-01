using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
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
            //SqlDataAdapter da = new SqlDataAdapter("SELECT Candidates.Partylist_ID,Partylist.PartylistName FROM Candidates INNER JOIN Partylist on Candidates.Partylist_ID = Partylist.Partylist_ID", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //CB_Partylist.DataSource = dt;
            //CB_Partylist.DisplayMember = "PartylistName";
            //CB_Partylist.ValueMember = "Partylist_ID";

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

            if (objBLLC.SaveItems(TXTBX_Name.Text, CB_Course.Text, CB_Position.Text,PB_Candidate.Image, CB_Partylist.Text))
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

        private void CB_Partylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
