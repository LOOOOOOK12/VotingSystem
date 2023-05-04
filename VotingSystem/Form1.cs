using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
           
            FRM_Home f3 = new FRM_Home();
            this.Hide();
            f3.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
