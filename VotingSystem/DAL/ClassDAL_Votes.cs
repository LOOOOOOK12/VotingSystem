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

        public bool AddItemsToTable( string voters,string name, string electionTitle, string partylist)
        {

            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            try
            {       


                //VOTERS
                string votersQuery = "SELECT votersID FROM Voters WHERE ID = @ID";
                int votersId;

                using (SqlCommand votersCommand = new SqlCommand(votersQuery, con.connect))
                {
                    votersCommand.Parameters.AddWithValue("@ID", voters.Trim());
                    votersId = (int)votersCommand.ExecuteScalar();
                    object result = votersCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        votersId = (int)result;
                    }
                    else
                    {
                        // Handle the case where no row was found
                        // You can choose to throw an exception, assign a default value, or take other appropriate action
                        // For example, you can assign a value of -1 to indicate no matching row found
                        votersId = -1;
                    }
                }

                //CANDIDATES
                string candidatesQuery = "SELECT Candidate_ID FROM Candidates WHERE Name = @Name";
                int candidateId;

                using (SqlCommand candidatesCommand = new SqlCommand(candidatesQuery, con.connect))
                {
                    candidatesCommand.Parameters.AddWithValue("@Name", name.Trim());
                    candidateId = (int)candidatesCommand.ExecuteScalar();
                    object result = candidatesCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        candidateId = (int)result;
                    }
                    else
                    {
                        // Handle the case where no row was found
                        // You can choose to throw an exception, assign a default value, or take other appropriate action
                        // For example, you can assign a value of -1 to indicate no matching row found
                        candidateId = -1;
                    }

                }

                
                string partylistQuery = "SELECT Partylist_ID FROM Partylist WHERE PartylistName = @PartylistName";
                int partylistId;

                using (SqlCommand partylistCommand = new SqlCommand(partylistQuery, con.connect))
                {
                    partylistCommand.Parameters.AddWithValue("@PartylistName",partylist);
                    object result = partylistCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        partylistId = (int)result;
                    }
                    else
                    {
                        // Handle the case where no row was found
                        // You can choose to throw an exception, assign a default value, or take other appropriate action
                        // For example, you can assign a value of -1 to indicate no matching row found
                        partylistId = -1;
                    }
                }

                // Retrieve the Election_ID from the Elections table
                int electionId;
                using (SqlCommand electionCommand = new SqlCommand("SELECT Election_ID FROM Election WHERE ElectionTitle = @ElectionTitle;", con.connect))
                {
                    electionCommand.Parameters.AddWithValue("@ElectionTitle", electionTitle.Trim());
                    object result = electionCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        electionId = (int)result;
                    }
                    else
                    {
                        // Handle the case where no row was found
                        // You can choose to throw an exception, assign a default value, or take other appropriate action
                        // For example, you can assign a value of -1 to indicate no matching row found
                        electionId = -1;
                    }
                }


                // Insert into Votes table
                string insertVoteQuery = "INSERT INTO Votes (Voters_ID,Candidate_ID, Election_ID, Partylist_ID) VALUES ( @Voters_ID, @Candidate_ID, @Election_ID, @Partylist_ID);";
                    using (SqlCommand insertVoteCommand = new SqlCommand(insertVoteQuery, con.connect))
                    {
                        insertVoteCommand.Parameters.AddWithValue("@Voters_ID", votersId);
                        insertVoteCommand.Parameters.AddWithValue("@Candidate_ID", candidateId);
                        insertVoteCommand.Parameters.AddWithValue("@Partylist_ID", partylistId);
                        insertVoteCommand.Parameters.AddWithValue("@Election_ID", electionId);
                        
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

