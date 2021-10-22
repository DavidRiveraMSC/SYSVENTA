
namespace SYSVENTA
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            this.groupBuscador = new System.Windows.Forms.GroupBox();
            this.dgvbuscador = new System.Windows.Forms.DataGridView();
            this.groupBuscador2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_docena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscador)).BeginInit();
            this.groupBuscador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBuscador
            // 
            this.groupBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBuscador.Controls.Add(this.dgvbuscador);
            this.groupBuscador.Location = new System.Drawing.Point(15, 126);
            this.groupBuscador.Name = "groupBuscador";
            this.groupBuscador.Size = new System.Drawing.Size(965, 353);
            this.groupBuscador.TabIndex = 15;
            this.groupBuscador.TabStop = false;
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
            this.dgvbuscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbuscador.Size = new System.Drawing.Size(911, 292);
            this.dgvbuscador.TabIndex = 11;
            this.dgvbuscador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuscador_CellClick);
            this.dgvbuscador.DoubleClick += new System.EventHandler(this.dgvbuscador_DoubleClick);
            // 
            // groupBuscador2
            // 
            this.groupBuscador2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBuscador2.Controls.Add(this.label1);
            this.groupBuscador2.Controls.Add(this.txtbuscador);
            this.groupBuscador2.Controls.Add(this.label2);
            this.groupBuscador2.Controls.Add(this.pictureBox1);
            this.groupBuscador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBuscador2.Location = new System.Drawing.Point(206, -1);
            this.groupBuscador2.Name = "groupBuscador2";
            this.groupBuscador2.Size = new System.Drawing.Size(548, 121);
            this.groupBuscador2.TabIndex = 14;
            this.groupBuscador2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doble Click para Agregar";
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
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 495);
            this.Controls.Add(this.groupBuscador);
            this.Controls.Add(this.groupBuscador2);
            this.Name = "Buscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            this.groupBuscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscador)).EndInit();
            this.groupBuscador2.ResumeLayout(false);
            this.groupBuscador2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBuscador;
        private System.Windows.Forms.DataGridView dgvbuscador;
        private System.Windows.Forms.GroupBox groupBuscador2;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_docena;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
    }
}