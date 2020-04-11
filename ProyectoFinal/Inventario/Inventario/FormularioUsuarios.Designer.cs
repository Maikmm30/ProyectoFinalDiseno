﻿namespace Inventario
{
    partial class FormularioUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioUsuarios));
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBusca = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtNyA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCargo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintText = "Nombre Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.White;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.White;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtUsuario.LineThickness = 2;
            this.txtUsuario.Location = new System.Drawing.Point(692, 289);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 33);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HintForeColor = System.Drawing.Color.White;
            this.txtContraseña.HintText = "Ingrese Contraseña";
            this.txtContraseña.isPassword = false;
            this.txtContraseña.LineFocusedColor = System.Drawing.Color.White;
            this.txtContraseña.LineIdleColor = System.Drawing.Color.White;
            this.txtContraseña.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtContraseña.LineThickness = 2;
            this.txtContraseña.Location = new System.Drawing.Point(692, 339);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(183, 33);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // btnBusca
            // 
            this.btnBusca.ActiveBorderThickness = 1;
            this.btnBusca.ActiveCornerRadius = 20;
            this.btnBusca.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBusca.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnBusca.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnBusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusca.BackgroundImage")));
            this.btnBusca.ButtonText = "Buscar";
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBusca.IdleBorderThickness = 1;
            this.btnBusca.IdleCornerRadius = 20;
            this.btnBusca.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnBusca.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBusca.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBusca.Location = new System.Drawing.Point(638, 422);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(99, 34);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBusca.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Editar";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEdit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(759, 422);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 20;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 20;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.Location = new System.Drawing.Point(638, 470);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "USUARIOS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(252, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 73);
            this.panel1.TabIndex = 16;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(109, 133);
            this.dataGridViewProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.RowHeadersWidth = 51;
            this.dataGridViewProducto.RowTemplate.Height = 24;
            this.dataGridViewProducto.Size = new System.Drawing.Size(564, 266);
            this.dataGridViewProducto.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Location = new System.Drawing.Point(759, 470);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNyA
            // 
            this.txtNyA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNyA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNyA.ForeColor = System.Drawing.Color.White;
            this.txtNyA.HintForeColor = System.Drawing.Color.White;
            this.txtNyA.HintText = "Nombre y Apellidos";
            this.txtNyA.isPassword = false;
            this.txtNyA.LineFocusedColor = System.Drawing.Color.White;
            this.txtNyA.LineIdleColor = System.Drawing.Color.White;
            this.txtNyA.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtNyA.LineThickness = 2;
            this.txtNyA.Location = new System.Drawing.Point(692, 133);
            this.txtNyA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNyA.Name = "txtNyA";
            this.txtNyA.Size = new System.Drawing.Size(183, 33);
            this.txtNyA.TabIndex = 19;
            this.txtNyA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCelular
            // 
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.HintForeColor = System.Drawing.Color.White;
            this.txtCelular.HintText = "Celular";
            this.txtCelular.isPassword = false;
            this.txtCelular.LineFocusedColor = System.Drawing.Color.White;
            this.txtCelular.LineIdleColor = System.Drawing.Color.White;
            this.txtCelular.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCelular.LineThickness = 2;
            this.txtCelular.Location = new System.Drawing.Point(692, 237);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(183, 33);
            this.txtCelular.TabIndex = 20;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCargo
            // 
            this.txtCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.HintForeColor = System.Drawing.Color.White;
            this.txtCargo.HintText = "Cargo";
            this.txtCargo.isPassword = false;
            this.txtCargo.LineFocusedColor = System.Drawing.Color.White;
            this.txtCargo.LineIdleColor = System.Drawing.Color.White;
            this.txtCargo.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCargo.LineThickness = 2;
            this.txtCargo.Location = new System.Drawing.Point(692, 180);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(183, 33);
            this.txtCargo.TabIndex = 21;
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNyA);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioUsuarios";
            this.Text = "FormularioUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContraseña;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBusca;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNyA;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCelular;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCargo;
    }
}