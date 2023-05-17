using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using VotingSystem.BLL;
using System.IO;

namespace VotingSystem
{
    public partial class AddingPartyList_FRM : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SM9NF9V;Initial Catalog=DB_VotingSystem;Integrated Security=True");
        
        public AddingPartyList_FRM()
        {
            InitializeComponent();
            
        }
        
        private void Partylist_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddingPartyList_FRM_Load(object sender, EventArgs e)
        {

        }

        private void addPL_btn_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();

            if (objbll.SaveItems(pb_logo.Image, AddPartylist_txtbx.Text))
            {
                MessageBox.Show("Record Successful!");
            }
            else 
            {
                MessageBox.Show("Record Failed!");
            }


            //byte[] imageData = ImageToByteArray(pb_logo.Image);

            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "INSERT INTO Partylist (PartylistName, PartylistLogo) VALUES(@PartylistName, @PartylistLogo)";
            //cmd.Parameters.AddWithValue("@PartylistName", AddPartylist_txtbx.Text);
            //cmd.Parameters.AddWithValue("@PartylistLogo", imageData);
            //cmd.ExecuteNonQuery();         
            //con.Close();



            //MessageBox.Show("Record Succcessful");

        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_logo.Image = image;
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
