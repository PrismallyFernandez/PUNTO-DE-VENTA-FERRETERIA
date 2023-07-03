
namespace Proyecto_Final
{
    partial class frmReporteVentas
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
            this.txtBuscarReporteVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReporteVentas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarReporte = new FontAwesome.Sharp.IconButton();
            this.btnBuscarReporte = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radiocodigofactura = new System.Windows.Forms.RadioButton();
            this.radiomonto = new System.Windows.Forms.RadioButton();
            this.radiofecha = new System.Windows.Forms.RadioButton();
            this.radiocliente = new System.Windows.Forms.RadioButton();
            this.radiotipo = new System.Windows.Forms.RadioButton();
            this.datatimedesde = new System.Windows.Forms.DateTimePicker();
            this.datetimehasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarReporteVenta
            // 
            this.txtBuscarReporteVenta.Location = new System.Drawing.Point(418, 234);
            this.txtBuscarReporteVenta.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarReporteVenta.Name = "txtBuscarReporteVenta";
            this.txtBuscarReporteVenta.Size = new System.Drawing.Size(333, 23);
            this.txtBuscarReporteVenta.TabIndex = 54;
            this.txtBuscarReporteVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarReporteVenta_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Buscar por:";
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Location = new System.Drawing.Point(120, 319);
            this.dgvReporteVentas.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReporteVentas.MultiSelect = false;
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.ReadOnly = true;
            this.dgvReporteVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReporteVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReporteVentas.RowTemplate.Height = 28;
            this.dgvReporteVentas.Size = new System.Drawing.Size(957, 307);
            this.dgvReporteVentas.TabIndex = 48;
            this.dgvReporteVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteVentas_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1132, 557);
            this.label3.TabIndex = 47;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Reporte de Ventas";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(877, 112);
            this.label9.TabIndex = 39;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnLimpiarReporte.Location = new System.Drawing.Point(930, 227);
            this.btnLimpiarReporte.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarReporte.Name = "btnLimpiarReporte";
            this.btnLimpiarReporte.Size = new System.Drawing.Size(141, 39);
            this.btnLimpiarReporte.TabIndex = 53;
            this.btnLimpiarReporte.Text = "Limpiar";
            this.btnLimpiarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarReporte.UseVisualStyleBackColor = false;
            this.btnLimpiarReporte.Click += new System.EventHandler(this.btnLimpiarReporte_Click);
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
            this.btnBuscarReporte.Location = new System.Drawing.Point(761, 228);
            this.btnBuscarReporte.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(141, 39);
            this.btnBuscarReporte.TabIndex = 52;
            this.btnBuscarReporte.Text = "Buscar";
            this.btnBuscarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarReporte.UseVisualStyleBackColor = false;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(930, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // radiocodigofactura
            // 
            this.radiocodigofactura.AutoSize = true;
            this.radiocodigofactura.Location = new System.Drawing.Point(260, 182);
            this.radiocodigofactura.Name = "radiocodigofactura";
            this.radiocodigofactura.Size = new System.Drawing.Size(119, 21);
            this.radiocodigofactura.TabIndex = 55;
            this.radiocodigofactura.TabStop = true;
            this.radiocodigofactura.Text = "NO. FACTURA";
            this.radiocodigofactura.UseVisualStyleBackColor = true;
            // 
            // radiomonto
            // 
            this.radiomonto.AutoSize = true;
            this.radiomonto.Location = new System.Drawing.Point(260, 209);
            this.radiomonto.Name = "radiomonto";
            this.radiomonto.Size = new System.Drawing.Size(78, 21);
            this.radiomonto.TabIndex = 56;
            this.radiomonto.TabStop = true;
            this.radiomonto.Text = "MONTO";
            this.radiomonto.UseVisualStyleBackColor = true;
            // 
            // radiofecha
            // 
            this.radiofecha.AutoSize = true;
            this.radiofecha.Location = new System.Drawing.Point(260, 236);
            this.radiofecha.Name = "radiofecha";
            this.radiofecha.Size = new System.Drawing.Size(71, 21);
            this.radiofecha.TabIndex = 57;
            this.radiofecha.TabStop = true;
            this.radiofecha.Text = "FECHA";
            this.radiofecha.UseVisualStyleBackColor = true;
            // 
            // radiocliente
            // 
            this.radiocliente.AutoSize = true;
            this.radiocliente.Location = new System.Drawing.Point(260, 263);
            this.radiocliente.Name = "radiocliente";
            this.radiocliente.Size = new System.Drawing.Size(83, 21);
            this.radiocliente.TabIndex = 58;
            this.radiocliente.TabStop = true;
            this.radiocliente.Text = "CLIENTE";
            this.radiocliente.UseVisualStyleBackColor = true;
            // 
            // radiotipo
            // 
            this.radiotipo.AutoSize = true;
            this.radiotipo.Location = new System.Drawing.Point(260, 290);
            this.radiotipo.Name = "radiotipo";
            this.radiotipo.Size = new System.Drawing.Size(58, 21);
            this.radiotipo.TabIndex = 59;
            this.radiotipo.TabStop = true;
            this.radiotipo.Text = "TIPO";
            this.radiotipo.UseVisualStyleBackColor = true;
            // 
            // datatimedesde
            // 
            this.datatimedesde.Location = new System.Drawing.Point(260, 73);
            this.datatimedesde.Name = "datatimedesde";
            this.datatimedesde.Size = new System.Drawing.Size(305, 23);
            this.datatimedesde.TabIndex = 60;
            // 
            // datetimehasta
            // 
            this.datetimehasta.Location = new System.Drawing.Point(581, 73);
            this.datetimehasta.Name = "datetimehasta";
            this.datetimehasta.Size = new System.Drawing.Size(309, 23);
            this.datetimehasta.TabIndex = 61;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 642);
            this.Controls.Add(this.datetimehasta);
            this.Controls.Add(this.datatimedesde);
            this.Controls.Add(this.radiotipo);
            this.Controls.Add(this.radiocliente);
            this.Controls.Add(this.radiofecha);
            this.Controls.Add(this.radiomonto);
            this.Controls.Add(this.radiocodigofactura);
            this.Controls.Add(this.txtBuscarReporteVenta);
            this.Controls.Add(this.btnLimpiarReporte);
            this.Controls.Add(this.btnBuscarReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReporteVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarReporteVenta;
        private FontAwesome.Sharp.IconButton btnLimpiarReporte;
        private FontAwesome.Sharp.IconButton btnBuscarReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radiocodigofactura;
        private System.Windows.Forms.RadioButton radiomonto;
        private System.Windows.Forms.RadioButton radiofecha;
        private System.Windows.Forms.RadioButton radiocliente;
        private System.Windows.Forms.RadioButton radiotipo;
        public System.Windows.Forms.DataGridView dgvReporteVentas;
        private System.Windows.Forms.DateTimePicker datatimedesde;
        private System.Windows.Forms.DateTimePicker datetimehasta;
    }
}