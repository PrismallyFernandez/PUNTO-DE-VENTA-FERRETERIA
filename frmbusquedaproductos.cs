using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Proyecto_Final
{
    

    public partial class frmbusquedaproductos : Form
    {
        ClaDatos Datos = new ClaDatos();
    
        public frmbusquedaproductos()
        {
            InitializeComponent();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            if (radioprecio.Checked)
            {
                string sentencia = "SELECT id AS ID,descripcion AS DESCRIPCION, precio AS PRECIO, estado AS ESTADO  FROM productos " +
                            "where precio like '%" + txtbuscar.Text + "%'";
                datagridbusquedaproductos.DataSource = Datos.consulta(sentencia);
            }
            else
            {

                string sentencia = "SELECT id AS ID,descripcion AS DESCRIPCION, precio AS PRECIO, estado AS ESTADO  FROM productos " +
                            "where descripcion like '%" + txtbuscar.Text + "%'";
                datagridbusquedaproductos.DataSource = Datos.consulta(sentencia);


            }
        }
        private void frmbusquedaproductos_Load(object sender, EventArgs e)
        {
            ClaDatos Datos = new ClaDatos();
            this.datagridbusquedaproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagridbusquedaproductos.DataSource = Datos.consulta("SELECT id AS ID, descripcion AS DESCRIPCION,precio AS PRECIO, estado AS ESTADO FROM productos");
        }

        private void datagridbusquedaproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagridbusquedaproductos.SelectedRows[0];
            frmvender form1 = (frmvender)Application.OpenForms["frmvender"];
            form1.ttxtCodProd.Text = row.Cells["ID"].Value.ToString();
            form1.txtProd.Text = row.Cells["DESCRIPCION"].Value.ToString();
            form1.txtPrecio.Text = row.Cells["PRECIO"].Value.ToString();

            this.Close();
        }
        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarProd.PerformClick();
            }
        }
    }
}
