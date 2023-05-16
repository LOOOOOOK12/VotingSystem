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
       
    }
}
