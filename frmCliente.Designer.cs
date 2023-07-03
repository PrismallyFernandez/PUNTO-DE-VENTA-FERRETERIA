
namespace Proyecto_Final
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListadoSuplidores = new System.Windows.Forms.DataGridView();
           
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(927, 71);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(173, 22);
            this.txtBuscar.TabIndex = 49;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "No. Cédula",
            "Dirección",
            "Provincia"});
            this.cmbBuscarCliente.Location = new System.Drawing.Point(727, 71);
            this.cmbBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(191, 24);
            this.cmbBuscarCliente.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(637, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Buscar por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(895, 79);
            this.label9.TabIndex = 46;
            this.label9.Text = "Listado de Clientes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoSuplidores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoSuplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSuplidores.Location = new System.Drawing.Point(351, 128);
            this.dgvListadoSuplidores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoSuplidores.MultiSelect = false;
            this.dgvListadoSuplidores.Name = "dgvListadoClientes";
            this.dgvListadoSuplidores.ReadOnly = true;
            this.dgvListadoSuplidores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoSuplidores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoSuplidores.RowTemplate.Height = 28;
            this.dgvListadoSuplidores.Size = new System.Drawing.Size(895, 434);
            this.dgvListadoSuplidores.TabIndex = 45;
            // 
            // label5
            // 
       
            // 
            // label7
            // 
   
            // 
            // label2
            // 
      
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Azua",
            "Barahona",
            "Dajabón",
            "Puerto Plata",
            "Santiago",
            "Santo Domingo"});
            this.cmbProvincia.Location = new System.Drawing.Point(28, 316);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(259, 24);
            this.cmbProvincia.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Provincia:";
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarCliente.IconColor = System.Drawing.Color.White;
            this.btnLimpiarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCliente.IconSize = 20;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(1176, 66);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(59, 31);
            this.btnLimpiarCliente.TabIndex = 51;
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 20;
            this.btnBuscarCliente.Location = new System.Drawing.Point(1109, 66);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(59, 31);
            this.btnBuscarCliente.TabIndex = 50;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
         
            // btnEditar
            // 
        
            // 
            // btnGuardar
            // 
         
            // 
            // frmsuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProvincia);

            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscarCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoSuplidores);
          
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmsuplidores";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSuplidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLimpiarCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListadoSuplidores;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txttelefsuplidor;
        private System.Windows.Forms.TextBox txtdireccionsuplidor;
        private System.Windows.Forms.TextBox txtNombreSuplidor;
        private System.Windows.Forms.TextBox txtCodigoSuplidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label4;
    }
}