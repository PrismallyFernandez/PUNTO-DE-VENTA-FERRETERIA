namespace Proyecto_Final
{
    partial class frmproveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnLimpiarProv = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProv = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListadoProveedor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.TXTNOMBREPROVVEDOR = new System.Windows.Forms.TextBox();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.radiocodigo = new System.Windows.Forms.RadioButton();
            this.radionombre = new System.Windows.Forms.RadioButton();
            this.radiornc = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioestado = new System.Windows.Forms.RadioButton();
            this.comboxestado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "RNC:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(30, 246);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(222, 23);
            this.txttelefono.TabIndex = 100;
            // 
            // btnLimpiarProv
            // 
            this.btnLimpiarProv.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProv.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarProv.IconColor = System.Drawing.Color.White;
            this.btnLimpiarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProv.IconSize = 20;
            this.btnLimpiarProv.Location = new System.Drawing.Point(1452, 79);
            this.btnLimpiarProv.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarProv.Name = "btnLimpiarProv";
            this.btnLimpiarProv.Size = new System.Drawing.Size(74, 39);
            this.btnLimpiarProv.TabIndex = 99;
            this.btnLimpiarProv.UseVisualStyleBackColor = false;
            this.btnLimpiarProv.Click += new System.EventHandler(this.btnLimpiarProv_Click);
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProv.IconColor = System.Drawing.Color.White;
            this.btnBuscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProv.IconSize = 20;
            this.btnBuscarProv.Location = new System.Drawing.Point(1068, 61);
            this.btnBuscarProv.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(74, 39);
            this.btnBuscarProv.TabIndex = 98;
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(843, 69);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 23);
            this.txtBuscar.TabIndex = 97;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(628, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 95;
            this.label10.Text = "Buscar por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(812, 143);
            this.label9.TabIndex = 94;
            this.label9.Text = "Listado de Proveedores";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoProveedor
            // 
            this.dgvListadoProveedor.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProveedor.Location = new System.Drawing.Point(377, 167);
            this.dgvListadoProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.dgvListadoProveedor.MultiSelect = false;
            this.dgvListadoProveedor.Name = "dgvListadoProveedor";
            this.dgvListadoProveedor.ReadOnly = true;
            this.dgvListadoProveedor.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoProveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoProveedor.RowTemplate.Height = 28;
            this.dgvListadoProveedor.Size = new System.Drawing.Size(812, 427);
            this.dgvListadoProveedor.TabIndex = 93;
            this.dgvListadoProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProveedor_CellClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Detalle de Proveedores";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(14, 573);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(329, 51);
            this.btnEditar.TabIndex = 90;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.Location = new System.Drawing.Point(14, 512);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(329, 51);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(30, 320);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(323, 23);
            this.txtDireccionProveedor.TabIndex = 87;
            // 
            // TXTNOMBREPROVVEDOR
            // 
            this.TXTNOMBREPROVVEDOR.Location = new System.Drawing.Point(30, 181);
            this.TXTNOMBREPROVVEDOR.Margin = new System.Windows.Forms.Padding(5);
            this.TXTNOMBREPROVVEDOR.Name = "TXTNOMBREPROVVEDOR";
            this.TXTNOMBREPROVVEDOR.Size = new System.Drawing.Size(323, 23);
            this.TXTNOMBREPROVVEDOR.TabIndex = 86;
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Location = new System.Drawing.Point(30, 116);
            this.txtCodigoProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.Size = new System.Drawing.Size(160, 23);
            this.txtCodigoProveedor.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 84;
            this.label8.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Código Proveedores:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 652);
            this.label1.TabIndex = 79;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(30, 388);
            this.txtrnc.Margin = new System.Windows.Forms.Padding(5);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(199, 23);
            this.txtrnc.TabIndex = 103;
            // 
            // radiocodigo
            // 
            this.radiocodigo.AutoSize = true;
            this.radiocodigo.Location = new System.Drawing.Point(739, 28);
            this.radiocodigo.Margin = new System.Windows.Forms.Padding(4);
            this.radiocodigo.Name = "radiocodigo";
            this.radiocodigo.Size = new System.Drawing.Size(70, 21);
            this.radiocodigo.TabIndex = 104;
            this.radiocodigo.TabStop = true;
            this.radiocodigo.Text = "Codigo";
            this.radiocodigo.UseVisualStyleBackColor = true;
            // 
            // radionombre
            // 
            this.radionombre.AutoSize = true;
            this.radionombre.Location = new System.Drawing.Point(739, 57);
            this.radionombre.Margin = new System.Windows.Forms.Padding(4);
            this.radionombre.Name = "radionombre";
            this.radionombre.Size = new System.Drawing.Size(76, 21);
            this.radionombre.TabIndex = 105;
            this.radionombre.TabStop = true;
            this.radionombre.Text = "Nombre";
            this.radionombre.UseVisualStyleBackColor = true;
            // 
            // radiornc
            // 
            this.radiornc.AutoSize = true;
            this.radiornc.Location = new System.Drawing.Point(739, 87);
            this.radiornc.Margin = new System.Windows.Forms.Padding(4);
            this.radiornc.Name = "radiornc";
            this.radiornc.Size = new System.Drawing.Size(55, 21);
            this.radiornc.TabIndex = 106;
            this.radiornc.TabStop = true;
            this.radiornc.Text = "RNC";
            this.radiornc.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 434);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Estado:";
            // 
            // radioestado
            // 
            this.radioestado.AutoSize = true;
            this.radioestado.Location = new System.Drawing.Point(739, 116);
            this.radioestado.Margin = new System.Windows.Forms.Padding(4);
            this.radioestado.Name = "radioestado";
            this.radioestado.Size = new System.Drawing.Size(70, 21);
            this.radioestado.TabIndex = 110;
            this.radioestado.TabStop = true;
            this.radioestado.Text = "Estado";
            this.radioestado.UseVisualStyleBackColor = true;
            // 
            // comboxestado
            // 
            this.comboxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxestado.FormattingEnabled = true;
            this.comboxestado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.comboxestado.Location = new System.Drawing.Point(30, 465);
            this.comboxestado.Margin = new System.Windows.Forms.Padding(5);
            this.comboxestado.Name = "comboxestado";
            this.comboxestado.Size = new System.Drawing.Size(117, 25);
            this.comboxestado.TabIndex = 111;
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 652);
            this.Controls.Add(this.comboxestado);
            this.Controls.Add(this.radioestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radiornc);
            this.Controls.Add(this.radionombre);
            this.Controls.Add(this.radiocodigo);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.btnLimpiarProv);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.TXTNOMBREPROVVEDOR);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmproveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.frmproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefono;
        private FontAwesome.Sharp.IconButton btnLimpiarProv;
        private FontAwesome.Sharp.IconButton btnBuscarProv;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListadoProveedor;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox TXTNOMBREPROVVEDOR;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.RadioButton radiocodigo;
        private System.Windows.Forms.RadioButton radionombre;
        private System.Windows.Forms.RadioButton radiornc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioestado;
        private System.Windows.Forms.ComboBox comboxestado;
    }
}