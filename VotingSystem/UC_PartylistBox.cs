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
    public partial class UC_Partylist : UserControl
    {
        public UC_Partylist()
        {
            InitializeComponent();
        }

        public string PartylistID
        {
            get { return PartylistID_lbl.Text; }
            set { PartylistID_lbl.Text = value; }
        }

        public string PartylistName
        {
            get { return PartylistName_lbl.Text; }
            set { PartylistName_lbl.Text = value; }
        }

        public Image PartylistLogo
        {
            get { return PB_PLlogo.Image; }
            set { PB_PLlogo.Image = value; }
        }

        private void RetrievePartylistData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT PartylistID, PartylistName, Logo FROM Partylist";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int partylistID = reader.GetInt32(0);
                string partylistName = reader.GetString(1);
                byte[] logoData = (byte[])reader["Logo"];
                Image partylistLogo = ByteArrayToImage(logoData);

                // Create an instance of the user control form
                UC_Partylist partylistUserControl = new UC_Partylist();

                // Set the property values in the user control form
                partylistUserControl.PartylistID = partylistID.ToString();
                partylistUserControl.PartylistName = partylistName;
                partylistUserControl.PartylistLogo = partylistLogo;

                // Add the user control form to your desired container (e.g., panel)
                PartylistID_lbl.Controls.Add(partylistUserControl);
                PartylistID_lbl.Controls.Add(partylistUserControl);
                PartylistID_lbl.Controls.Add(partylistUserControl);
            }

            con.Close();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void UC_Partylist_Load(object sender, EventArgs e)
        {
            RetrievePartylistData();
        }
    }
}
