namespace Proyecto_Final
{
    partial class frmrecib
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
            this.txtimprir = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtmontoagregar = new System.Windows.Forms.TextBox();
            this.txtidfactura = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioidfsctura = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiocliente = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtimprir
            // 
            this.txtimprir.Location = new System.Drawing.Point(818, 575);
            this.txtimprir.Name = "txtimprir";
            this.txtimprir.Size = new System.Drawing.Size(100, 31);
            this.txtimprir.TabIndex = 20;
            this.txtimprir.Text = "IMPRIMIR";
            this.txtimprir.UseVisualStyleBackColor = true;
            this.txtimprir.Click += new System.EventHandler(this.txtimprir_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(356, 269);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(134, 22);
            this.txtidcliente.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "AGREGAR ABONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "RECIBO ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID FACTURA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "MONTO";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(356, 209);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(135, 22);
            this.txtmonto.TabIndex = 13;
            // 
            // txtmontoagregar
            // 
            this.txtmontoagregar.Location = new System.Drawing.Point(356, 319);
            this.txtmontoagregar.Name = "txtmontoagregar";
            this.txtmontoagregar.Size = new System.Drawing.Size(134, 22);
            this.txtmontoagregar.TabIndex = 12;
            // 
            // txtidfactura
            // 
            this.txtidfactura.Location = new System.Drawing.Point(356, 150);
            this.txtidfactura.Name = "txtidfactura";
            this.txtidfactura.Size = new System.Drawing.Size(135, 22);
            this.txtidfactura.TabIndex = 11;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(583, 153);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(211, 22);
            this.txtfecha.TabIndex = 21;
            this.txtfecha.TextChanged += new System.EventHandler(this.txtfecha_TextChanged);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(583, 203);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(134, 22);
            this.txttipo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "FECHA CREACION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "TIPO FACTURA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // radioidfsctura
            // 
            this.radioidfsctura.AutoSize = true;
            this.radioidfsctura.Location = new System.Drawing.Point(741, 300);
            this.radioidfsctura.Name = "radioidfsctura";
            this.radioidfsctura.Size = new System.Drawing.Size(108, 20);
            this.radioidfsctura.TabIndex = 26;
            this.radioidfsctura.TabStop = true;
            this.radioidfsctura.Text = "ID FACTURA";
            this.radioidfsctura.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(878, 313);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(134, 22);
            this.txtbuscar.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "BUSCAR POR:";
            // 
            // radiocliente
            // 
            this.radiocliente.AutoSize = true;
            this.radiocliente.Location = new System.Drawing.Point(741, 326);
            this.radiocliente.Name = "radiocliente";
            this.radiocliente.Size = new System.Drawing.Size(100, 20);
            this.radiocliente.TabIndex = 29;
            this.radiocliente.TabStop = true;
            this.radiocliente.Text = "ID CLIENTE";
            this.radiocliente.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(875, 361);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(137, 23);
            this.btnbuscar.TabIndex = 30;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmrecib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 685);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.radiocliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.radioidfsctura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtimprir);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtmontoagregar);
            this.Controls.Add(this.txtidfactura);
            this.Name = "frmrecib";
            this.Text = "frmrecib";
            this.Load += new System.EventHandler(this.frmrecib_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtimprir;
        public System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtmonto;
        public System.Windows.Forms.TextBox txtmontoagregar;
        public System.Windows.Forms.TextBox txtidfactura;
        public System.Windows.Forms.TextBox txtfecha;
        public System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioidfsctura;
        public System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiocliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Timer timer1;
    }
}