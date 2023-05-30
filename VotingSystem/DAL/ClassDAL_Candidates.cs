using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace VotingSystem.DAL
{
    internal class ClassDAL_Candidates
    {

        //ADD ITEMS
        public bool AddItemsToTable(string name, string Course, string Position, Image CandidatePic, string partylist ) 
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "INSERT INTO Candidates(Name,Course,Position,CandidatePic,Partylist) VALUES (@Name,@Course,@Position,@CandidatePic,@Partylist)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name.Trim());
                    cmd.Parameters.AddWithValue("@Course", Course.Trim());
                    cmd.Parameters.AddWithValue("@Position", Position.Trim());
                    cmd.Parameters.AddWithValue("@Partylist", partylist.Trim());


                    //converting image to binary to store to database
                    MemoryStream ms = new MemoryStream();
                    CandidatePic.Save(ms, CandidatePic.RawFormat);
                    // set to binary format image to parameter
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
