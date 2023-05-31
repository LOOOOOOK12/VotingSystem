using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace VotingSystem.DAL
{
    internal class ClassDAL_Candidates
    {

        //ADD ITEMS
        public bool AddItemsToTable(string name, string Course, string Position, Image CandidatePic, string partylist)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            try
            {
                // Convert the Bitmap to a byte array
                byte[] candidatePicBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    CandidatePic.Save(ms, CandidatePic.RawFormat);
                    candidatePicBytes = ms.ToArray();
                }

                // Retrieve the Partylist_ID based on the selected PartylistName
                string partylistQuery = "SELECT Partylist_ID FROM Partylist WHERE PartylistName = @PartylistName";
                int partylistId;

                using (SqlCommand partylistCommand = new SqlCommand(partylistQuery, con.connect))
                {
                    partylistCommand.Parameters.AddWithValue("@PartylistName", partylist.Trim());
                    partylistId = (int)partylistCommand.ExecuteScalar();
                }

                // Retrieve the chosen PartylistName
                string chosenPartylistName;
                using (SqlCommand partylistNameCommand = new SqlCommand("SELECT PartylistName FROM Partylist WHERE Partylist_ID = @PartylistID", con.connect))
                {
                    partylistNameCommand.Parameters.AddWithValue("@PartylistID", partylistId);
                    chosenPartylistName = (string)partylistNameCommand.ExecuteScalar();
                }

                // Insert data into the Candidates table
                string insertQuery = "INSERT INTO Candidates (Name, Course, Position, CandidatePic, Partylist_ID) " +
                                     "VALUES (@Name, @Course, @Position, @CandidatePic, @PartylistID)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name.Trim());
                    cmd.Parameters.AddWithValue("@Course", Course.Trim());
                    cmd.Parameters.AddWithValue("@Position", Position.Trim());
                    cmd.Parameters.AddWithValue("@CandidatePic", candidatePicBytes);
                    cmd.Parameters.AddWithValue("@PartylistID", partylistId);

                    cmd.ExecuteNonQuery();
                }

                // Display the chosen partylist name
                MessageBox.Show($"Candidate added successfully with Partylist: {chosenPartylistName}", "Information", MessageBoxButtons.OK);

                return true;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.connect.Close();
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

            string query = "SELECT * FROM Candidates";
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

            string query = "SELECT * FROM Candidates WHERE Name LIKE @Search OR Partylist LIKE @Search OR Position LIKE @Search";
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
        public bool UpdateItemInTable(int candidateID, string name, string course, string position, Image candidatePic, string partylist)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "UPDATE Candidates SET Name = @Name, Course = @Course, Position = @Position, CandidatePic = @CandidatePic, Partylist = @Partylist  WHERE Candidate_ID = @Candidate_ID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Candidate_ID", candidateID);
                    cmd.Parameters.AddWithValue("@Name", name.Trim());
                    cmd.Parameters.AddWithValue("@Course", course.Trim());
                    cmd.Parameters.AddWithValue("@Position", position.Trim());
                    cmd.Parameters.AddWithValue("@Partylist", partylist.Trim());



                    // Converting image to binary to store in the database
                    MemoryStream ms = new MemoryStream();
                    candidatePic.Save(ms, candidatePic.RawFormat);
                    // Set the binary format image to the parameter
                    cmd.Parameters.AddWithValue("@CandidatePic", ms.ToArray());

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
