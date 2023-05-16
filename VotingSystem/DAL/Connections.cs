 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VotingSystem.DAL
{
    internal class Connection
    {
        public SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP - SM9NF9V; Initial Catalog = DB_VotingSystem; Integrated Security = True");
    }
}
