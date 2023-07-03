
namespace Proyecto_Final
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVentas
            // 
            this.ClientSize = new System.Drawing.Size(1107, 646);
            this.Name = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DataGridView dgvListadoVentas;
        private FontAwesome.Sharp.IconButton btnRegVenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.TextBox txtcantidad;
        private FontAwesome.Sharp.IconButton iconbuttomborrartodo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtProd;
        public System.Windows.Forms.TextBox ttxtCodProd;
        public System.Windows.Forms.TextBox txtNomCliente;
        public System.Windows.Forms.TextBox txtcodigcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        public System.Windows.Forms.ComboBox cmbCondVenta;
        public System.Windows.Forms.TextBox txtDocVenta;
    }
}