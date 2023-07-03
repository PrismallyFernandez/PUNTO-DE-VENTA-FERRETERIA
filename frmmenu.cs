using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmmenu : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public frmmenu()
        {
            InitializeComponent();
        }

        private void menuFacturacion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario form2 = new frmUsuario();
            form2.Show();

        }

        private void menuVenta_Click(object sender, EventArgs e)
        {
            frmvender form = new frmvender();
            form.Show();
        }

        private void menuRecibo_Click(object sender, EventArgs e)
        {
            frmrecibo form1 = new frmrecibo();
            form1.Show();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto form4 = new frmProducto();
            form4.Show();
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            frmReporteVentas form5 = new frmReporteVentas();
            form5.Show();
        }

        private void sUPLIDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproveedores form7 = new frmproveedores();
            form7.Show();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            frmclientess form8 = new frmclientess();
            form8.Show();
        }

        private void realizarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecib form = new frmrecib();
            form.Show();
        }
    }
}