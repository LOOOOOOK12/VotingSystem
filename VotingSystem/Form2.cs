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
    public partial class Form2 : Form
    {
        FRM_Login f1 = new FRM_Login();
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Hide();
            f1.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
