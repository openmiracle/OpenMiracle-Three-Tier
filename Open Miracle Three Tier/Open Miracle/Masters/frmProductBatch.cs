using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmProductBatch : Form
    {
        public frmProductBatch()
        {
            InitializeComponent();
        }

        private void btnFrmClose_Click(object sender, EventArgs e)
        {
            if (PublicVariables.isMessageClose)
            {
                Messages.CloseMessage(this);
            }
            else
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
