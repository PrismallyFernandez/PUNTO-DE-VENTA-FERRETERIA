using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmProducto : Form
    {
        ClaProductos Productos = new ClaProductos();
        ClaDatos Datos = new ClaDatos();

        public frmProducto()
        {
            InitializeComponent();
            MostrarProductos();

        }
          private void MostrarProductos()
        {
            DataTable tabla = Datos.consulta("SELECT id AS ID, " +
                "descripcion AS DESCRIPCION, costo AS COSTO, " +
                "precio AS PRECIO, estado AS ESTADO, " +
                "suplidor AS ID_SUPLIDOR FROM productos");
         dgvListadoProductos.DataSource = tabla;
        }
    private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtprecio.Text = "";
            txtdescripcion.Text = "";
            txtcosto.Text = "";
            comboxsuplidor.SelectedIndex = -1;
            comboxestado.Text = "";
        }
        private void btnEditarProd_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtdescripcion.Text.Trim() == "" || txtcosto.Text.Trim() == "" || txtprecio.Text.Trim() == "" ||
                  comboxsuplidor.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Productos.ID = int.Parse(txtCodigo.Text.Trim());
                Productos.DESCRIPCION = txtdescripcion.Text.Trim();
                Productos.COSTO = decimal.Parse(txtcosto.Text.Trim());
                Productos.PRECIO = decimal.Parse(txtprecio.Text.Trim());
                Productos.ESTADO = comboxestado.SelectedItem.ToString()[0];
                Productos.SUPLIDOR = comboxsuplidor.SelectedItem.ToString();


                Datos.ActualizarProductos(Productos);
                MessageBox.Show("Producto actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                MostrarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Datos.conex.Close();

            }
        }

        private void btnGuardarProd_Click(object sender, EventArgs e)
        {

            if (txtdescripcion.Text.Trim() == "" || txtcosto.Text.Trim() == "" || txtprecio.Text.Trim() == "" || comboxsuplidor.SelectedIndex == -1 || comboxestado.Text.Trim()== "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Productos.DESCRIPCION = txtdescripcion.Text.Trim();
                Productos.COSTO = decimal.Parse(txtcosto.Text.Trim());
                Productos.PRECIO = decimal.Parse(txtprecio.Text.Trim());
                Productos.ESTADO = comboxestado.SelectedItem.ToString()[0];
                Productos.SUPLIDOR = comboxsuplidor.SelectedItem.ToString();

                Datos.CrearProductos(Productos);
                MessageBox.Show("Producto creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                MostrarProductos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Datos.conex.Close();

            }
        }


        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.dgvListadoProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ClaDatos Datos = new ClaDatos();
            dgvListadoProductos.DataSource = Datos.consulta("SELECT id AS ID, " +
                "descripcion AS DESCRIPCION, costo AS COSTO, " +
                "precio AS PRECIO, estado AS ESTADO, " +
                "suplidor AS ID_SUPLIDOR FROM productos");

            string strSql = "SELECT id FROM suplidores";

            DataTable dtSuplidores = Datos.consulta(strSql);

            comboxsuplidor.Items.Clear();

            foreach (DataRow fila in dtSuplidores.Rows)
            {
                string id = fila["id"].ToString();
                comboxsuplidor.Items.Add(id);
            }

            if (comboxsuplidor.Items.Count > 0)
            {
                comboxsuplidor.SelectedIndex = 0;
            }

        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
    
            if (radiocodigo.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                    "descripcion AS DESCRIPCION, costo AS COSTO, " +
                    "precio AS PRECIO, estado AS ESTADO, " +
                    "suplidor AS ID_SUPLIDOR FROM productos " +
                    "where id like '%" + txtBuscarProd.Text + "%'";
                dgvListadoProductos.DataSource = Datos.consulta(sentencia);
            }
            else if (radiobuttondescripcion.Checked)
            {

                string sentencia = "SELECT id AS ID, " +
                    "descripcion AS DESCRIPCION, costo AS COSTO, " +
                    "precio AS PRECIO, estado AS ESTADO, " +
                    "suplidor AS ID_SUPLIDOR FROM productos " +
                    "where descripcion like '%" + txtBuscarProd.Text + "%'";
                dgvListadoProductos.DataSource = Datos.consulta(sentencia);
            }
            else
            {

                string sentencia = "SELECT id AS ID, " +
                    "descripcion AS DESCRIPCION, costo AS COSTO, " +
                    "precio AS PRECIO, estado AS ESTADO, " +
                    "suplidor AS ID_SUPLIDOR FROM productos " +
                    "where estado like '%" + txtBuscarProd.Text + "%'";
                dgvListadoProductos.DataSource = Datos.consulta(sentencia);


            }


        }
        private void btnLimpiarProd_Click(object sender, EventArgs e)
        {
            txtBuscarProd.Text = "";
            txtCodigo.Text = "";
            txtcosto.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
        }

        private void dgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListadoProductos.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["id"].Value.ToString();
                txtdescripcion.Text = fila.Cells["descripcion"].Value.ToString();
                txtcosto.Text = fila.Cells["costo"].Value.ToString();
                txtprecio.Text = fila.Cells["precio"].Value.ToString();
                comboxsuplidor.SelectedItem = fila.Cells["id_suplidor"].ToString();
                comboxestado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        private void txtBuscarProd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProd.PerformClick();
            }
        }
    }
    }






