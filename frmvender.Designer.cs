namespace Proyecto_Final
{
    partial class frmvender
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconbuttomborrartodo = new FontAwesome.Sharp.IconButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRegVenta = new FontAwesome.Sharp.IconButton();
            this.dgvListadoVentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ttxtCodProd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigcliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocVenta = new System.Windows.Forms.TextBox();
            this.cmbCondVenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconbuttomborrartodo
            // 
            this.iconbuttomborrartodo.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconbuttomborrartodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbuttomborrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbuttomborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbuttomborrartodo.ForeColor = System.Drawing.Color.White;
            this.iconbuttomborrartodo.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconbuttomborrartodo.IconColor = System.Drawing.Color.White;
            this.iconbuttomborrartodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbuttomborrartodo.IconSize = 35;
            this.iconbuttomborrartodo.Location = new System.Drawing.Point(887, 268);
            this.iconbuttomborrartodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconbuttomborrartodo.Name = "iconbuttomborrartodo";
            this.iconbuttomborrartodo.Size = new System.Drawing.Size(151, 60);
            this.iconbuttomborrartodo.TabIndex = 69;
            this.iconbuttomborrartodo.Text = "BORRAR TODO";
            this.iconbuttomborrartodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconbuttomborrartodo.UseVisualStyleBackColor = false;
            this.iconbuttomborrartodo.Click += new System.EventHandler(this.iconbuttomborrartodo_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(884, 461);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 15);
            this.label20.TabIndex = 68;
            this.label20.Text = "DEVUELTA";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(884, 401);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 15);
            this.label21.TabIndex = 67;
            this.label21.Text = "EFECTIVO";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(886, 427);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(150, 20);
            this.txtEfectivo.TabIndex = 66;
            this.txtEfectivo.Text = "0";
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevuelta.Location = new System.Drawing.Point(886, 487);
            this.txtDevuelta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.Size = new System.Drawing.Size(150, 20);
            this.txtDevuelta.TabIndex = 65;
            this.txtDevuelta.Text = "0";
            this.txtDevuelta.TextChanged += new System.EventHandler(this.txtDevuelta_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(885, 366);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(150, 20);
            this.txtSubTotal.TabIndex = 64;
            this.txtSubTotal.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(885, 349);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Sub-Total";
            // 
            // btnRegVenta
            // 
            this.btnRegVenta.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegVenta.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnRegVenta.IconColor = System.Drawing.Color.AliceBlue;
            this.btnRegVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegVenta.IconSize = 40;
            this.btnRegVenta.Location = new System.Drawing.Point(885, 523);
            this.btnRegVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegVenta.Name = "btnRegVenta";
            this.btnRegVenta.Size = new System.Drawing.Size(151, 60);
            this.btnRegVenta.TabIndex = 62;
            this.btnRegVenta.Text = "Registrar Venta";
            this.btnRegVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegVenta.UseVisualStyleBackColor = false;
            this.btnRegVenta.Click += new System.EventHandler(this.btnRegVenta_Click);
            // 
            // dgvListadoVentas
            // 
            this.dgvListadoVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.PRECIO,
            this.SUBTOTAL});
            this.dgvListadoVentas.Location = new System.Drawing.Point(64, 291);
            this.dgvListadoVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoVentas.MultiSelect = false;
            this.dgvListadoVentas.Name = "dgvListadoVentas";
            this.dgvListadoVentas.ReadOnly = true;
            this.dgvListadoVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoVentas.RowTemplate.Height = 28;
            this.dgvListadoVentas.Size = new System.Drawing.Size(814, 320);
            this.dgvListadoVentas.TabIndex = 61;
            this.dgvListadoVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVentas_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 125;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 125;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.MinimumWidth = 6;
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            this.SUBTOTAL.Width = 125;
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
            this.btnAgregar.Location = new System.Drawing.Point(888, 203);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 57);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtProd);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.ttxtCodProd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(63, 194);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(814, 97);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(663, 63);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(102, 21);
            this.txtcantidad.TabIndex = 33;
            this.txtcantidad.Text = "1";
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(689, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Cantidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(560, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(537, 63);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(102, 21);
            this.txtPrecio.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(200, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Producto:";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(192, 63);
            this.txtProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(313, 21);
            this.txtProd.TabIndex = 25;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 20;
            this.btnBuscarProducto.Location = new System.Drawing.Point(135, 61);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(54, 24);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.Text = "F";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            this.btnBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBuscarProducto_KeyDown_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Código Producto";
            // 
            // ttxtCodProd
            // 
            this.ttxtCodProd.Location = new System.Drawing.Point(8, 63);
            this.ttxtCodProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ttxtCodProd.Name = "ttxtCodProd";
            this.ttxtCodProd.Size = new System.Drawing.Size(121, 21);
            this.ttxtCodProd.TabIndex = 24;
            this.ttxtCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttxtCodProd_KeyDown_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomCliente);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcodigcliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(525, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(514, 97);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo:";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(230, 60);
            this.txtNomCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(231, 21);
            this.txtNomCliente.TabIndex = 25;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 20;
            this.btnBuscarCliente.Location = new System.Drawing.Point(139, 57);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(56, 26);
            this.btnBuscarCliente.TabIndex = 26;
            this.btnBuscarCliente.Text = "C";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            this.btnBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBuscarCliente_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID CLIENTE:";
            // 
            // txtcodigcliente
            // 
            this.txtcodigcliente.Location = new System.Drawing.Point(10, 60);
            this.txtcodigcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigcliente.Name = "txtcodigcliente";
            this.txtcodigcliente.Size = new System.Drawing.Size(86, 21);
            this.txtcodigcliente.TabIndex = 24;
            this.txtcodigcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigcliente_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDocVenta);
            this.groupBox1.Controls.Add(this.cmbCondVenta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFechaVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(454, 97);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Ventas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(292, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "No. Documento";
            // 
            // txtDocVenta
            // 
            this.txtDocVenta.Location = new System.Drawing.Point(292, 63);
            this.txtDocVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocVenta.Name = "txtDocVenta";
            this.txtDocVenta.Size = new System.Drawing.Size(139, 21);
            this.txtDocVenta.TabIndex = 36;
            // 
            // cmbCondVenta
            // 
            this.cmbCondVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondVenta.FormattingEnabled = true;
            this.cmbCondVenta.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.cmbCondVenta.Location = new System.Drawing.Point(154, 60);
            this.cmbCondVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCondVenta.Name = "cmbCondVenta";
            this.cmbCondVenta.Size = new System.Drawing.Size(127, 23);
            this.cmbCondVenta.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(151, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Condición:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(8, 63);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(139, 21);
            this.txtFechaVenta.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Registrar Ventas";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1010, 583);
            this.label2.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(498, 306);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 53;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmvender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 661);
            this.Controls.Add(this.iconbuttomborrartodo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.txtDevuelta);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnRegVenta);
            this.Controls.Add(this.dgvListadoVentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmvender";
            this.Text = "frmvender";
            this.Load += new System.EventHandler(this.frmvender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVentas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbuttomborrartodo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnRegVenta;
        private System.Windows.Forms.DataGridView dgvListadoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtProd;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox ttxtCodProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNomCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcodigcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDocVenta;
        public System.Windows.Forms.ComboBox cmbCondVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}