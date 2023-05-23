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
    public partial class FRM_UpdateCandidates : Form
    {
        public FRM_UpdateCandidates()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
