namespace Inventario
{
    partial class FormProductosComprados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductosComprados));
            this.txtFech = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFech
            // 
            this.txtFech.AutoSize = true;
            this.txtFech.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(57)))));
            this.txtFech.Location = new System.Drawing.Point(239, 150);
            this.txtFech.Name = "txtFech";
            this.txtFech.Size = new System.Drawing.Size(55, 20);
            this.txtFech.TabIndex = 0;
            this.txtFech.Text = "Fecha";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(57)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(240, 272);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(56, 20);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Precio";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(57)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(239, 230);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Cantidad";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(57)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(239, 193);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(97, 20);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "ID Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.HintForeColor = System.Drawing.Color.White;
            this.txtProducto.HintText = "";
            this.txtProducto.isPassword = false;
            this.txtProducto.LineFocusedColor = System.Drawing.Color.White;
            this.txtProducto.LineIdleColor = System.Drawing.Color.White;
            this.txtProducto.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtProducto.LineThickness = 1;
            this.txtProducto.Location = new System.Drawing.Point(365, 186);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(379, 28);
            this.txtProducto.TabIndex = 9;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintForeColor = System.Drawing.Color.White;
            this.txtCantidad.HintText = "";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.White;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.White;
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtCantidad.LineThickness = 1;
            this.txtCantidad.Location = new System.Drawing.Point(365, 234);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(379, 28);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCosto
            // 
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.HintForeColor = System.Drawing.Color.White;
            this.txtCosto.HintText = "";
            this.txtCosto.isPassword = false;
            this.txtCosto.LineFocusedColor = System.Drawing.Color.White;
            this.txtCosto.LineIdleColor = System.Drawing.Color.White;
            this.txtCosto.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtCosto.LineThickness = 1;
            this.txtCosto.Location = new System.Drawing.Point(365, 277);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(379, 28);
            this.txtCosto.TabIndex = 11;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(813, 215);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(163, 34);
            this.bunifuThinButton23.TabIndex = 15;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(813, 258);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(163, 34);
            this.bunifuThinButton22.TabIndex = 14;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(813, 301);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(163, 34);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveBorderThickness = 1;
            this.btnEditar.ActiveCornerRadius = 20;
            this.btnEditar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.IdleBorderThickness = 1;
            this.btnEditar.IdleCornerRadius = 20;
            this.btnEditar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEditar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEditar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.Location = new System.Drawing.Point(813, 169);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.HintForeColor = System.Drawing.Color.White;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.White;
            this.txtMarca.LineIdleColor = System.Drawing.Color.White;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtMarca.LineThickness = 1;
            this.txtMarca.Location = new System.Drawing.Point(365, 321);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(379, 28);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(57)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(239, 321);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "PRODUCTOS COMPRADOS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(272, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 65);
            this.panel1.TabIndex = 22;
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.HintForeColor = System.Drawing.Color.White;
            this.txtFecha.HintText = "";
            this.txtFecha.isPassword = false;
            this.txtFecha.LineFocusedColor = System.Drawing.Color.White;
            this.txtFecha.LineIdleColor = System.Drawing.Color.White;
            this.txtFecha.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtFecha.LineThickness = 1;
            this.txtFecha.Location = new System.Drawing.Point(365, 140);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(379, 28);
            this.txtFecha.TabIndex = 23;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(218, 382);
            this.dataGridViewProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.RowHeadersWidth = 51;
            this.dataGridViewProducto.RowTemplate.Height = 24;
            this.dataGridViewProducto.Size = new System.Drawing.Size(798, 207);
            this.dataGridViewProducto.TabIndex = 24;
            // 
            // FormProductosComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1053, 599);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtFech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductosComprados";
            this.Text = "FormProductosComprados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel txtFech;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProducto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFecha;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
    }
}