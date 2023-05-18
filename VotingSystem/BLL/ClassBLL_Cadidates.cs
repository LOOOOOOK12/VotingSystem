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
        public bool SaveItems(string Firstname, string Middlename, string Lastname, string Course, string Position, Image CandidatePic)
        {
            try
            {
                ClassDAL_Candidates objdal = new ClassDAL_Candidates();
                return objdal.AddItemsToTable(Firstname, Middlename,Lastname,Course,Position,CandidatePic);
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

        public DataTable SearchItems(string searchTerm)
        {
            try
            {
                ClassDAL objDALC = new ClassDAL();
                return objDALC.SearchItemsTable(searchTerm);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
