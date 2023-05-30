using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.DAL;

namespace VotingSystem.BLL
{
    internal class ClassBLL_Cadidates
    {
        public bool SaveItems(string name, string Course, string Position, Image CandidatePic, string partylist)
        {
            try
            {
                ClassDAL_Candidates objdal = new ClassDAL_Candidates();
                return objdal.AddItemsToTable(name,Course,Position,CandidatePic, partylist);
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
                ClassDAL_Candidates objDALC = new ClassDAL_Candidates();
                return objDALC.ReadItemsTable();
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
                ClassDAL_Candidates objDALC = new ClassDAL_Candidates();
                return objDALC.SearchItemsTable(search);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public bool UpdateItems(int candidateID, string name, string Course, string Position, Image CandidatePic, string partylist)
        {
            try
            {
                ClassDAL_Candidates objdal = new ClassDAL_Candidates();
                return objdal.UpdateItemInTable(candidateID, name, Course, Position, CandidatePic, partylist);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }


    }
}
