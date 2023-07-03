namespace Proyecto_Final
{
    partial class frmclientess
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
            this.txtCedClien = new System.Windows.Forms.TextBox();
            this.btnLimpiarCliente = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtTelClien = new System.Windows.Forms.TextBox();
            this.txtDireccionClien = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbuttoncodigo = new System.Windows.Forms.RadioButton();
            this.radiobuttonnombre = new System.Windows.Forms.RadioButton();
            this.radiobuttocedula = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioestado = new System.Windows.Forms.RadioButton();
            this.comboxestado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedClien
            // 
            this.txtCedClien.Location = new System.Drawing.Point(16, 251);
            this.txtCedClien.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedClien.Name = "txtCedClien";
            this.txtCedClien.Size = new System.Drawing.Size(205, 23);
            this.txtCedClien.TabIndex = 76;
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
            this.btnLimpiarCliente.Location = new System.Drawing.Point(1451, 82);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(74, 39);
            this.btnLimpiarCliente.TabIndex = 75;
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(1169, 58);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(74, 39);
            this.btnBuscarCliente.TabIndex = 74;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(908, 66);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 23);
            this.txtBuscar.TabIndex = 73;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(643, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Buscar por:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(853, 137);
            this.label9.TabIndex = 70;
            this.label9.Text = "Listado de Clientes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(418, 151);
            this.dgvListadoClientes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvListadoClientes.MultiSelect = false;
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            this.dgvListadoClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoClientes.RowTemplate.Height = 28;
            this.dgvListadoClientes.Size = new System.Drawing.Size(851, 337);
            this.dgvListadoClientes.TabIndex = 69;
            this.dgvListadoClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoClientes_CellClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Detalle de Clientes";
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
            this.btnEditar.Location = new System.Drawing.Point(10, 602);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(329, 51);
            this.btnEditar.TabIndex = 66;
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
            this.btnGuardar.Location = new System.Drawing.Point(10, 541);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(329, 51);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtTelClien
            // 
            this.txtTelClien.Location = new System.Drawing.Point(18, 403);
            this.txtTelClien.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelClien.Name = "txtTelClien";
            this.txtTelClien.Size = new System.Drawing.Size(231, 23);
            this.txtTelClien.TabIndex = 64;
            // 
            // txtDireccionClien
            // 
            this.txtDireccionClien.Location = new System.Drawing.Point(18, 325);
            this.txtDireccionClien.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccionClien.Name = "txtDireccionClien";
            this.txtDireccionClien.Size = new System.Drawing.Size(323, 23);
            this.txtDireccionClien.TabIndex = 63;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(16, 185);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(323, 23);
            this.txtNombreCliente.TabIndex = 62;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(18, 118);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(135, 23);
            this.txtCodigoCliente.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "No. Cédula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 381);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Código Cliente:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 669);
            this.label1.TabIndex = 55;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdbuttoncodigo
            // 
            this.rdbuttoncodigo.AutoSize = true;
            this.rdbuttoncodigo.Location = new System.Drawing.Point(763, 24);
            this.rdbuttoncodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbuttoncodigo.Name = "rdbuttoncodigo";
            this.rdbuttoncodigo.Size = new System.Drawing.Size(70, 21);
            this.rdbuttoncodigo.TabIndex = 77;
            this.rdbuttoncodigo.TabStop = true;
            this.rdbuttoncodigo.Text = "Codigo";
            this.rdbuttoncodigo.UseVisualStyleBackColor = true;
            // 
            // radiobuttonnombre
            // 
            this.radiobuttonnombre.AutoSize = true;
            this.radiobuttonnombre.Location = new System.Drawing.Point(763, 53);
            this.radiobuttonnombre.Margin = new System.Windows.Forms.Padding(4);
            this.radiobuttonnombre.Name = "radiobuttonnombre";
            this.radiobuttonnombre.Size = new System.Drawing.Size(76, 21);
            this.radiobuttonnombre.TabIndex = 78;
            this.radiobuttonnombre.TabStop = true;
            this.radiobuttonnombre.Text = "Nombre";
            this.radiobuttonnombre.UseVisualStyleBackColor = true;
            // 
            // radiobuttocedula
            // 
            this.radiobuttocedula.AutoSize = true;
            this.radiobuttocedula.Location = new System.Drawing.Point(763, 82);
            this.radiobuttocedula.Margin = new System.Windows.Forms.Padding(4);
            this.radiobuttocedula.Name = "radiobuttocedula";
            this.radiobuttocedula.Size = new System.Drawing.Size(70, 21);
            this.radiobuttocedula.TabIndex = 79;
            this.radiobuttocedula.TabStop = true;
            this.radiobuttocedula.Text = "Cedula";
            this.radiobuttocedula.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "Estado:";
            // 
            // radioestado
            // 
            this.radioestado.AutoSize = true;
            this.radioestado.Location = new System.Drawing.Point(763, 111);
            this.radioestado.Margin = new System.Windows.Forms.Padding(4);
            this.radioestado.Name = "radioestado";
            this.radioestado.Size = new System.Drawing.Size(70, 21);
            this.radioestado.TabIndex = 82;
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
            this.comboxestado.Location = new System.Drawing.Point(21, 485);
            this.comboxestado.Margin = new System.Windows.Forms.Padding(5);
            this.comboxestado.Name = "comboxestado";
            this.comboxestado.Size = new System.Drawing.Size(145, 25);
            this.comboxestado.TabIndex = 83;
            // 
            // frmclientess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 669);
            this.Controls.Add(this.comboxestado);
            this.Controls.Add(this.radioestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radiobuttocedula);
            this.Controls.Add(this.radiobuttonnombre);
            this.Controls.Add(this.rdbuttoncodigo);
            this.Controls.Add(this.txtCedClien);
            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTelClien);
            this.Controls.Add(this.txtDireccionClien);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmclientess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.frmclientess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedClien;
        private FontAwesome.Sharp.IconButton btnLimpiarCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtTelClien;
        private System.Windows.Forms.TextBox txtDireccionClien;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbuttoncodigo;
        private System.Windows.Forms.RadioButton radiobuttonnombre;
        private System.Windows.Forms.RadioButton radiobuttocedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioestado;
        private System.Windows.Forms.ComboBox comboxestado;
    }
}