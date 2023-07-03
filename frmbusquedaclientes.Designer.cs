namespace Proyecto_Final
{
    partial class frmbusquedaclientes
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
            this.radionombre = new System.Windows.Forms.RadioButton();
            this.radiocedula = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.datagridbusquedaclientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarcliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbusquedaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // radionombre
            // 
            this.radionombre.AutoSize = true;
            this.radionombre.Location = new System.Drawing.Point(342, 103);
            this.radionombre.Name = "radionombre";
            this.radionombre.Size = new System.Drawing.Size(87, 20);
            this.radionombre.TabIndex = 55;
            this.radionombre.TabStop = true;
            this.radionombre.Text = "NOMBRE";
            this.radionombre.UseVisualStyleBackColor = true;
            // 
            // radiocedula
            // 
            this.radiocedula.AutoSize = true;
            this.radiocedula.Location = new System.Drawing.Point(342, 133);
            this.radiocedula.Name = "radiocedula";
            this.radiocedula.Size = new System.Drawing.Size(82, 20);
            this.radiocedula.TabIndex = 54;
            this.radiocedula.TabStop = true;
            this.radiocedula.Text = "CEDULA";
            this.radiocedula.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "BUSQUEDA POR ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "BUSQUEDA DE CLIENTES";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(518, 117);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(312, 22);
            this.txtbuscar.TabIndex = 50;
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // datagridbusquedaclientes
            // 
            this.datagridbusquedaclientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridbusquedaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbusquedaclientes.Location = new System.Drawing.Point(19, 184);
            this.datagridbusquedaclientes.Margin = new System.Windows.Forms.Padding(4);
            this.datagridbusquedaclientes.Name = "datagridbusquedaclientes";
            this.datagridbusquedaclientes.RowHeadersWidth = 51;
            this.datagridbusquedaclientes.RowTemplate.Height = 24;
            this.datagridbusquedaclientes.Size = new System.Drawing.Size(946, 371);
            this.datagridbusquedaclientes.TabIndex = 49;
            this.datagridbusquedaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbusquedaclientes_CellClick);
            // 
            // btnBuscarcliente
            // 
            this.btnBuscarcliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarcliente.IconColor = System.Drawing.Color.White;
            this.btnBuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarcliente.IconSize = 20;
            this.btnBuscarcliente.Location = new System.Drawing.Point(856, 106);
            this.btnBuscarcliente.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarcliente.Name = "btnBuscarcliente";
            this.btnBuscarcliente.Size = new System.Drawing.Size(92, 49);
            this.btnBuscarcliente.TabIndex = 51;
            this.btnBuscarcliente.UseVisualStyleBackColor = false;
            this.btnBuscarcliente.Click += new System.EventHandler(this.btnBuscarcliente_Click);
            // 
            // frmbusquedaclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 606);
            this.Controls.Add(this.radionombre);
            this.Controls.Add(this.radiocedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarcliente);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.datagridbusquedaclientes);
            this.Name = "frmbusquedaclientes";
            this.Text = "frmbusquedaclientes";
            this.Load += new System.EventHandler(this.frmbusquedaclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbusquedaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radionombre;
        private System.Windows.Forms.RadioButton radiocedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBuscarcliente;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView datagridbusquedaclientes;
    }
}