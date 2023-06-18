using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Collections.Specialized.BitVector32;

namespace VotingSystem.DAL
{
    internal class ClassDAL_Votes
    {
        private string connectionString = @"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True"; 

        public bool AddItemsToTable( string name, string electionTitle, string partylistName)
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            try
            {       // Get the foreign key ID from Voters table
                    //        int votersID;
                    //        string selectVotersIDQuery = "SELECT votersID FROM Voters WHERE ID = @ID;";
                    //        using (SqlCommand selectVotersIDCommand = new SqlCommand(selectVotersIDQuery, con.connect))
                    //        {
                    //            selectVotersIDCommand.Parameters.AddWithValue("@ID", voters);
                    //            votersID = (int)selectVotersIDCommand.ExecuteScalar();
                    //        }


                // Get the foreign key ID from Candidates table
                int candidateID;
                string selectCandidateIDQuery = "SELECT Candidate_ID FROM Candidates WHERE Name = @Name;";

                using (SqlCommand selectCandidateIDCommand = new SqlCommand(selectCandidateIDQuery, con.connect))
                {
                    selectCandidateIDCommand.Parameters.AddWithValue("@Name", name.Trim());

                    object result = selectCandidateIDCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        candidateID = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Handle the scenario when no matching candidate is found or the value is null.
                        // You can choose to assign a default value, throw an exception, or handle it based on your specific requirements.
                        // Example:
                        candidateID = -1; // Assigning a default value of -1 when the candidate ID is not found.
                    }
                }

                // Get the foreign key ID from Elections table
                int electionID;
                string selectElectionIDQuery = "SELECT Election_ID FROM Election WHERE ElectionTitle = @ElectionTitle;";

                using (SqlCommand selectElectionIDCommand = new SqlCommand(selectElectionIDQuery, con.connect))
                {
                    selectElectionIDCommand.Parameters.AddWithValue("@ElectionTitle", electionTitle.Trim());

                    object result = selectElectionIDCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        electionID = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Handle the scenario when no matching election is found or the value is null.
                        // You can choose to assign a default value, throw an exception, or handle it based on your specific requirements.
                        // Example:
                        electionID = -1; // Assigning a default value of -1 when the election ID is not found.
                    }
                }


                // Get the foreign key ID from Partylist table
                string partylistQuery = "SELECT Partylist_ID FROM Partylist WHERE PartylistName = @PartylistName";
                    int partylistID;

                    using (SqlCommand partylistCommand = new SqlCommand(partylistQuery, con.connect))
                    {
                        partylistCommand.Parameters.AddWithValue("@PartylistName", partylistName.Trim());
                        partylistID = (int)partylistCommand.ExecuteScalar();
                    }


                // Insert into Votes table
                    string insertVoteQuery = "INSERT INTO Votes ( Candidate_ID, Election_ID, Partylist_ID) VALUES ( @Candidate_ID, @Election_ID, @Partylist_ID);";
                    using (SqlCommand insertVoteCommand = new SqlCommand(insertVoteQuery, con.connect))
                    {
                        /*insertVoteCommand.Parameters.AddWithValue("@Voters_ID", votersID)*/;
                        insertVoteCommand.Parameters.AddWithValue("@Candidate_ID", candidateID);
                        insertVoteCommand.Parameters.AddWithValue("@Election_ID", electionID);
                        insertVoteCommand.Parameters.AddWithValue("@Partylist_ID", partylistID);
                        //insertVoteCommand.Parameters.AddWithValue("@Timestamp", timestamp);
                        insertVoteCommand.ExecuteNonQuery();
                    }

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

        public DataTable SearchItemsTablePartlistsElection(string searchTermMembers)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT C.Name AS Name, C.Position,C.Course AS Course, C.Candidate_ID AS Candidate_ID, P.PartylistName AS PartylistName, P.PartylistLogo AS PartylistLogo, C.CandidatePic AS CandidatePic, E.ElectionTitle AS ElectionTitle " +
                       "FROM Candidates C " +
                       "INNER JOIN Partylist P ON C.Partylist_ID = P.Partylist_ID " +
                       "INNER JOIN Election E ON C.Election_ID = E.Election_ID WHERE ElectionTitle = @SearchTerm;";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTermMembers + "%");

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

    ////pang search
    //public datatable searchitemstable(string search)
    //    {
    //        connection con = new connection();
    //        if (connectionstate.closed == con.connect.state)
    //        {
    //            con.connect.open();
    //        }

    //        string query = "select * from candidates where firstname like @search or lastname like @search or middlename like @search or partylist like @search or position like @search";
    //        sqlcommand cmd = new sqlcommand(query, con.connect);
    //        cmd.parameters.addwithvalue("@search", "%" + search + "%");

    //        try
    //        {
    //            using (sqldataadapter sda = new sqldataadapter(cmd))
    //            {
    //                datatable dt = new datatable();
    //                sda.fill(dt);
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

