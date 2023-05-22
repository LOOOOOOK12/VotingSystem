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

namespace VotingSystem
{
    public partial class FRM_Voters : Form
    {


        public FRM_Voters()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_Voters_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(con))
            { 
                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Voters ", connection);
                DataTable table =  new DataTable();
                sqlData.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_SearchCandidates_Click(object sender, EventArgs e)
        {

        }
    }
}
