using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;

namespace VotingSystem.BLL
{
    internal class ClassBLL_Election
    {

        public bool SaveItems(string electionTitle, string description)
        {
            try
            {
                ClassDAL_Election objdalElection = new ClassDAL_Election();
                return objdalElection.AddItemsToTable(electionTitle, description);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }


        public DataTable GetItems()
        {
            try
            {
                ClassDAL_Election objdalElection = new ClassDAL_Election();
                return objdalElection.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable SearchItems(string search)
        {
            try
            {
                ClassDAL_Election objdalElection = new ClassDAL_Election();
                return objdalElection.SearchItemsTable(search);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }


        public bool UpdateItems(int electionID, string electionTitle, string Description)
        {
            try
            {
                ClassDAL_Election objdal = new ClassDAL_Election();
                return objdal.UpdateItemInTable(electionID, electionTitle, Description);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

    }
}
