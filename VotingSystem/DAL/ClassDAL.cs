using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace VotingSystem.DAL
{

    //CRUD
    internal class ClassDAL
    {


       //PANG ADD
        public bool AddItemsToTable(Image img, string Partylistname) 
        { 
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connect.State) 
            {
                con.connect.Open();
            }

            string query = "INSERT INTO Partylist(PartylistName,PartylistLogo) VALUES (@PartylistName,@PartylistLogo)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@PartylistName", Partylistname.Trim());

                    //converting image to binary to store to database
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    // set to binary format image to parameter
                    cmd.Parameters.AddWithValue("@PartylistLogo", ms.ToArray());

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
            if(ConnectionState.Closed == con.connect.State) 
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM Partylist";
            SqlCommand cmd = new SqlCommand(query,con.connect);
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
        public DataTable SearchItemsTable(string searchTerm)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM Partylist WHERE PartylistName LIKE @SearchTerm";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

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
    }
}
