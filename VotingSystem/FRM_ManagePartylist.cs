using System;
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

namespace VotingSystem
{
    public partial class FRM_Partylist : Form
    {
        public FRM_Partylist()
        {
            InitializeComponent();
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
            //RefreshPartylistData();
        }
        private void RefreshPartylistData()
        {
            // Clear existing controls from the FlowLayoutPanel
            //flowLayoutPanel1.Controls.Clear();
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Partylist_ID, PartylistName, PartylistLogo FROM Partylist";
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    int partylistID = reader.GetInt32(0);
            //    string partylistName = reader.GetString(1);
            //    byte[] logoData = (byte[])reader["PartylistLogo"];
            //    Image partylistLogo = ByteArrayToImage(logoData);

            //     Create an instance of the user control form
            //    UC_Partylist partylistUserControl = new UC_Partylist();

            //     Set the property values in the user control form
            //    partylistUserControl.PartylistID = partylistID.ToString();
            //    partylistUserControl.PartylistName = partylistName;
            //    partylistUserControl.PartylistLogo = partylistLogo;

            //     Add the user control form to the FlowLayoutPanel
            //    flowLayoutPanel1.Controls.Add(partylistUserControl);
            //}

            //con.Close();
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
