
namespace Proyecto_Final
{
    partial class frmFactura
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCondCompra = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.btnBuscarProv = new FontAwesome.Sharp.IconButton();
            this.txtRazonSoc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ttxtCodProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvListadoCompras = new System.Windows.Forms.DataGridView();
            this.CódigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRegCompra = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDocumentoCompra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 483);
            this.label2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Registrar Compras";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDocumentoCompra);
            this.groupBox1.Controls.Add(this.cmbCondCompra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 77);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // cmbCondCompra
            // 
            this.cmbCondCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondCompra.FormattingEnabled = true;
            this.cmbCondCompra.Items.AddRange(new object[] {
            "De Contado",
            "A Crédito"});
            this.cmbCondCompra.Location = new System.Drawing.Point(112, 48);
            this.cmbCondCompra.Name = "cmbCondCompra";
            this.cmbCondCompra.Size = new System.Drawing.Size(126, 23);
            this.cmbCondCompra.TabIndex = 25;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(6, 50);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 21);
            this.txtFecha.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(109, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Condición:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRazonSoc);
            this.groupBox2.Controls.Add(this.btnBuscarProv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNomProv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(432, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 77);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(204, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Razón Social:";
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(6, 50);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(151, 21);
            this.txtNomProv.TabIndex = 24;
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
            this.btnBuscarProv.Location = new System.Drawing.Point(163, 46);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(35, 25);
            this.btnBuscarProv.TabIndex = 26;
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.Location = new System.Drawing.Point(204, 50);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.Size = new System.Drawing.Size(151, 21);
            this.txtRazonSoc.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ttxtCodProd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(67, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 77);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(153, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Producto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 21);
            this.textBox1.TabIndex = 25;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 20;
            this.btnBuscarProducto.Location = new System.Drawing.Point(110, 46);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(35, 25);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Código Producto";
            // 
            // ttxtCodProd
            // 
            this.ttxtCodProd.Location = new System.Drawing.Point(6, 50);
            this.ttxtCodProd.Name = "ttxtCodProd";
            this.ttxtCodProd.Size = new System.Drawing.Size(98, 21);
            this.ttxtCodProd.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(312, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Costo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 21);
            this.textBox2.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(402, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Precio:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(405, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 21);
            this.textBox3.TabIndex = 30;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 21);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(502, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cantidad:";
            // 
            // dgvListadoCompras
            // 
            this.dgvListadoCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoUsuario,
            this.NombreCompleto,
            this.Sexo,
            this.Dirección,
            this.Posición,
            this.ITBIS,
            this.Email});
            this.dgvListadoCompras.Location = new System.Drawing.Point(67, 225);
            this.dgvListadoCompras.MultiSelect = false;
            this.dgvListadoCompras.Name = "dgvListadoCompras";
            this.dgvListadoCompras.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoCompras.RowTemplate.Height = 28;
            this.dgvListadoCompras.Size = new System.Drawing.Size(612, 250);
            this.dgvListadoCompras.TabIndex = 24;
            // 
            // CódigoUsuario
            // 
            this.CódigoUsuario.HeaderText = "Código";
            this.CódigoUsuario.Name = "CódigoUsuario";
            this.CódigoUsuario.ReadOnly = true;
            this.CódigoUsuario.Width = 70;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Producto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 167;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Costo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Precio";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Visible = false;
            this.Dirección.Width = 140;
            // 
            // Posición
            // 
            this.Posición.HeaderText = "Cantidad";
            this.Posición.Name = "Posición";
            this.Posición.ReadOnly = true;
            this.Posición.Width = 80;
            // 
            // ITBIS
            // 
            this.ITBIS.HeaderText = "ITBIS";
            this.ITBIS.Name = "ITBIS";
            this.ITBIS.ReadOnly = true;
            this.ITBIS.Width = 80;
            // 
            // Email
            // 
            this.Email.HeaderText = "Total";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 90;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(685, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 62);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(685, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Monto Total";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(688, 401);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "0";
            // 
            // btnRegCompra
            // 
            this.btnRegCompra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCompra.ForeColor = System.Drawing.Color.White;
            this.btnRegCompra.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.btnRegCompra.IconColor = System.Drawing.Color.AliceBlue;
            this.btnRegCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegCompra.IconSize = 40;
            this.btnRegCompra.Location = new System.Drawing.Point(685, 427);
            this.btnRegCompra.Name = "btnRegCompra";
            this.btnRegCompra.Size = new System.Drawing.Size(124, 48);
            this.btnRegCompra.TabIndex = 28;
            this.btnRegCompra.Text = "Registrar Compra";
            this.btnRegCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegCompra.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(682, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total ITBIS";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(688, 365);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 30;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(688, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(685, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Sub-Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.WhatsApp_Image_2023_03_01_at_6_56_53_PM;
            this.pictureBox1.Location = new System.Drawing.Point(698, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(245, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "No. Documento:";
            // 
            // txtDocumentoCompra
            // 
            this.txtDocumentoCompra.Location = new System.Drawing.Point(245, 50);
            this.txtDocumentoCompra.Name = "txtDocumentoCompra";
            this.txtDocumentoCompra.Size = new System.Drawing.Size(100, 21);
            this.txtDocumentoCompra.TabIndex = 27;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnRegCompra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvListadoCompras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCondCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarProv;
        private System.Windows.Forms.TextBox txtRazonSoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ttxtCodProd;
        private System.Windows.Forms.DataGridView dgvListadoCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posición;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private FontAwesome.Sharp.IconButton btnRegCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDocumentoCompra;
    }
}