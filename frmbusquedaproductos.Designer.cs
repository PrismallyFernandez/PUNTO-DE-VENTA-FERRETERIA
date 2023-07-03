namespace Proyecto_Final
{
    partial class frmbusquedaproductos
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
            this.datagridbusquedaproductos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioprecio = new System.Windows.Forms.RadioButton();
            this.radiodescripcion = new System.Windows.Forms.RadioButton();
            this.btnBuscarProd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbusquedaproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridbusquedaproductos
            // 
            this.datagridbusquedaproductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridbusquedaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbusquedaproductos.Location = new System.Drawing.Point(15, 151);
            this.datagridbusquedaproductos.Margin = new System.Windows.Forms.Padding(4);
            this.datagridbusquedaproductos.Name = "datagridbusquedaproductos";
            this.datagridbusquedaproductos.RowHeadersWidth = 51;
            this.datagridbusquedaproductos.RowTemplate.Height = 24;
            this.datagridbusquedaproductos.Size = new System.Drawing.Size(946, 371);
            this.datagridbusquedaproductos.TabIndex = 0;
            this.datagridbusquedaproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbusquedaproductos_CellClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(514, 84);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(312, 27);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "BUSQUEDA DE PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "BUSQUEDA POR ";
            // 
            // radioprecio
            // 
            this.radioprecio.AutoSize = true;
            this.radioprecio.Location = new System.Drawing.Point(338, 100);
            this.radioprecio.Name = "radioprecio";
            this.radioprecio.Size = new System.Drawing.Size(93, 24);
            this.radioprecio.TabIndex = 47;
            this.radioprecio.TabStop = true;
            this.radioprecio.Text = "PRECIO";
            this.radioprecio.UseVisualStyleBackColor = true;
            // 
            // radiodescripcion
            // 
            this.radiodescripcion.AutoSize = true;
            this.radiodescripcion.Location = new System.Drawing.Point(338, 70);
            this.radiodescripcion.Name = "radiodescripcion";
            this.radiodescripcion.Size = new System.Drawing.Size(145, 24);
            this.radiodescripcion.TabIndex = 48;
            this.radiodescripcion.TabStop = true;
            this.radiodescripcion.Text = "DESCRIPCION";
            this.radiodescripcion.UseVisualStyleBackColor = true;
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
            this.btnBuscarProd.Location = new System.Drawing.Point(852, 73);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(92, 49);
            this.btnBuscarProd.TabIndex = 44;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // frmbusquedaproductos
            // 
            this.AcceptButton = this.btnBuscarProd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 562);
            this.Controls.Add(this.radiodescripcion);
            this.Controls.Add(this.radioprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.datagridbusquedaproductos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmbusquedaproductos";
            this.Text = "frmbusquedaproductos";
            this.Load += new System.EventHandler(this.frmbusquedaproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridbusquedaproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridbusquedaproductos;
        private System.Windows.Forms.TextBox txtbuscar;
        private FontAwesome.Sharp.IconButton btnBuscarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioprecio;
        private System.Windows.Forms.RadioButton radiodescripcion;
    }
}