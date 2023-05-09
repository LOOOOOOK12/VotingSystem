using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace VotingSystem
{
    public partial class AddingPartyList_FRM : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
        
        public AddingPartyList_FRM()
        {
            InitializeComponent();
            
        }
        
        private void Partylist_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingPartyList_FRM_Load(object sender, EventArgs e)
        {

        }

        private void addPL_btn_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Partylist VALUES('" + AddPartylist_txtbx.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Succcessful");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
