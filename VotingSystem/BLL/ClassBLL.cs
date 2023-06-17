using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using VotingSystem.DAL;
using System.Security.Cryptography.X509Certificates;

namespace VotingSystem.BLL
{
    internal class ClassBLL
    {
        public bool SaveItems(Image img, string Partylistname) 
        {
            try 
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddItemsToTable(img, Partylistname);
            }
            catch(Exception e) 
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItems() 
        {
            try 
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTable();
            }
            catch(Exception e) 
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetItemsMembers()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemsTablePartylistMembers();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }


        //PANG SEARCH
        public DataTable SearchItems(string searchTerm)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.SearchItemsTable(searchTerm);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        //PANGSERACH MEMBERS NG PARTYLIST
        public DataTable SearchItemsMembers(string searchTermMembers)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.SearchItemsTablePartlistMem(searchTermMembers);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        //PANG DISPLAY NG PARTYLIST SA ELECTIONS
        public DataTable SearchItemsPLEletions(string searchTermPL)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.SearchItemsTablePartlistsElection(searchTermPL);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }


        public bool UpdateItems( int PartylistID,Image img, string Partylistname)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.UpdateItemInTable(PartylistID,Partylistname, img);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }



    }
}
