
namespace Proyecto_Final
{
    partial class frmUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListadoUsuarios = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.comboxsexo = new System.Windows.Forms.ComboBox();
            this.radionbuttomcedula = new System.Windows.Forms.RadioButton();
            this.radiobuttomnombre = new System.Windows.Forms.RadioButton();
            this.radiobuttoncodigo = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.radioestado = new System.Windows.Forms.RadioButton();
            this.comboxestado = new System.Windows.Forms.ComboBox();
            this.comboposicion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 639);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cedula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 394);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Posición";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(40, 80);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 23);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(38, 136);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(36, 238);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(323, 23);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(35, 300);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(5);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(185, 23);
            this.txtcedula.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(38, 515);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(329, 51);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(38, 576);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(329, 51);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Detalle de Empleados";
            // 
            // dgvListadoUsuarios
            // 
            this.dgvListadoUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoUsuarios.Location = new System.Drawing.Point(399, 150);
            this.dgvListadoUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.dgvListadoUsuarios.MultiSelect = false;
            this.dgvListadoUsuarios.Name = "dgvListadoUsuarios";
            this.dgvListadoUsuarios.ReadOnly = true;
            this.dgvListadoUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoUsuarios.RowTemplate.Height = 28;
            this.dgvListadoUsuarios.Size = new System.Drawing.Size(801, 375);
            this.dgvListadoUsuarios.TabIndex = 20;
            this.dgvListadoUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoUsuarios_CellClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(801, 127);
            this.label9.TabIndex = 21;
            this.label9.Text = "Listado de Empleados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(691, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(962, 55);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 23);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(1461, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 39);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1570, 80);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 39);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(35, 328);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Telefono:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(35, 350);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(185, 23);
            this.txttelefono.TabIndex = 28;
            // 
            // comboxsexo
            // 
            this.comboxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxsexo.FormattingEnabled = true;
            this.comboxsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboxsexo.Location = new System.Drawing.Point(39, 186);
            this.comboxsexo.Margin = new System.Windows.Forms.Padding(5);
            this.comboxsexo.Name = "comboxsexo";
            this.comboxsexo.Size = new System.Drawing.Size(119, 25);
            this.comboxsexo.TabIndex = 29;
            // 
            // radionbuttomcedula
            // 
            this.radionbuttomcedula.AutoSize = true;
            this.radionbuttomcedula.Location = new System.Drawing.Point(825, 68);
            this.radionbuttomcedula.Name = "radionbuttomcedula";
            this.radionbuttomcedula.Size = new System.Drawing.Size(81, 21);
            this.radionbuttomcedula.TabIndex = 30;
            this.radionbuttomcedula.TabStop = true;
            this.radionbuttomcedula.Text = "CEDULA";
            this.radionbuttomcedula.UseVisualStyleBackColor = true;
            // 
            // radiobuttomnombre
            // 
            this.radiobuttomnombre.AutoSize = true;
            this.radiobuttomnombre.Location = new System.Drawing.Point(825, 41);
            this.radiobuttomnombre.Name = "radiobuttomnombre";
            this.radiobuttomnombre.Size = new System.Drawing.Size(86, 21);
            this.radiobuttomnombre.TabIndex = 31;
            this.radiobuttomnombre.TabStop = true;
            this.radiobuttomnombre.Text = "NOMBRE";
            this.radiobuttomnombre.UseVisualStyleBackColor = true;
            // 
            // radiobuttoncodigo
            // 
            this.radiobuttoncodigo.AutoSize = true;
            this.radiobuttoncodigo.Location = new System.Drawing.Point(825, 14);
            this.radiobuttoncodigo.Name = "radiobuttoncodigo";
            this.radiobuttoncodigo.Size = new System.Drawing.Size(81, 21);
            this.radiobuttoncodigo.TabIndex = 32;
            this.radiobuttoncodigo.TabStop = true;
            this.radiobuttoncodigo.Text = "CODIGO";
            this.radiobuttoncodigo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(38, 458);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 103;
            this.label12.Text = "ESTADO:";
            // 
            // radioestado
            // 
            this.radioestado.AutoSize = true;
            this.radioestado.Location = new System.Drawing.Point(825, 95);
            this.radioestado.Name = "radioestado";
            this.radioestado.Size = new System.Drawing.Size(83, 21);
            this.radioestado.TabIndex = 105;
            this.radioestado.TabStop = true;
            this.radioestado.Text = "ESTADO";
            this.radioestado.UseVisualStyleBackColor = true;
            // 
            // comboxestado
            // 
            this.comboxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxestado.FormattingEnabled = true;
            this.comboxestado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.comboxestado.Location = new System.Drawing.Point(38, 480);
            this.comboxestado.Margin = new System.Windows.Forms.Padding(5);
            this.comboxestado.Name = "comboxestado";
            this.comboxestado.Size = new System.Drawing.Size(69, 25);
            this.comboxestado.TabIndex = 106;
            // 
            // comboposicion
            // 
            this.comboposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboposicion.FormattingEnabled = true;
            this.comboposicion.Items.AddRange(new object[] {
            "GERENTE",
            "CAJERO",
            "VENDEDOR"});
            this.comboposicion.Location = new System.Drawing.Point(35, 416);
            this.comboposicion.Margin = new System.Windows.Forms.Padding(5);
            this.comboposicion.Name = "comboposicion";
            this.comboposicion.Size = new System.Drawing.Size(185, 25);
            this.comboposicion.TabIndex = 107;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1214, 639);
            this.Controls.Add(this.comboposicion);
            this.Controls.Add(this.comboxestado);
            this.Controls.Add(this.radioestado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radiobuttoncodigo);
            this.Controls.Add(this.radiobuttomnombre);
            this.Controls.Add(this.radionbuttomcedula);
            this.Controls.Add(this.comboxsexo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoUsuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcedula;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListadoUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.ComboBox comboxsexo;
        private System.Windows.Forms.RadioButton radionbuttomcedula;
        private System.Windows.Forms.RadioButton radiobuttomnombre;
        private System.Windows.Forms.RadioButton radiobuttoncodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioestado;
        private System.Windows.Forms.ComboBox comboxestado;
        private System.Windows.Forms.ComboBox comboposicion;
    }
}