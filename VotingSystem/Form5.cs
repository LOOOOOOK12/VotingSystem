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
    public partial class FRM_Position : Form
    {
        public FRM_Position()
        {
            InitializeComponent();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPosition_btn_Click(object sender, EventArgs e)
        {
            Form7 addPos = new Form7();
            addPos.ShowDialog();
        }

        private void Position_LB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
