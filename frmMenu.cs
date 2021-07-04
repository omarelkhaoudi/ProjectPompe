using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPompe
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pompeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperation p = new frmOperation();
            p.Show();
        }

        private void sortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPompiste pom = new frmPompiste();
            pom.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 f = new form1();
        }
    }
}
