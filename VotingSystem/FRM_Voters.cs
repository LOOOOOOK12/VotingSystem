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
    public partial class FRM_Voters : Form
    {
        public FRM_Voters()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
