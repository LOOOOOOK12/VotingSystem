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
        public bool AddItemsToTable(string name, string Course, string Position, Image CandidatePic, string partylist, string election)
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

                // Retrieve the Election_ID from the Elections table
                int electionId;
                using (SqlCommand electionCommand = new SqlCommand("SELECT Election_ID FROM Election WHERE ElectionTitle = @ElectionTitle", con.connect))
                {
                    electionCommand.Parameters.AddWithValue("@ElectionTitle", election.Trim());
                    electionId = (int)electionCommand.ExecuteScalar();
                }

                // Insert data into the Candidates table
                string insertQuery = "INSERT INTO Candidates (Name, Course, Position, CandidatePic, Partylist_ID, Election_ID) " +
                                     "VALUES (@Name, @Course, @Position, @CandidatePic, @PartylistID, @ElectionID)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name.Trim());
                    cmd.Parameters.AddWithValue("@Course", Course.Trim());
                    cmd.Parameters.AddWithValue("@Position", Position.Trim());
                    cmd.Parameters.AddWithValue("@CandidatePic", candidatePicBytes);
                    cmd.Parameters.AddWithValue("@PartylistID", partylistId);
                    cmd.Parameters.AddWithValue("@ElectionID", electionId);

                    cmd.ExecuteNonQuery();
                }

                // Display the chosen partylist name
                MessageBox.Show($"Candidate added successfully with Partylist: {partylist}", "Information", MessageBoxButtons.OK);

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

            string query = "SELECT C.Name AS Name, C.Position,C.Course AS Course, C.Candidate_ID AS Candidate_ID, P.PartylistName AS PartylistName, P.PartylistLogo AS PartylistLogo, C.CandidatePic AS CandidatePic, E.ElectionTitle AS ElectionTitle " +
                       "FROM Candidates C " +
                       "INNER JOIN Partylist P ON C.Partylist_ID = P.Partylist_ID " +
                       "INNER JOIN Election E ON C.Election_ID = E.Election_ID;";
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

        //PANG VIEW SA VOTERS NA TABLE
        public DataTable ReadItemsTableVoters()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT C.Name AS Name, C.Position, P.PartylistName AS PartylistName, P.PartylistLogo AS PartylistLogo, C.CandidatePic AS CandidatePic, E.ElectionTitle AS ElectionTitle " +
                       "FROM Candidates C " +
                       "INNER JOIN Partylist P ON C.Partylist_ID = P.Partylist_ID " +
                       "INNER JOIN Election E ON C.Election_ID = E.Election_ID;";
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

            string query =  "SELECT C.Candidate_ID AS Candidate_ID, C.CandidatePic AS CandidatePic, C.Name AS Name, C.Position AS Position,C.Course AS Course, P.PartylistName AS PartylistName, E.ElectionTitle AS ElectionTitle " +
               "FROM Candidates C " +
               "INNER JOIN Partylist P ON C.Partylist_ID = P.Partylist_ID " +
               "INNER JOIN Election E ON C.Election_ID = E.Election_ID " +
               "WHERE C.Name LIKE @Search OR P.PartylistName LIKE @Search OR C.Position LIKE @Search OR E.ElectionTitle LIKE @Search";

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
        public bool UpdateItemInTable(int candidateID, string name, string course, string position, Image candidatePic, string partylistname, string electiontitle)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "UPDATE Candidates " +
                   "SET Name = @Name, Course = @Course, Position = @Position, CandidatePic = @CandidatePic, " +
                   "    Partylist_ID = (SELECT Partylist_ID FROM Partylist WHERE PartylistName = @PartylistName), " +
                   "    Election_ID = (SELECT Election_ID FROM Election WHERE ElectionTitle = @ElectionTitle) " +
                   "WHERE Candidate_ID = @Candidate_ID";


            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Candidate_ID", candidateID);
                    cmd.Parameters.AddWithValue("@Name", name.Trim());
                    cmd.Parameters.AddWithValue("@Course", course.Trim());
                    cmd.Parameters.AddWithValue("@Position", position.Trim());
                    cmd.Parameters.AddWithValue("@PartylistName", partylistname.Trim());
                    cmd.Parameters.AddWithValue("@ElectionTitle", electiontitle.Trim());



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
