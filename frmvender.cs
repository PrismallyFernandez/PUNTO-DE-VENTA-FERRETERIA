using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final
{
    public partial class frmvender : Form
    {
        ClaDatos Datos = new ClaDatos();
        ClaVentas Ventas = new ClaVentas();
        public frmvender()
        {
            InitializeComponent();
        }
        private void LimpiarFormulario()
        {
            txtcodigcliente.Text = "";
            txtDevuelta.Text = "";
            txtEfectivo.Text = "";
            txtNomCliente.Text = "";
            txtProd.Text = "";
            txtSubTotal.Text = "";
            txtPrecio.Text = "";
            txtDocVenta.Text = "";
            txtcantidad.Text = "";
            ttxtCodProd.Text = "";
            dgvListadoVentas.Rows.Clear();
        }
        private void frmvender_Load(object sender, EventArgs e)
        {
            this.dgvListadoVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            timer1.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvListadoVentas);

            file.Cells[0].Value = ttxtCodProd.Text;
            file.Cells[1].Value = txtProd.Text;
            file.Cells[2].Value = txtcantidad.Text;
            file.Cells[3].Value = txtPrecio.Text;
            file.Cells[4].Value = (double.Parse(txtcantidad.Text) * double.Parse(txtPrecio.Text)).ToString();
            dgvListadoVentas.Rows.Add(file);
            ttxtCodProd.Text = "";
            txtcantidad.Text = "";
            txtPrecio.Text = "";
            txtProd.Text = "";
            conseguisumatotal();
        }

        private void iconbuttomborrartodo_Click(object sender, EventArgs e)
        {
            dgvListadoVentas.Rows.Clear();
            conseguisumatotal();
        }

        public void conseguisumatotal()
        {
            int n = 0;
            float totalfinal = 0;
            n = dgvListadoVentas.RowCount;
            for (int i = 0; i < n; i++)
            {
                totalfinal += float.Parse(dgvListadoVentas.Rows[i].Cells[4].Value.ToString());
            }
            txtSubTotal.Text = totalfinal.ToString();
        }
        public void conseguirdevuelta()
        {
            double num1, num2, resta;
            num1 = double.Parse(txtEfectivo.Text);
            num2 = double.Parse(txtSubTotal.Text);
            resta = num1 - num2;
            txtDevuelta.Text = resta.ToString();
        }

        private void txtDevuelta_TextChanged(object sender, EventArgs e)
        {
            conseguirdevuelta();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmbusquedaclientes formm = new frmbusquedaclientes();
            formm.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmbusquedaproductos form = new frmbusquedaproductos();
            form.Show();
        }
     
        public void btnRegVenta_Click(object sender, EventArgs e)
        {
            frmReporteVentas form1=new frmReporteVentas();
            try
            {

                Ventas.IDCLIENTE = int.Parse(txtcodigcliente.Text.Trim());
                Ventas.TIPO = cmbCondVenta.SelectedItem.ToString();
                Ventas.MONTO = decimal.Parse(txtSubTotal.Text.Trim());



                form1.MostrarFacturas();
                Datos.CrearFacturas(Ventas);




            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Datos.conex.Close();

            }


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtNomCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtDocVenta.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CONDICION", cmbCondVenta.Text);


            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvListadoVentas.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SUBTOTAL"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["SUBTOTAL"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
                LimpiarFormulario();
            }

        }

        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conseguirdevuelta();

            }
        }
        private void dgvListadoVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListadoVentas.Rows.Remove(dgvListadoVentas.CurrentRow);
            conseguisumatotal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFechaVenta.Text = DateTime.Now.ToLongDateString();
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar.PerformClick();
            }
        }

        private void ttxtCodProd_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conex = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; " +
                        "pwd= '' ; database=ferreteriestrella");
                conex.Open();
                int codigo = int.Parse(ttxtCodProd.Text);
                string cadena = "select descripcion, precio from productos where id =" + codigo;
                MySqlCommand comand = new MySqlCommand(cadena, conex);
                MySqlDataReader registro = comand.ExecuteReader();
                if (registro.Read())
                {
                    txtProd.Text = registro["descripcion"].ToString();
                    txtPrecio.Text = registro["precio"].ToString();
                }
                else
                {
                    ttxtCodProd.Clear();
                    MessageBox.Show("No existe un producto con dicho codigo");

                }
                conex.Close();
            }
        }

        private void txtcodigcliente_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conex = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root; " +
                        "pwd= '' ; database=ferreteriestrella");
                conex.Open();
                int codigo = int.Parse(txtcodigcliente.Text);
                string cadena = "select nombre from clientes where id =" + codigo;
                MySqlCommand comand = new MySqlCommand(cadena, conex);
                MySqlDataReader registro = comand.ExecuteReader();
                if (registro.Read())
                {
                    txtNomCliente.Text = registro["nombre"].ToString();
                }
                else
                {
                    ttxtCodProd.Clear();
                    MessageBox.Show("No existe un cliente con dicho codigo");

                }
                conex.Close();
            }
        }

        private void btnBuscarCliente_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                btnBuscarCliente.PerformClick();
            }
        }

        private void btnBuscarProducto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                frmbusquedaproductos form = new frmbusquedaproductos();
                form.Show();

            }
        }
    }
    }
    
  


