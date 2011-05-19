using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SendXBMC
{
    public partial class frmPrompt : Form
    {
        public frmPrompt()
        {
            InitializeComponent();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendXBMC.frmSendXBMC.SetAuth(txtUsr.Text, txtPass.Text);
            this.Close();
        }
    }
}