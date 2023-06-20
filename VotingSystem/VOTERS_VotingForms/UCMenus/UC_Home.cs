using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class UC_Home : UserControl
    {
       

        public UC_Home()
        {
            InitializeComponent();
        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            SqlCommand cmdd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            string query = "SELECT COUNT(votersID) FROM Voters";

            string votedQuery = "SELECT COUNT (Vote_ID) FROM Votes";

            try
            {
                cmd = new SqlCommand(query, con);
                cmdd = new SqlCommand(votedQuery,con);
                Int32 rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                Int32 votes = Convert.ToInt32(cmdd.ExecuteScalar());
                cmdd.Dispose();
                cmd.Dispose();
                con.Close();

                label4.Text = rowCount.ToString();
                label5.Text = votes.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }

       
    }
}
