
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
            this.btnLimpiarCliente = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
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
            this.txtCedClien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
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
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(59, 31);
            this.btnBuscarCliente.TabIndex = 50;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
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
            this.dgvListadoClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(351, 128);
            this.dgvListadoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoClientes.MultiSelect = false;
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            this.dgvListadoClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoClientes.RowTemplate.Height = 28;
            this.dgvListadoClientes.Size = new System.Drawing.Size(895, 434);
            this.dgvListadoClientes.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Detalle de Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnEliminar.IconSize = 21;
            this.btnEliminar.Location = new System.Drawing.Point(28, 522);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(263, 41);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(28, 474);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(263, 41);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(28, 425);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(263, 41);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelClien
            // 
            this.txtTelClien.Location = new System.Drawing.Point(28, 378);
            this.txtTelClien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelClien.Name = "txtTelClien";
            this.txtTelClien.Size = new System.Drawing.Size(259, 22);
            this.txtTelClien.TabIndex = 37;
            // 
            // txtDireccionClien
            // 
            this.txtDireccionClien.Location = new System.Drawing.Point(28, 321);
            this.txtDireccionClien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionClien.Name = "txtDireccionClien";
            this.txtDireccionClien.Size = new System.Drawing.Size(259, 22);
            this.txtDireccionClien.TabIndex = 36;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(28, 148);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(259, 22);
            this.txtNombreCliente.TabIndex = 35;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(29, 94);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(259, 22);
            this.txtCodigoCliente.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "No. Cédula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código Cliente:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 591);
            this.label1.TabIndex = 27;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCedClien
            // 
            this.txtCedClien.Location = new System.Drawing.Point(28, 256);
            this.txtCedClien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedClien.Name = "txtCedClien";
            this.txtCedClien.Size = new System.Drawing.Size(259, 22);
            this.txtCedClien.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Sexo:";
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(28, 194);
            this.txtsexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(259, 22);
            this.txtsexo.TabIndex = 55;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 591);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedClien);
            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscarCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnEliminar;
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
        private System.Windows.Forms.TextBox txtCedClien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsexo;
    }
}