
namespace Proyecto_Final
{
    partial class frmReporteCompra
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
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReporteCompras = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnLimpiarReporte = new FontAwesome.Sharp.IconButton();
            this.btnBuscarReporte = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarReporteCompra = new System.Windows.Forms.TextBox();
            this.CódigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(762, 73);
            this.label9.TabIndex = 22;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "DD/MM/YY";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Reporte de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Fin:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "DD/MM/YY";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(295, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(572, 61);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(188, 21);
            this.cmbProveedor.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(927, 334);
            this.label3.TabIndex = 31;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvReporteCompras
            // 
            this.dgvReporteCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoUsuario,
            this.NombreCompleto,
            this.Sexo,
            this.NombreProducto,
            this.Posición,
            this.Categoría,
            this.Costo,
            this.Dirección,
            this.Email});
            this.dgvReporteCompras.Location = new System.Drawing.Point(26, 158);
            this.dgvReporteCompras.MultiSelect = false;
            this.dgvReporteCompras.Name = "dgvReporteCompras";
            this.dgvReporteCompras.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReporteCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteCompras.RowTemplate.Height = 28;
            this.dgvReporteCompras.Size = new System.Drawing.Size(902, 271);
            this.dgvReporteCompras.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.WhatsApp_Image_2023_03_01_at_6_56_53_PM;
            this.pictureBox1.Location = new System.Drawing.Point(792, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Categoría",
            "Costo",
            "Fecha de Registro",
            "Monto Total",
            "No. Documento",
            "Nombre Producto",
            "Razón Social ",
            "Usuario"});
            this.cmbBuscar.Location = new System.Drawing.Point(295, 122);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(234, 21);
            this.cmbBuscar.TabIndex = 34;
            // 
            // btnLimpiarReporte
            // 
            this.btnLimpiarReporte.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarReporte.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarReporte.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarReporte.IconColor = System.Drawing.Color.White;
            this.btnLimpiarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarReporte.IconSize = 20;
            this.btnLimpiarReporte.Location = new System.Drawing.Point(843, 118);
            this.btnLimpiarReporte.Name = "btnLimpiarReporte";
            this.btnLimpiarReporte.Size = new System.Drawing.Size(85, 25);
            this.btnLimpiarReporte.TabIndex = 37;
            this.btnLimpiarReporte.Text = "Limpiar";
            this.btnLimpiarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarReporte.UseVisualStyleBackColor = false;
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReporte.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReporte.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarReporte.IconColor = System.Drawing.Color.White;
            this.btnBuscarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReporte.IconSize = 20;
            this.btnBuscarReporte.Location = new System.Drawing.Point(752, 118);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(85, 25);
            this.btnBuscarReporte.TabIndex = 36;
            this.btnBuscarReporte.Text = "Buscar";
            this.btnBuscarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReporte.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Buscar por:";
            // 
            // txtBuscarReporteCompra
            // 
            this.txtBuscarReporteCompra.Location = new System.Drawing.Point(535, 124);
            this.txtBuscarReporteCompra.Name = "txtBuscarReporteCompra";
            this.txtBuscarReporteCompra.Size = new System.Drawing.Size(201, 20);
            this.txtBuscarReporteCompra.TabIndex = 38;
            // 
            // CódigoUsuario
            // 
            this.CódigoUsuario.HeaderText = "Fecha Registro";
            this.CódigoUsuario.Name = "CódigoUsuario";
            this.CódigoUsuario.ReadOnly = true;
            this.CódigoUsuario.Width = 90;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "No. Documento";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 80;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Monto Total";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Código Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 70;
            // 
            // Posición
            // 
            this.Posición.HeaderText = "Nombre Producto";
            this.Posición.Name = "Posición";
            this.Posición.ReadOnly = true;
            this.Posición.Width = 140;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            this.Categoría.ReadOnly = true;
            this.Categoría.Width = 80;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 80;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Nombre Usuario";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Razón Social Proveedor";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
            // 
            // frmReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.txtBuscarReporteCompra);
            this.Controls.Add(this.btnLimpiarReporte);
            this.Controls.Add(this.btnBuscarReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReporteCompras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Name = "frmReporteCompra";
            this.Text = "frmReporteCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReporteCompras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarReporte;
        private FontAwesome.Sharp.IconButton btnBuscarReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarReporteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}