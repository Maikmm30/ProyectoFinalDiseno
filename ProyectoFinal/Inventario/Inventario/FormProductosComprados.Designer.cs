﻿namespace Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFech = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIDCompra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbCantidadNueva = new System.Windows.Forms.Label();
            this.lbCantidadsumada = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFech
            // 
            this.txtFech.AutoSize = true;
            this.txtFech.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFech.ForeColor = System.Drawing.Color.White;
            this.txtFech.Location = new System.Drawing.Point(359, 155);
            this.txtFech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFech.Name = "txtFech";
            this.txtFech.Size = new System.Drawing.Size(68, 22);
            this.txtFech.TabIndex = 0;
            this.txtFech.Text = "Fecha";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(357, 292);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 22);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Precio";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(357, 230);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(99, 22);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Cantidad";
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
            this.txtCantidad.Location = new System.Drawing.Point(548, 213);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(379, 34);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.OnValueChanged += new System.EventHandler(this.txtCantidad_OnValueChanged);
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
            this.txtCosto.Location = new System.Drawing.Point(548, 261);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(379, 34);
            this.txtCosto.TabIndex = 11;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCosto.OnValueChanged += new System.EventHandler(this.txtCosto_OnValueChanged);
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(1097, 332);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(169, 42);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(1097, 178);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(169, 42);
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
            this.btnEditar.Location = new System.Drawing.Point(1097, 254);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(169, 42);
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
            this.txtMarca.Location = new System.Drawing.Point(548, 322);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(379, 34);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.OnValueChanged += new System.EventHandler(this.txtMarca_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(357, 343);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 22);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "PRODUCTOS COMPRADOS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(363, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 80);
            this.panel1.TabIndex = 22;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.AllowUserToAddRows = false;
            this.dataGridViewProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducto.GridColor = System.Drawing.Color.White;
            this.dataGridViewProducto.Location = new System.Drawing.Point(364, 469);
            this.dataGridViewProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducto.RowHeadersWidth = 51;
            this.dataGridViewProducto.RowTemplate.Height = 24;
            this.dataGridViewProducto.Size = new System.Drawing.Size(925, 255);
            this.dataGridViewProducto.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 155);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBuscar
            // 
            this.textBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBuscar.ForeColor = System.Drawing.Color.White;
            this.textBuscar.HintForeColor = System.Drawing.Color.White;
            this.textBuscar.HintText = "Buscar";
            this.textBuscar.isPassword = false;
            this.textBuscar.LineFocusedColor = System.Drawing.Color.White;
            this.textBuscar.LineIdleColor = System.Drawing.Color.White;
            this.textBuscar.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.textBuscar.LineThickness = 2;
            this.textBuscar.Location = new System.Drawing.Point(783, 426);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(507, 36);
            this.textBuscar.TabIndex = 26;
            this.textBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBuscar.OnValueChanged += new System.EventHandler(this.textBuscar_OnValueChanged);
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIDCompra.ForeColor = System.Drawing.Color.White;
            this.txtIDCompra.HintForeColor = System.Drawing.Color.White;
            this.txtIDCompra.HintText = "ID Compra";
            this.txtIDCompra.isPassword = false;
            this.txtIDCompra.LineFocusedColor = System.Drawing.Color.White;
            this.txtIDCompra.LineIdleColor = System.Drawing.Color.White;
            this.txtIDCompra.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.txtIDCompra.LineThickness = 2;
            this.txtIDCompra.Location = new System.Drawing.Point(548, 380);
            this.txtIDCompra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.Size = new System.Drawing.Size(379, 36);
            this.txtIDCompra.TabIndex = 27;
            this.txtIDCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDCompra.OnValueChanged += new System.EventHandler(this.txtIDCompra_OnValueChanged);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.BackColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(908, 27);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(0, 17);
            this.lbCantidad.TabIndex = 28;
            this.lbCantidad.Click += new System.EventHandler(this.lbCantidad_Click);
            // 
            // lbCantidadNueva
            // 
            this.lbCantidadNueva.AutoSize = true;
            this.lbCantidadNueva.BackColor = System.Drawing.Color.White;
            this.lbCantidadNueva.Location = new System.Drawing.Point(984, 27);
            this.lbCantidadNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidadNueva.Name = "lbCantidadNueva";
            this.lbCantidadNueva.Size = new System.Drawing.Size(0, 17);
            this.lbCantidadNueva.TabIndex = 29;
            // 
            // lbCantidadsumada
            // 
            this.lbCantidadsumada.AutoSize = true;
            this.lbCantidadsumada.BackColor = System.Drawing.Color.White;
            this.lbCantidadsumada.Location = new System.Drawing.Point(1053, 27);
            this.lbCantidadsumada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidadsumada.Name = "lbCantidadsumada";
            this.lbCantidadsumada.Size = new System.Drawing.Size(0, 17);
            this.lbCantidadsumada.TabIndex = 30;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(357, 391);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 22);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "ID de la compra";
            // 
            // FormProductosComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1379, 737);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lbCantidadsumada);
            this.Controls.Add(this.lbCantidadNueva);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.txtIDCompra);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtFech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDCompra;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbCantidadNueva;
        private System.Windows.Forms.Label lbCantidadsumada;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}