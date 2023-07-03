using MySql.Data.MySqlClient;
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
    public partial class frmclientess : Form
    {
        ClaDatos Datos = new ClaDatos();
        ClaClientes Clientes = new ClaClientes();
        int id_cliente;
        public frmclientess()
        {
            InitializeComponent();
        }

        private void frmclientess_Load(object sender, EventArgs e)
        {
            this.dgvListadoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            MostrarClientes();
        }
        private void MostrarClientes()
        {
            DataTable tabla = Datos.consulta("SELECT id AS ID, " +
                "nombre AS NOMBRE, cedula AS CEDULA, " +
                "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM clientes");
            dgvListadoClientes.DataSource = tabla;
        }


        private void LimpiarCampos()
        {
            txtCodigoCliente.Clear();
            txtNombreCliente.Clear();
            txtCedClien.Clear();
            txtTelClien.Clear();
            txtDireccionClien.Clear();
            comboxestado.Text = "";
        }


        private void dgvListadoClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_cliente = Convert.ToInt32(dgvListadoClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                txtCodigoCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtNombreCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                txtCedClien.Text = dgvListadoClientes.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
                txtTelClien.Text = dgvListadoClientes.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                txtDireccionClien.Text = dgvListadoClientes.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
                comboxestado.Text=dgvListadoClientes.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString();
            }
        }
            private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Trim() == "" || txtCedClien.Text.Trim() == "" || txtTelClien.Text.Trim() == "" || txtDireccionClien.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Clientes.NOMBRE = txtNombreCliente.Text.Trim();
                Clientes.CEDULA = txtCedClien.Text.Trim();
                Clientes.TELEFONO = txtTelClien.Text.Trim();
                Clientes.DIRECCION = txtDireccionClien.Text.Trim();
                    Clientes.ESTADO = comboxestado.SelectedItem.ToString()[0];


                Datos.CrearClientes(Clientes);
                MessageBox.Show("Cliente creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarClientes();
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombreCliente.Text.Trim() == "" || txtCedClien.Text.Trim() == "" || txtTelClien.Text.Trim() == "" )
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {   Clientes.ID= int.Parse(txtCodigoCliente.Text.Trim());
                Clientes.NOMBRE = txtNombreCliente.Text.Trim();
                Clientes.CEDULA = txtCedClien.Text.Trim();
                Clientes.TELEFONO = txtTelClien.Text.Trim();
                Clientes.DIRECCION = txtDireccionClien.Text.Trim();
                Clientes.ESTADO = comboxestado.SelectedItem.ToString()[0];

                Datos.ActualizarClientes(Clientes);
                MessageBox.Show("Cliente actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarClientes();

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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ClaDatos Datos = new ClaDatos();
            if (rdbuttoncodigo.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                "nombre AS NOMBRE, cedula AS CEDULA, " +
                "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM clientes " +
                    "where id like '%" + txtBuscar.Text + "%'";
                dgvListadoClientes.DataSource = Datos.consulta(sentencia);
            }
            else if (radiobuttonnombre.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                "nombre AS NOMBRE, cedula AS CEDULA, " +
                "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM clientes " +
                    "where nombre like '%" + txtBuscar.Text + "%'";
                dgvListadoClientes.DataSource = Datos.consulta(sentencia);

            }
            else if (radiobuttocedula.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                "nombre AS NOMBRE, cedula AS CEDULA, " +
                "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM clientes " +
                    "where cedula like '%" + txtBuscar.Text + "%'";
                dgvListadoClientes.DataSource = Datos.consulta(sentencia);
            }
            else
            {
                string sentencia = "SELECT id AS ID, " +
               "nombre AS NOMBRE, cedula AS CEDULA, " +
               "telefono AS TELEFONO, direccion AS DIRECCION, estado AS ESTADO FROM clientes " +
                   "where estado like '%" + txtBuscar.Text + "%'";
                dgvListadoClientes.DataSource = Datos.consulta(sentencia);

            }

        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {

            txtCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtDireccionClien.Text = "";
            txtTelClien.Text = "";
            txtCedClien.Text = "";
            comboxestado.Text = "";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCliente.PerformClick();
            }
        }

    }
    }
    
    


