using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VotingSystem
{
    public partial class FRM_EditPartylist : Form
    {
        public FRM_EditPartylist()
        {
            InitializeComponent();
        }

        private void btn_Updatelogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_logo.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addPL_btn_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();

            int partylistID; // Variable to store the Partylist ID

            if (int.TryParse(TXTBX_PartylistID.Text, out partylistID))
            {
                if (objbll.UpdateItems(partylistID, pb_logo.Image, TXTBX_partylistName.Text))
                {
                    MessageBox.Show("Record Successful!");
                }
                else
                {
                    MessageBox.Show("Record Failed!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Partylist ID!");
            }
        }

        

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        public void displayfieldPartylist(string partylistid, string partylistname, Image partylistlogo)
        {
            pb_logo.Image = partylistlogo;
            TXTBX_PartylistID.Text = partylistid;
            TXTBX_partylistName.Text = partylistname;

        }

        private void TXTBX_UpdatePL_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_logo_Click(object sender, EventArgs e)
        {

        }

        private void TXTBX_PartylistID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
