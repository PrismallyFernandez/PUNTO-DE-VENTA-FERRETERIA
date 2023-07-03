using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Proyecto_Final
{
    public partial class frmUsuario : Form
    {
        ClaEmpleados Empleados = new ClaEmpleados();
        ClaDatos Datos = new ClaDatos();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.dgvListadoUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            ClaDatos Datos = new ClaDatos();
            dgvListadoUsuarios.DataSource = Datos.consulta("SELECT id AS ID, " +
                            "nombre AS NOMBRE, sexo AS SEXO, " +
                            "cedula AS CEDULA, telefono AS TELEFONO, " +
                            "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados");
        }

        private void MostrarEmpleados()
        {
            DataTable tabla = Datos.consulta("SELECT id AS ID, " +
                            "nombre AS NOMBRE, sexo AS SEXO, " +
                            "cedula AS CEDULA, telefono AS TELEFONO, " +
                            "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados");
            dgvListadoUsuarios.DataSource = tabla;
        }
        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
           txtcedula.Text = "";
            txtDireccion.Text = "";
            txttelefono.Text = "";
            comboxsexo.SelectedIndex = -1;
            txtNombre.Text = "";
            comboxestado.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtcedula.Text.Trim() == "" || txttelefono.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Empleados.NOMBRE = txtNombre.Text.Trim();
                Empleados.CEDULA = txtcedula.Text.Trim();
                Empleados.TELEFONO = txttelefono.Text.Trim();
                Empleados.DIRECCION = txtDireccion.Text.Trim();
                Empleados.POSICION= comboposicion.SelectedItem.ToString();
                Empleados.SEXO = comboxsexo.SelectedItem.ToString()[0];
                Empleados.ESTADO = comboxestado.SelectedItem.ToString()[0];

                Datos.CrearEmpleados(Empleados);
                MessageBox.Show("Empleado creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                MostrarEmpleados();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text.Trim() == "" || txtcedula.Text.Trim() == "" || txttelefono.Text.Trim() == "" ||
                  comboxsexo.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Empleados.ID = int.Parse(txtCodigo.Text.Trim());
                Empleados.NOMBRE = txtNombre.Text.Trim();
                Empleados.CEDULA = txtcedula.Text.Trim();
                Empleados.TELEFONO = txttelefono.Text.Trim();
                Empleados.DIRECCION = txtDireccion.Text.Trim();
                Empleados.POSICION = comboposicion.SelectedItem.ToString();
                Empleados.SEXO = comboxsexo.SelectedItem.ToString()[0];
                Empleados.ESTADO = comboxestado.SelectedItem.ToString()[0];


                Datos.ActualizarEmpleados(Empleados);
                MessageBox.Show("Empleado actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                MostrarEmpleados();

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
        private void dgvListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListadoUsuarios.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["id"].Value.ToString();
                txtNombre.Text = fila.Cells["NOMBRE"].Value.ToString();
                txtcedula.Text = fila.Cells["CEDULA"].Value.ToString();
                txttelefono.Text = fila.Cells["TELEFONO"].Value.ToString();
               comboxsexo.SelectedItem = fila.Cells["SEXO"].Value.ToString();
                txtDireccion.Text = fila.Cells["DIRECCION"].Value.ToString();
                comboposicion.SelectedItem = fila.Cells["POSICION"].Value.ToString();
                comboxestado.SelectedItem = fila.Cells["ESTADO"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtCodigo.Text = "";
            txtDireccion.Text = "";
            txtcedula.Text = "";
            txtNombre.Text = "";
            txttelefono.Text = "";
            comboxsexo.Text = "";
            comboposicion.Text = "";
            txtBuscar.Text = "";
            comboxestado.Text = "";
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            ClaDatos Datos = new ClaDatos();
            if (radiobuttoncodigo.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                            "nombre AS NOMBRE, sexo AS SEXO, " +
                            "cedula AS CEDULA, telefono AS TELEFONO, " +
                            "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados " +
                    "where id like '%" + txtBuscar.Text + "%' ";
                dgvListadoUsuarios.DataSource = Datos.consulta(sentencia);
            }
            else if (radiobuttomnombre.Checked)
            {

                string sentencia = "SELECT id AS ID, " +
                            "nombre AS NOMBRE, sexo AS SEXO, " +
                            "cedula AS CEDULA, telefono AS TELEFONO, " +
                            "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados " +
                    "where nombre like '%" + txtBuscar.Text + "%' ";
                dgvListadoUsuarios.DataSource = Datos.consulta(sentencia);
            }
            else if (radionbuttomcedula.Checked)
            {
                string sentencia = "SELECT id AS ID, " +
                            "nombre AS NOMBRE, sexo AS SEXO, " +
                            "cedula AS CEDULA, telefono AS TELEFONO, " +
                            "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados " +
                    "where estado like '%" + txtBuscar.Text + "%' ";
                dgvListadoUsuarios.DataSource = Datos.consulta(sentencia);

            }
            else
            {
                string sentencia = "SELECT id AS ID, " +
                           "nombre AS NOMBRE, sexo AS SEXO, " +
                           "cedula AS CEDULA, telefono AS TELEFONO, " +
                           "direccion AS DIRECCION, posicion AS POSICION, estado AS ESTADO FROM empleados " +
                   "where cedula like '%" + txtBuscar.Text + "%' ";
                dgvListadoUsuarios.DataSource = Datos.consulta(sentencia);


            }

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }
    }
    }

