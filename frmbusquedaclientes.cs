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
    public partial class frmbusquedaclientes : Form
    {
        ClaDatos Datos = new ClaDatos();
        public frmbusquedaclientes()
        {
            InitializeComponent();
        }

        private void btnBuscarcliente_Click(object sender, EventArgs e)
        {
            if (radionombre.Checked)
            {
          
                string sentencia = "SELECT id AS ID, nombre AS NOMBRE, cedula AS CEDULA FROM clientes where nombre like '%" + txtbuscar.Text + "%'";
                datagridbusquedaclientes.DataSource = Datos.consulta(sentencia);
            }
            else
            {

                string sentencia = "SELECT id AS ID, nombre AS NOMBRE, cedula AS CEDULA FROM clientes where cedula like '%" + txtbuscar.Text + "%'";
                datagridbusquedaclientes.DataSource = Datos.consulta(sentencia);


            }
        }

        private void frmbusquedaclientes_Load(object sender, EventArgs e)
        {
            ClaDatos Datos = new ClaDatos();

            this.datagridbusquedaclientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagridbusquedaclientes.DataSource = Datos.consulta("SELECT id AS ID, nombre AS NOMBRE, cedula AS CEDULA FROM clientes");
        }

        private void datagridbusquedaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagridbusquedaclientes.SelectedRows[0];

            frmvender form2 = (frmvender)Application.OpenForms["frmvender"];
            form2.txtcodigcliente.Text = row.Cells["ID"].Value.ToString();
            form2.txtNomCliente.Text = row.Cells["NOMBRE"].Value.ToString();
 
            this.Close();

        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarcliente.PerformClick();
            }
        }
    }
}
