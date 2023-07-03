using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtClave.Text;

            ClaDatos datos = new ClaDatos();
            DataTable tabla = datos.consulta($"SELECT * FROM Usuarios WHERE Usuario = '{usuario}' AND Contraseña = '{contraseña}'");

            if (tabla.Rows.Count > 0)
            {
                frmmenu form = new frmmenu();
                form.Show();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


