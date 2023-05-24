using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace VotingSystem.DAL
{
    internal class ClassDAL_Election
    {

        //ADD ITEMS
        public bool AddItemsToTable(string electionTitle, string description)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "INSERT INTO Election(ElectionTitle,Description) VALUES (@ElectionTitle,@Description)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@ElectionTitle", electionTitle.Trim());
                    cmd.Parameters.AddWithValue("@Description", description.Trim());                   
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        //PANG VIEW
        public DataTable ReadItemsTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM Election";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        //PANG SEARCH
        public DataTable SearchItemsTable(string search)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM Election WHERE ElectionTitle LIKE @Search";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        //PANG UPDATE
        public bool UpdateItemInTable(int electionID, string electionTitle, string descriptions)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "UPDATE Election SET ElectionTitle = @ElectionTitle, Description = @Description WHERE Election_ID = @Election_ID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Election_ID", electionID);
                    cmd.Parameters.AddWithValue("@ElectionTitle", electionTitle.Trim());
                    cmd.Parameters.AddWithValue("@Description", descriptions.Trim());            
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

    }
}
