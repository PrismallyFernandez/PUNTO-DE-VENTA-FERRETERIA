using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmrecibo : Form
    {
        public frmrecibo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void frmrecibo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
