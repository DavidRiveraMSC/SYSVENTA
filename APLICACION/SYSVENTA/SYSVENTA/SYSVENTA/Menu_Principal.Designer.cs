
namespace SYSVENTA
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.lblNombre = new System.Windows.Forms.Label();
            this.btn_venta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mOVIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNTRADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUSCARVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uLTIMAVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIERREDELDIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIERREDELDIAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cIERREDELASEMANAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBuscador2 = new System.Windows.Forms.GroupBox();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvbuscador = new System.Windows.Forms.DataGridView();
            this.groupBuscador = new System.Windows.Forms.GroupBox();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_docena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBuscador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscador)).BeginInit();
            this.groupBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNombre.Location = new System.Drawing.Point(533, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(392, 102);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "ARTICULOS RELIGIOSOS\r\nARTES GRAFICAS\r\nEL PORTADOR";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.SeaShell;
            this.btn_venta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_venta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.ForeColor = System.Drawing.Color.Black;
            this.btn_venta.Location = new System.Drawing.Point(164, 193);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(223, 96);
            this.btn_venta.TabIndex = 3;
            this.btn_venta.Text = "VENTA";
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(164, 576);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 96);
            this.button3.TabIndex = 4;
            this.button3.Text = "INVENTARIO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.Color.SeaShell;
            this.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.ForeColor = System.Drawing.Color.Black;
            this.btn_entrada.Location = new System.Drawing.Point(164, 375);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(223, 96);
            this.btn_entrada.TabIndex = 5;
            this.btn_entrada.Text = "ENTRADA";
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.btn_entrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 576);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 375);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIMIENTOSToolStripMenuItem,
            this.vENTASToolStripMenuItem,
            this.cIERREDELDIAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1403, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mOVIMIENTOSToolStripMenuItem
            // 
            this.mOVIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNTRADAToolStripMenuItem,
            this.sALIDAToolStripMenuItem,
            this.vENTAToolStripMenuItem});
            this.mOVIMIENTOSToolStripMenuItem.Name = "mOVIMIENTOSToolStripMenuItem";
            this.mOVIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mOVIMIENTOSToolStripMenuItem.Text = "MOVIMIENTOS";
            // 
            // eNTRADAToolStripMenuItem
            // 
            this.eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            this.eNTRADAToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // sALIDAToolStripMenuItem
            // 
            this.sALIDAToolStripMenuItem.Name = "sALIDAToolStripMenuItem";
            this.sALIDAToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.sALIDAToolStripMenuItem.Text = "SALIDA";
            // 
            // vENTAToolStripMenuItem
            // 
            this.vENTAToolStripMenuItem.Name = "vENTAToolStripMenuItem";
            this.vENTAToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.vENTAToolStripMenuItem.Text = "VENTA";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARVENTAToolStripMenuItem,
            this.uLTIMAVENTAToolStripMenuItem});
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // bUSCARVENTAToolStripMenuItem
            // 
            this.bUSCARVENTAToolStripMenuItem.Name = "bUSCARVENTAToolStripMenuItem";
            this.bUSCARVENTAToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.bUSCARVENTAToolStripMenuItem.Text = "BUSCAR VENTA";
            // 
            // uLTIMAVENTAToolStripMenuItem
            // 
            this.uLTIMAVENTAToolStripMenuItem.Name = "uLTIMAVENTAToolStripMenuItem";
            this.uLTIMAVENTAToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.uLTIMAVENTAToolStripMenuItem.Text = "ULTIMA VENTA";
            // 
            // cIERREDELDIAToolStripMenuItem
            // 
            this.cIERREDELDIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIERREDELDIAToolStripMenuItem1,
            this.cIERREDELASEMANAToolStripMenuItem});
            this.cIERREDELDIAToolStripMenuItem.Name = "cIERREDELDIAToolStripMenuItem";
            this.cIERREDELDIAToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cIERREDELDIAToolStripMenuItem.Text = "CIERRES";
            // 
            // cIERREDELDIAToolStripMenuItem1
            // 
            this.cIERREDELDIAToolStripMenuItem1.Name = "cIERREDELDIAToolStripMenuItem1";
            this.cIERREDELDIAToolStripMenuItem1.Size = new System.Drawing.Size(247, 26);
            this.cIERREDELDIAToolStripMenuItem1.Text = "CIERRE DEL DIA";
            // 
            // cIERREDELASEMANAToolStripMenuItem
            // 
            this.cIERREDELASEMANAToolStripMenuItem.Name = "cIERREDELASEMANAToolStripMenuItem";
            this.cIERREDELASEMANAToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.cIERREDELASEMANAToolStripMenuItem.Text = "CIERRE DE LA SEMANA";
            // 
            // groupBuscador2
            // 
            this.groupBuscador2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBuscador2.Controls.Add(this.txtbuscador);
            this.groupBuscador2.Controls.Add(this.label2);
            this.groupBuscador2.Controls.Add(this.pictureBox1);
            this.groupBuscador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBuscador2.Location = new System.Drawing.Point(599, 175);
            this.groupBuscador2.Name = "groupBuscador2";
            this.groupBuscador2.Size = new System.Drawing.Size(548, 121);
            this.groupBuscador2.TabIndex = 12;
            this.groupBuscador2.TabStop = false;
            // 
            // txtbuscador
            // 
            this.txtbuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbuscador.Location = new System.Drawing.Point(87, 53);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(330, 27);
            this.txtbuscador.TabIndex = 0;
            this.txtbuscador.TextChanged += new System.EventHandler(this.txtbuscador_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Busqueda por Nombre";
            // 
            // dgvbuscador
            // 
            this.dgvbuscador.AllowUserToAddRows = false;
            this.dgvbuscador.AllowUserToDeleteRows = false;
            this.dgvbuscador.AllowUserToResizeColumns = false;
            this.dgvbuscador.AllowUserToResizeRows = false;
            this.dgvbuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvbuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.articulo,
            this.precio_venta,
            this.precio_docena,
            this.existencia,
            this.sucursal});
            this.dgvbuscador.Location = new System.Drawing.Point(26, 34);
            this.dgvbuscador.Name = "dgvbuscador";
            this.dgvbuscador.ReadOnly = true;
            this.dgvbuscador.RowHeadersVisible = false;
            this.dgvbuscador.RowHeadersWidth = 51;
            this.dgvbuscador.RowTemplate.Height = 24;
            this.dgvbuscador.Size = new System.Drawing.Size(911, 292);
            this.dgvbuscador.TabIndex = 11;
            // 
            // groupBuscador
            // 
            this.groupBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBuscador.Controls.Add(this.dgvbuscador);
            this.groupBuscador.Location = new System.Drawing.Point(407, 319);
            this.groupBuscador.Name = "groupBuscador";
            this.groupBuscador.Size = new System.Drawing.Size(965, 353);
            this.groupBuscador.TabIndex = 13;
            this.groupBuscador.TabStop = false;
            // 
            // id_articulo
            // 
            this.id_articulo.DataPropertyName = "id_articulo";
            this.id_articulo.HeaderText = "ID";
            this.id_articulo.MinimumWidth = 6;
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.ReadOnly = true;
            this.id_articulo.Width = 50;
            // 
            // articulo
            // 
            this.articulo.DataPropertyName = "articulo";
            this.articulo.HeaderText = "ARTICULO";
            this.articulo.MinimumWidth = 6;
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Width = 300;
            // 
            // precio_venta
            // 
            this.precio_venta.DataPropertyName = "precio_venta";
            this.precio_venta.HeaderText = "P.VENTA";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Width = 90;
            // 
            // precio_docena
            // 
            this.precio_docena.DataPropertyName = "precio_docena";
            this.precio_docena.HeaderText = "P.DOCENA";
            this.precio_docena.MinimumWidth = 6;
            this.precio_docena.Name = "precio_docena";
            this.precio_docena.ReadOnly = true;
            this.precio_docena.Width = 90;
            // 
            // existencia
            // 
            this.existencia.DataPropertyName = "existencia";
            this.existencia.HeaderText = "EXISTENCIA";
            this.existencia.MinimumWidth = 6;
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            this.existencia.Width = 90;
            // 
            // sucursal
            // 
            this.sucursal.DataPropertyName = "sucursal";
            this.sucursal.HeaderText = "SUCURSAL";
            this.sucursal.MinimumWidth = 6;
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            this.sucursal.Width = 125;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1403, 977);
            this.Controls.Add(this.groupBuscador);
            this.Controls.Add(this.groupBuscador2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_entrada);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_venta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE INVENTARIO Y VENTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBuscador2.ResumeLayout(false);
            this.groupBuscador2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscador)).EndInit();
            this.groupBuscador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mOVIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNTRADAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARVENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uLTIMAVENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIERREDELDIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIERREDELDIAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cIERREDELASEMANAToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBuscador2;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvbuscador;
        private System.Windows.Forms.GroupBox groupBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_docena;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
    }
}

