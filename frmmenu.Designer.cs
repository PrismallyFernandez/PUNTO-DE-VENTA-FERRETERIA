
namespace Proyecto_Final
{
    partial class frmmenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuVenta = new FontAwesome.Sharp.IconMenuItem();
            this.realizarReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.sUPLIDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuVentas,
            this.menuClientes,
            this.menuReportes,
            this.sUPLIDORESToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(961, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.menuUsuarios.Text = "EMPLEADOS";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVenta,
            this.realizarReciboToolStripMenuItem});
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuVentas.Size = new System.Drawing.Size(152, 69);
            this.menuVentas.Text = "VENTAS";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuVenta
            // 
            this.menuVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuVenta.IconColor = System.Drawing.Color.Black;
            this.menuVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVenta.Name = "menuVenta";
            this.menuVenta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuVenta.Size = new System.Drawing.Size(207, 26);
            this.menuVenta.Text = "Realizar Venta";
            this.menuVenta.Click += new System.EventHandler(this.menuVenta_Click);
            // 
            // realizarReciboToolStripMenuItem
            // 
            this.realizarReciboToolStripMenuItem.Name = "realizarReciboToolStripMenuItem";
            this.realizarReciboToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.realizarReciboToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.realizarReciboToolStripMenuItem.Text = "Realizar Recibo";
            this.realizarReciboToolStripMenuItem.Click += new System.EventHandler(this.realizarReciboToolStripMenuItem_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 69);
            this.menuClientes.Text = "CLIENTES ";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(122, 69);
            this.menuReportes.Text = "REPORTES ";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // sUPLIDORESToolStripMenuItem
            // 
            this.sUPLIDORESToolStripMenuItem.Name = "sUPLIDORESToolStripMenuItem";
            this.sUPLIDORESToolStripMenuItem.Size = new System.Drawing.Size(88, 69);
            this.sUPLIDORESToolStripMenuItem.Text = "SUPLIDORES ";
            this.sUPLIDORESToolStripMenuItem.Click += new System.EventHandler(this.sUPLIDORESToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(89, 69);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS ";
            this.pRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSToolStripMenuItem_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(961, 36);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ferretería Estrella";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 109);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(961, 483);
            this.contenedor.TabIndex = 3;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 592);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem menuVenta;
        private System.Windows.Forms.ToolStripMenuItem sUPLIDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarReciboToolStripMenuItem;
    }
}

