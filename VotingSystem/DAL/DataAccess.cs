using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.DAL
{
    internal class DataAccess
    {

        //DELETE
        public bool DeleteProduct(int partylist_ID) 
        {
            Connection conn = new Connection();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(conn.connect.ConnectionString)) 
            {
                try
                {
                    int result = connection.Execute($"DELETE FROM Partylist WHERE Partylist_ID = {partylist_ID}");
                    if (result == 1) 
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }

                }
                catch 
                {
                    return false;
                }
            }
        }
    }
}
