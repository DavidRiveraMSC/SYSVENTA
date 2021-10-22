
namespace SYSVENTA
{
    partial class Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtidventa = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdetalleventa = new System.Windows.Forms.DataGridView();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleventa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID VENTA";
            // 
            // txtidventa
            // 
            this.txtidventa.Enabled = false;
            this.txtidventa.Location = new System.Drawing.Point(107, 58);
            this.txtidventa.Name = "txtidventa";
            this.txtidventa.Size = new System.Drawing.Size(52, 22);
            this.txtidventa.TabIndex = 1;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(268, 58);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(159, 22);
            this.txtfecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(367, 506);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 8;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(120, 506);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtsubtotal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "SUBTOTAL";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(13, 107);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 42);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "AGREGAR ARTICULO";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOTAL";
            // 
            // dgvdetalleventa
            // 
            this.dgvdetalleventa.AllowUserToAddRows = false;
            this.dgvdetalleventa.AllowUserToResizeRows = false;
            this.dgvdetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.articulo,
            this.precio_venta,
            this.cantidad});
            this.dgvdetalleventa.Location = new System.Drawing.Point(13, 172);
            this.dgvdetalleventa.MultiSelect = false;
            this.dgvdetalleventa.Name = "dgvdetalleventa";
            this.dgvdetalleventa.RowHeadersWidth = 51;
            this.dgvdetalleventa.RowTemplate.Height = 24;
            this.dgvdetalleventa.Size = new System.Drawing.Size(853, 304);
            this.dgvdetalleventa.TabIndex = 4;
            this.dgvdetalleventa.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalleventa_CellValueChanged);
            this.dgvdetalleventa.SelectionChanged += new System.EventHandler(this.dgvdetalleventa_SelectionChanged);
            // 
            // id_articulo
            // 
            this.id_articulo.HeaderText = "ID";
            this.id_articulo.MinimumWidth = 6;
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.ReadOnly = true;
            this.id_articulo.Width = 50;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "ARTICULO";
            this.articulo.MinimumWidth = 6;
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Width = 250;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "P.VENTA";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(738, 534);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(128, 42);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "GUARDAR VENTA";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "VENTA DE ARTICULOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "VENTA",
            "PENDIENTE"});
            this.cmbestado.Location = new System.Drawing.Point(727, 58);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 24);
            this.cmbestado.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ESTADO";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvdetalleventa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidventa);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidventa;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvdetalleventa;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label3;
    }
}