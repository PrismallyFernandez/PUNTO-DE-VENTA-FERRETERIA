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
    public partial class frmrecib : Form
    { ClaDatos Datos = new ClaDatos();
        public frmrecib()
        {
            InitializeComponent();
        }

        private void frmrecib_Load(object sender, EventArgs e)
        {
            ClaDatos Datos = new ClaDatos();
            timer1.Enabled = true;

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = Datos.consulta("SELECT id AS ID_FACTURA, " +
                "idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, " +
                "monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas where tipo = 'Credito' ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtidfactura.Text = fila.Cells["ID_FACTURA"].Value.ToString();
                txtidcliente.Text = fila.Cells["CLIENTE_FACTURA"].Value.ToString();
                txtmonto.Text = fila.Cells["MONTO_FACTURA"].Value.ToString();
                txttipo.Text = fila.Cells["TIPO_FACTURA"].Value.ToString();

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (radioidfsctura.Checked)
            {
                string sentencia = "SELECT id AS ID_FACTURA, idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas where tipo = 'Credito' and id like '%" + txtbuscar.Text + "%'";
               dataGridView1.DataSource = Datos.consulta(sentencia);



            }
            else
            {
                string sentencia = "SELECT id AS ID_FACTURA, idcliente AS CLIENTE_FACTURA, tipo AS TIPO_FACTURA, monto AS MONTO_FACTURA, fecha AS FECHA_FACTURA FROM facturas where tipo = 'Credito' and idcliente like '%" + txtbuscar.Text + "%'";

                dataGridView1.DataSource = Datos.consulta(sentencia);


            }


        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfecha.Text=DateTime.Now.ToString();  
        }

        private void txtimprir_Click(object sender, EventArgs e)
        {
            frmrecibo form1= new frmrecibo();
            form1.Show();
            form1.txtcliente.Text= txtidcliente.Text;  
            form1.tcodigofacturaa.Text = txtidfactura.Text;
            form1.txtcodigofactura.Text=txtidfactura.Text;
            form1.txtmontoo.Text=txtmonto.Text;
            form1.txtmonto.Text = txtmontoagregar.Text;
            string strNum1 = txtmonto.Text;
            string strNum2 = txtmontoagregar.Text;
            double num1 = double.Parse(strNum1);
            double num2 = double.Parse(strNum2);
            double resultado = num1 - num2;
            form1.txtbalancenuevo.Text = resultado.ToString();



            this.Close();

        }
    }
}
