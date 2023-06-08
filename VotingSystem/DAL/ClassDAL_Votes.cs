using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VotingSystem.DAL
{
    internal class ClassDAL_Votes
    {
        private string connectionString = @"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"; // Replace with your actual connection string

        public bool AddItemsToTable(int voteID, string name, string partylistName, string position, string electionTitle, Image candidatePic, Image partylistPic)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the foreign key ID from Candidates table
                int candidateID;
                string selectCandidateIDQuery = "SELECT Candidate_ID FROM Candidates WHERE Name = @Name AND Position = @Position;";
                using (SqlCommand selectCandidateIDCommand = new SqlCommand(selectCandidateIDQuery, connection))
                {
                    selectCandidateIDCommand.Parameters.AddWithValue("@Name", name);
                    selectCandidateIDCommand.Parameters.AddWithValue("@Position", position);
                    candidateID = (int)selectCandidateIDCommand.ExecuteScalar();
                }

                // Get the foreign key ID from Elections table
                int electionID;
                string selectElectionIDQuery = "SELECT Election_ID FROM Election WHERE ElectionTitle = @ElectionTitle;";
                using (SqlCommand selectElectionIDCommand = new SqlCommand(selectElectionIDQuery, connection))
                {
                    selectElectionIDCommand.Parameters.AddWithValue("@ElectionTitle", electionTitle);
                    electionID = (int)selectElectionIDCommand.ExecuteScalar();
                }

                // Get the foreign key ID from Partylist table
                int partylistID;
                string selectPartylistIDQuery = "SELECT Partylist_ID FROM Partylist WHERE PartylistName = @PartylistName;";
                using (SqlCommand selectPartylistIDCommand = new SqlCommand(selectPartylistIDQuery, connection))
                {
                    selectPartylistIDCommand.Parameters.AddWithValue("@PartylistName", partylistName);
                    partylistID = (int)selectPartylistIDCommand.ExecuteScalar();
                }

                // Insert into Votes table
                string insertVoteQuery = "INSERT INTO Votes (Vote_ID, Candidate_ID, Election_ID, Partylist_ID) VALUES (@Vote_ID, @Candidate_ID, @Election_ID, @Partylist_ID);";
                using (SqlCommand insertVoteCommand = new SqlCommand(insertVoteQuery, connection))
                {
                    insertVoteCommand.Parameters.AddWithValue("@Vote_ID", voteID);
                    insertVoteCommand.Parameters.AddWithValue("@Candidate_ID", candidateID);
                    insertVoteCommand.Parameters.AddWithValue("@Election_ID", electionID);
                    insertVoteCommand.Parameters.AddWithValue("@Partylist_ID", partylistID);
                    insertVoteCommand.ExecuteNonQuery();
                }


                return true;
            }
        }

        public DataTable ReadItemsTable()
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();

        string query = "SELECT C.Name AS Name, C.Position AS Position, P.PartylistName AS PartylistName, P.PartylistLogo AS PartylistLogo, C.CandidatePic AS CandidatePic " +
                       "FROM Votes V " +
                       "INNER JOIN Candidates C ON V.Candidate_ID = C.Candidate_ID " +
                       "INNER JOIN Election E ON V.Election_ID = E.Election_ID " +
                       "INNER JOIN Partylist P ON V.Partylist_ID = P.Partylist_ID;";
        SqlCommand cmd = new SqlCommand(query, connection);
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

    ////PANG SEARCH
    //public DataTable SearchItemsTable(string search)
    //    {
    //        Connection con = new Connection();
    //        if (ConnectionState.Closed == con.connect.State)
    //        {
    //            con.connect.Open();
    //        }

    //        string query = "SELECT * FROM Candidates WHERE Firstname LIKE @Search OR Lastname LIKE @Search OR Middlename LIKE @Search OR Partylist LIKE @Search OR Position LIKE @Search";
    //        SqlCommand cmd = new SqlCommand(query, con.connect);
    //        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

    //        try
    //        {
    //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
    //            {
    //                DataTable dt = new DataTable();
    //                sda.Fill(dt);
    //                return dt;
    //            }
    //        }
    //        catch
    //        {
    //            throw;
    //        }
    //    }

    //public bool UpdateItemInTable(int candidateID, string firstname, string middlename, string lastname, string course, string position, Image candidatePic, string partylist)
    //{
    //    Connection con = new Connection();
    //    if (ConnectionState.Closed == con.connect.State)
    //    {
    //        con.connect.Open();
    //    }

    //    string query = "UPDATE Candidates SET Firstname = @Firstname, Middlename = @Middlename, Lastname = @Lastname, Course = @Course, Position = @Position, CandidatePic = @CandidatePic, Partylist = @Partylist  WHERE Candidate_ID = @Candidate_ID";

    //    try
    //    {
    //        using (SqlCommand cmd = new SqlCommand(query, con.connect))
    //        {
    //            cmd.Parameters.AddWithValue("@Candidate_ID", candidateID);
    //            cmd.Parameters.AddWithValue("@Firstname", firstname.Trim());
    //            cmd.Parameters.AddWithValue("@Middlename", middlename.Trim());
    //            cmd.Parameters.AddWithValue("@Lastname", lastname.Trim());
    //            cmd.Parameters.AddWithValue("@Course", course.Trim());
    //            cmd.Parameters.AddWithValue("@Position", position.Trim());
    //            cmd.Parameters.AddWithValue("@Partylist", partylist.Trim());



    //            // Converting image to binary to store in the database
    //            MemoryStream ms = new MemoryStream();
    //            candidatePic.Save(ms, candidatePic.RawFormat);
    //            // Set the binary format image to the parameter
    //            cmd.Parameters.AddWithValue("@CandidatePic", ms.ToArray());

    //            cmd.ExecuteNonQuery();
    //        }
    //        return true;
    //    }
    //    catch
    //    {
    //        throw;
    //    }
    //}
}

