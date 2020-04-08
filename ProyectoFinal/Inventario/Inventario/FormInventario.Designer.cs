namespace Inventario
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDepartamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.HintForeColor = System.Drawing.Color.White;
            this.txtId.HintText = "Ingrese ID Producto";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtId.LineIdleColor = System.Drawing.Color.White;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtId.LineThickness = 2;
            this.txtId.Location = new System.Drawing.Point(1049, 117);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(337, 36);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.HintForeColor = System.Drawing.Color.White;
            this.txtDescripcion.HintText = "Descripcion ";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.White;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.White;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtDescripcion.LineThickness = 2;
            this.txtDescripcion.Location = new System.Drawing.Point(1049, 174);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(337, 36);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Eliminar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(1043, 618);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Nuevo";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(1223, 618);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Buscar";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(1223, 565);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton23.TabIndex = 8;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepartamento.ForeColor = System.Drawing.Color.White;
            this.txtDepartamento.HintForeColor = System.Drawing.Color.White;
            this.txtDepartamento.HintText = "Categoria";
            this.txtDepartamento.isPassword = false;
            this.txtDepartamento.LineFocusedColor = System.Drawing.Color.White;
            this.txtDepartamento.LineIdleColor = System.Drawing.Color.White;
            this.txtDepartamento.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtDepartamento.LineThickness = 2;
            this.txtDepartamento.Location = new System.Drawing.Point(1049, 235);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(337, 36);
            this.txtDepartamento.TabIndex = 9;
            this.txtDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintForeColor = System.Drawing.Color.White;
            this.txtPrecio.HintText = "Precio";
            this.txtPrecio.isPassword = false;
            this.txtPrecio.LineFocusedColor = System.Drawing.Color.White;
            this.txtPrecio.LineIdleColor = System.Drawing.Color.White;
            this.txtPrecio.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtPrecio.LineThickness = 2;
            this.txtPrecio.Location = new System.Drawing.Point(1049, 293);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(337, 36);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.HintForeColor = System.Drawing.Color.White;
            this.txtProveedor.HintText = "Proveedor";
            this.txtProveedor.isPassword = false;
            this.txtProveedor.LineFocusedColor = System.Drawing.Color.White;
            this.txtProveedor.LineIdleColor = System.Drawing.Color.White;
            this.txtProveedor.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtProveedor.LineThickness = 2;
            this.txtProveedor.Location = new System.Drawing.Point(1049, 354);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(337, 36);
            this.txtProveedor.TabIndex = 11;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "Marca";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(1049, 418);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(337, 36);
            this.bunifuMaterialTextbox1.TabIndex = 13;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(419, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "INVENTARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuThinButton24.ButtonText = "Editar";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(1049, 565);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(149, 41);
            this.bunifuThinButton24.TabIndex = 15;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(303, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 90);
            this.panel1.TabIndex = 16;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(285, 145);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.RowHeadersWidth = 51;
            this.dataGridViewProducto.RowTemplate.Height = 24;
            this.dataGridViewProducto.Size = new System.Drawing.Size(721, 436);
            this.dataGridViewProducto.TabIndex = 17;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintText = "Cantidad";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.White;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.White;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtCantidad.LineThickness = 2;
            this.txtCantidad.Location = new System.Drawing.Point(1049, 488);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(337, 36);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.OnValueChanged += new System.EventHandler(this.txtCantidad_OnValueChanged);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1404, 737);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDepartamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
    }
}