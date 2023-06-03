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

        public bool AddItemsToTable(int voteID, string name, string partylistName, string position, Image candidatePic, Image partylistPic)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert vote into Votes table
                string insertVoteQuery = "INSERT INTO Votes (VoteID) VALUES (@VoteID);";
                using (SqlCommand insertVoteCommand = new SqlCommand(insertVoteQuery, connection))
                {
                    insertVoteCommand.Parameters.AddWithValue("@VoteID", voteID);
                    insertVoteCommand.ExecuteNonQuery();
                }

                // Get the foreign key ID from Candidates table
                int candidateID;
                string selectCandidateIDQuery = "SELECT CandidateID FROM Candidates WHERE Name = @Name AND Position = @Position;";
                using (SqlCommand selectCandidateIDCommand = new SqlCommand(selectCandidateIDQuery, connection))
                {
                    selectCandidateIDCommand.Parameters.AddWithValue("@Name", name);
                    selectCandidateIDCommand.Parameters.AddWithValue("@Position", position);
                    candidateID = (int)selectCandidateIDCommand.ExecuteScalar();
                }

                // Get the foreign key ID from Elections table
                int electionID;
                string selectElectionIDQuery = "SELECT ElectionID FROM Elections WHERE Title = @Title;";
                using (SqlCommand selectElectionIDCommand = new SqlCommand(selectElectionIDQuery, connection))
                {
                    selectElectionIDCommand.Parameters.AddWithValue("@Title", "YourElectionTitle"); // Replace with the actual title
                    electionID = (int)selectElectionIDCommand.ExecuteScalar();
                }

                // Get the foreign key ID from Partylist table
                int partylistID;
                string selectPartylistIDQuery = "SELECT PartylistID FROM Partylist WHERE Name = @PartylistName;";
                using (SqlCommand selectPartylistIDCommand = new SqlCommand(selectPartylistIDQuery, connection))
                {
                    selectPartylistIDCommand.Parameters.AddWithValue("@PartylistName", partylistName);
                    partylistID = (int)selectPartylistIDCommand.ExecuteScalar();
                }

                // Insert into ReadItems table
                string insertReadItemsQuery = "INSERT INTO ReadItems (VoteID, CandidateID, ElectionID, PartylistID) VALUES (@VoteID, @CandidateID, @ElectionID, @PartylistID);";
                using (SqlCommand insertReadItemsCommand = new SqlCommand(insertReadItemsQuery, connection))
                {
                    insertReadItemsCommand.Parameters.AddWithValue("@VoteID", voteID);
                    insertReadItemsCommand.Parameters.AddWithValue("@CandidateID", candidateID);
                    insertReadItemsCommand.Parameters.AddWithValue("@ElectionID", electionID);
                    insertReadItemsCommand.Parameters.AddWithValue("@PartylistID", partylistID);
                    insertReadItemsCommand.ExecuteNonQuery();
                }

                return true;
            }
        }

        public DataTable ReadItemsTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT C.Name AS CandidateName, C.Position, P.Name AS PartylistName, P.Picture AS PartylistPicture " +
                               "FROM ReadItems R " +
                               "JOIN Candidates C ON R.CandidateID = C.CandidateID " +
                               "JOIN Elections E ON R.ElectionID = E.ElectionID " +
                               "JOIN Partylist P ON R.PartylistID = P.PartylistID;";
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
}
