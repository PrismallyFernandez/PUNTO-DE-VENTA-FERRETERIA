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
    public partial class frmproveedores : Form
    {
        ClaSuplidores Suplidores = new ClaSuplidores();
        ClaDatos Datos = new ClaDatos();
        public frmproveedores()
        {
            InitializeComponent();
            MostrarProveedores();

        }
        private void MostrarProveedores()
        {
            DataTable tabla = Datos.consulta("SELECT id AS ID, " +
                    "nombre AS NOMBRE, rnc AS RNC, " +
                    "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM suplidores");
            dgvListadoProveedor.DataSource = tabla;
        }
        private void LimpiarFormulario()
        {
            txtCodigoProveedor.Text = "";
            txtrnc.Text = "";
            txttelefono.Text = "";
            TXTNOMBREPROVVEDOR.Text = "";
            txtDireccionProveedor.Text = "";
            comboxestado.Text = "";
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            if (radiocodigo.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                    "nombre AS NOMBRE, rnc AS RNC, " +
                    "telefono AS TELEFONO, direccion AS DIRECCION,estado AS ESTADO FROM suplidores " +
                    "where id like '%" + txtBuscar.Text + "%'";
                dgvListadoProveedor.DataSource = Datos.consulta(sentencia);
            }
            else if (radionombre.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                    "nombre AS NOMBRE, rnc AS RNC, " +
                    "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM suplidores " +
                    "where nombre like '%" + txtBuscar.Text + "%'";
                dgvListadoProveedor.DataSource = Datos.consulta(sentencia);

            }
            else if (radiornc.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                    "nombre AS NOMBRE, rnc AS RNC, " +
                    "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM suplidores " +
                    "where rnc like '%" + txtBuscar.Text + "%'";
                dgvListadoProveedor.DataSource = Datos.consulta(sentencia);
            }
            else
            {
                string sentencia = "SELECT id AS ID, " +
                    "nombre AS NOMBRE, rnc AS RNC, " +
                    "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM suplidores " +
                    "where estado like '%" + txtBuscar.Text + "%'";
                dgvListadoProveedor.DataSource = Datos.consulta(sentencia);

            }

        }

        private void btnLimpiarProv_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtCodigoProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            txtrnc.Text = "";
            txttelefono.Text = "";
            TXTNOMBREPROVVEDOR.Text = "";
            comboxestado.Text = "";
        }

        private void frmproveedores_Load(object sender, EventArgs e)
        {
            this.dgvListadoProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ClaDatos Datos = new ClaDatos();

            dgvListadoProveedor.DataSource = Datos.consulta("SELECT id AS ID, " +
                   "nombre AS NOMBRE, rnc AS RNC, " +
                   "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM suplidores ");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (TXTNOMBREPROVVEDOR.Text.Trim() == "" || txtrnc.Text.Trim() == "" || txtDireccionProveedor.Text.Trim() == "" || txttelefono.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Suplidores.NOMBRRE = TXTNOMBREPROVVEDOR.Text.Trim();
                Suplidores.RNC = txtrnc.Text.Trim();
                Suplidores.TELEFONO = txttelefono.Text.Trim();
                Suplidores.DIRECCION = txtDireccionProveedor.Text.Trim();
                Suplidores.ESTADO = comboxestado.SelectedItem.ToString()[0];

                Datos.CrearSuplidores(Suplidores);
                MessageBox.Show("Suplidor creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                MostrarProveedores();
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

        private void dgvListadoProveedor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListadoProveedor.Rows[e.RowIndex];
                txtCodigoProveedor.Text = fila.Cells["ID"].Value.ToString();
                TXTNOMBREPROVVEDOR.Text = fila.Cells["NOMBRE"].Value.ToString();
                txtrnc.Text = fila.Cells["RNC"].Value.ToString();
                txttelefono.Text = fila.Cells["TELEFONO"].Value.ToString();
                txtDireccionProveedor.Text = fila.Cells["DIRECCION"].Value.ToString();
                comboxestado.Text = fila.Cells["ESTADO"].Value.ToString();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoProveedor.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, seleccione un proveedor para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TXTNOMBREPROVVEDOR.Text.Trim() == "" || txtrnc.Text.Trim() == "" || txtDireccionProveedor.Text.Trim() == "" || txttelefono.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Suplidores.ID = Convert.ToInt32(txtCodigoProveedor.Text.Trim());
                Suplidores.NOMBRRE = TXTNOMBREPROVVEDOR.Text.Trim();
                Suplidores.RNC = txtrnc.Text.Trim();
                Suplidores.TELEFONO = txttelefono.Text.Trim();
                Suplidores.DIRECCION = txtDireccionProveedor.Text.Trim();
                Suplidores.ESTADO = comboxestado.SelectedItem.ToString()[0];

                Datos.ActualizarSuplidores(Suplidores);
                MessageBox.Show("Suplidor actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualiza solo la fila seleccionada
                int rowIndex = dgvListadoProveedor.CurrentRow.Index;
                DataGridViewRow row = dgvListadoProveedor.Rows[rowIndex];
                row.Cells["NOMBRE"].Value = Suplidores.NOMBRRE;
                row.Cells["RNC"].Value = Suplidores.RNC;
                row.Cells["TELEFONO"].Value = Suplidores.TELEFONO;
                row.Cells["DIRECCION"].Value = Suplidores.DIRECCION;
                row.Cells["ESTADO"].Value = Suplidores.ESTADO;

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Datos.conex.Close();
            }
            MostrarProveedores();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProv.PerformClick();
            }
        }
    }
}