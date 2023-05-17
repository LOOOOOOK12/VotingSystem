using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.DAL
{
    internal class Partylist
    {
        [Column(TypeName = "PartylistID")]
        public int Partylist_ID { get; set; }
        [Column(TypeName = "Partylist_Name")]
        public string PartylistName { get; set; }
        [Column(TypeName = "Partylist_Logo")]
        public int PartylistLogo { get; set; }

    }
}
