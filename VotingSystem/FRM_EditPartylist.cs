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
            //string UpdatedPLLogo = pb_logo.Text;
            //string UpdatedPlName = textBox2.Text;
            //// ... and so on

            //// Insert the new data into the database
            //InsertDataIntoDatabase(newData1, newData2);

            //// Update the labels in the previous user control
            //UpdatePreviousUserControlLabels(newData1, newData2);
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
    }
}
