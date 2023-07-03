using iTextSharp.text.pdf.qrcode;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using MySql.Data.MySqlClient;

namespace Proyecto_Final
{
    public partial class frmReporteVentas : Form
    {

        ClaDatos Datos = new ClaDatos();
        ClaVentas Ventas = new ClaVentas();
        public frmReporteVentas()
        {
            InitializeComponent();
        }
        public void MostrarFacturas()
        {
            DataTable tabla = Datos.consulta("SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas");
            dgvReporteVentas.DataSource = tabla;
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            this.dgvReporteVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            MostrarFacturas();
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "VER FACTURA";
            btnColumn.Text = "VER FACTURA";
            btnColumn.UseColumnTextForButtonValue = true;

            // Agregar la columna al DataGridView
            dgvReporteVentas.Columns.Add(btnColumn);

        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {
            if (radiocodigofactura.Checked)
            {
                string sentencia = "SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas " +
                    "where id like '%" + txtBuscarReporteVenta.Text + "%'";
                dgvReporteVentas.DataSource = Datos.consulta(sentencia);
            }
            else if (radiocliente.Checked)
            {
                string sentencia = "SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas " +
                    "where idcliente like '%" + txtBuscarReporteVenta.Text + "%'";
                dgvReporteVentas.DataSource = Datos.consulta(sentencia);

            }
            else if (radiomonto.Checked)
            {
                string sentencia = "SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas " +
                    "where monto like '%" + txtBuscarReporteVenta.Text + "%'";
                dgvReporteVentas.DataSource = Datos.consulta(sentencia);
            }
            else if (radiotipo.Checked)
            {
                string sentencia = "SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas " +
                    "where tipo like '%" + txtBuscarReporteVenta.Text + "%'";
                dgvReporteVentas.DataSource = Datos.consulta(sentencia);

            }
            else
            {

                string sentencia = "SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas " +
                    "where fecha between '" + datatimedesde.Text + "' and '" + datetimehasta.Text + "' ";
                dgvReporteVentas.DataSource = Datos.consulta(sentencia);

            }

        }
        private void btnLimpiarReporte_Click(object sender, EventArgs e)
        {
            txtBuscarReporteVenta.Clear();
        }



        private void btnhacerrecibo_Click(object sender, EventArgs e)
        {
            frmrecib formmm = new frmrecib();
            formmm.Show();

        }


        private void txtBuscarReporteVenta_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarReporte.PerformClick();
            }
        }

        private void dgvReporteVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReporteVentas.Columns[e.ColumnIndex].Name == "VER FACTURA")
            {
                string filePath = "C:/Users/mrdar/Downloads/18032023125948.pdf";

                if (File.Exists(filePath))
                {
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("El archivo no existe.");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
            }
        