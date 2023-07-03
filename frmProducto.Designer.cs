
namespace Proyecto_Final
{
    partial class frmProducto
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
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCostoProd = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.Label();
            this.txtCódProd = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.Label();
            this.txtEstProd = new System.Windows.Forms.Label();
            this.comboxsuplidor = new System.Windows.Forms.ComboBox();
            this.radiocodigo = new System.Windows.Forms.RadioButton();
            this.radiobuttondescripcion = new System.Windows.Forms.RadioButton();
            this.btnEditarProd = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProd = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarProd = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.radioestado = new System.Windows.Forms.RadioButton();
            this.comboxestado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(808, 99);
            this.label9.TabIndex = 39;
            this.label9.Text = "Listado de Productos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(415, 145);
            this.dgvListadoProductos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvListadoProductos.MultiSelect = false;
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.ReadOnly = true;
            this.dgvListadoProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoProductos.RowTemplate.Height = 28;
            this.dgvListadoProductos.Size = new System.Drawing.Size(804, 398);
            this.dgvListadoProductos.TabIndex = 38;
            this.dgvListadoProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellClick);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(881, 75);
            this.txtBuscarProd.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(215, 23);
            this.txtBuscarProd.TabIndex = 42;
            this.txtBuscarProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProd_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(623, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Detalle de Producto";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(35, 231);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(126, 23);
            this.txtcosto.TabIndex = 55;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(35, 158);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(323, 23);
            this.txtdescripcion.TabIndex = 54;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(35, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(152, 23);
            this.txtCodigo.TabIndex = 52;
            // 
            // txtCostoProd
            // 
            this.txtCostoProd.AutoSize = true;
            this.txtCostoProd.BackColor = System.Drawing.Color.White;
            this.txtCostoProd.Location = new System.Drawing.Point(39, 198);
            this.txtCostoProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtCostoProd.Name = "txtCostoProd";
            this.txtCostoProd.Size = new System.Drawing.Size(48, 17);
            this.txtCostoProd.TabIndex = 50;
            this.txtCostoProd.Text = "Costo:";
            // 
            // txtDescProd
            // 
            this.txtDescProd.AutoSize = true;
            this.txtDescProd.BackColor = System.Drawing.Color.White;
            this.txtDescProd.Location = new System.Drawing.Point(38, 136);
            this.txtDescProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(82, 17);
            this.txtDescProd.TabIndex = 49;
            this.txtDescProd.Text = "Descripción";
            // 
            // txtNomProd
            // 
            this.txtNomProd.AutoSize = true;
            this.txtNomProd.BackColor = System.Drawing.Color.White;
            this.txtNomProd.Location = new System.Drawing.Point(36, 345);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(64, 17);
            this.txtNomProd.TabIndex = 47;
            this.txtNomProd.Text = "Suplidor:";
            // 
            // txtCódProd
            // 
            this.txtCódProd.AutoSize = true;
            this.txtCódProd.BackColor = System.Drawing.Color.White;
            this.txtCódProd.Location = new System.Drawing.Point(36, 75);
            this.txtCódProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtCódProd.Name = "txtCódProd";
            this.txtCódProd.Size = new System.Drawing.Size(56, 17);
            this.txtCódProd.TabIndex = 46;
            this.txtCódProd.Text = "Código:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(35, 301);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(126, 23);
            this.txtprecio.TabIndex = 64;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.AutoSize = true;
            this.txtPrecioProd.BackColor = System.Drawing.Color.White;
            this.txtPrecioProd.Location = new System.Drawing.Point(35, 276);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(52, 17);
            this.txtPrecioProd.TabIndex = 63;
            this.txtPrecioProd.Text = "Precio:";
            // 
            // txtEstProd
            // 
            this.txtEstProd.AutoSize = true;
            this.txtEstProd.BackColor = System.Drawing.Color.White;
            this.txtEstProd.Location = new System.Drawing.Point(35, 409);
            this.txtEstProd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtEstProd.Name = "txtEstProd";
            this.txtEstProd.Size = new System.Drawing.Size(56, 17);
            this.txtEstProd.TabIndex = 65;
            this.txtEstProd.Text = "Estado:";
            // 
            // comboxsuplidor
            // 
            this.comboxsuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxsuplidor.FormattingEnabled = true;
            this.comboxsuplidor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboxsuplidor.Location = new System.Drawing.Point(35, 367);
            this.comboxsuplidor.Margin = new System.Windows.Forms.Padding(5);
            this.comboxsuplidor.Name = "comboxsuplidor";
            this.comboxsuplidor.Size = new System.Drawing.Size(277, 25);
            this.comboxsuplidor.TabIndex = 67;
            // 
            // radiocodigo
            // 
            this.radiocodigo.AutoSize = true;
            this.radiocodigo.Location = new System.Drawing.Point(739, 48);
            this.radiocodigo.Name = "radiocodigo";
            this.radiocodigo.Size = new System.Drawing.Size(81, 21);
            this.radiocodigo.TabIndex = 68;
            this.radiocodigo.TabStop = true;
            this.radiocodigo.Text = "CODIGO";
            this.radiocodigo.UseVisualStyleBackColor = true;
            // 
            // radiobuttondescripcion
            // 
            this.radiobuttondescripcion.AutoSize = true;
            this.radiobuttondescripcion.Location = new System.Drawing.Point(739, 75);
            this.radiobuttondescripcion.Name = "radiobuttondescripcion";
            this.radiobuttondescripcion.Size = new System.Drawing.Size(118, 21);
            this.radiobuttondescripcion.TabIndex = 69;
            this.radiobuttondescripcion.TabStop = true;
            this.radiobuttondescripcion.Text = "DESCRIPCION";
            this.radiobuttondescripcion.UseVisualStyleBackColor = true;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.Color.White;
            this.btnEditarProd.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarProd.IconColor = System.Drawing.Color.White;
            this.btnEditarProd.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnEditarProd.IconSize = 25;
            this.btnEditarProd.Location = new System.Drawing.Point(35, 527);
            this.btnEditarProd.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(329, 51);
            this.btnEditarProd.TabIndex = 60;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuardarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProd.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProd.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarProd.IconColor = System.Drawing.Color.White;
            this.btnGuardarProd.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnGuardarProd.IconSize = 25;
            this.btnGuardarProd.Location = new System.Drawing.Point(35, 466);
            this.btnGuardarProd.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(329, 51);
            this.btnGuardarProd.TabIndex = 59;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProd.UseVisualStyleBackColor = false;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click);
            // 
            // btnLimpiarProd
            // 
            this.btnLimpiarProd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProd.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarProd.IconColor = System.Drawing.Color.White;
            this.btnLimpiarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProd.IconSize = 20;
            this.btnLimpiarProd.Location = new System.Drawing.Point(1419, 89);
            this.btnLimpiarProd.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarProd.Name = "btnLimpiarProd";
            this.btnLimpiarProd.Size = new System.Drawing.Size(74, 39);
            this.btnLimpiarProd.TabIndex = 44;
            this.btnLimpiarProd.UseVisualStyleBackColor = false;
            this.btnLimpiarProd.Click += new System.EventHandler(this.btnLimpiarProd_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProd.IconColor = System.Drawing.Color.White;
            this.btnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProd.IconSize = 20;
            this.btnBuscarProd.Location = new System.Drawing.Point(1106, 67);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(74, 39);
            this.btnBuscarProd.TabIndex = 43;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // radioestado
            // 
            this.radioestado.AutoSize = true;
            this.radioestado.Location = new System.Drawing.Point(739, 107);
            this.radioestado.Name = "radioestado";
            this.radioestado.Size = new System.Drawing.Size(83, 21);
            this.radioestado.TabIndex = 71;
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
            this.comboxestado.Location = new System.Drawing.Point(35, 431);
            this.comboxestado.Margin = new System.Windows.Forms.Padding(5);
            this.comboxestado.Name = "comboxestado";
            this.comboxestado.Size = new System.Drawing.Size(100, 25);
            this.comboxestado.TabIndex = 84;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 587);
            this.Controls.Add(this.comboxestado);
            this.Controls.Add(this.radioestado);
            this.Controls.Add(this.radiobuttondescripcion);
            this.Controls.Add(this.radiocodigo);
            this.Controls.Add(this.comboxsuplidor);
            this.Controls.Add(this.txtEstProd);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnGuardarProd);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCostoProd);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.txtCódProd);
            this.Controls.Add(this.btnLimpiarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoProductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private FontAwesome.Sharp.IconButton btnLimpiarProd;
        private FontAwesome.Sharp.IconButton btnBuscarProd;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEditarProd;
        private FontAwesome.Sharp.IconButton btnGuardarProd;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label txtCostoProd;
        private System.Windows.Forms.Label txtDescProd;
        private System.Windows.Forms.Label txtNomProd;
        private System.Windows.Forms.Label txtCódProd;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label txtPrecioProd;
        private System.Windows.Forms.Label txtEstProd;
        private System.Windows.Forms.ComboBox comboxsuplidor;
        private System.Windows.Forms.RadioButton radiocodigo;
        private System.Windows.Forms.RadioButton radiobuttondescripcion;
        private System.Windows.Forms.RadioButton radioestado;
        private System.Windows.Forms.ComboBox comboxestado;
    }
}