﻿namespace Inventario
{
    partial class MenuCliente
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
            this.buttonMusica = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.buttonVideojuegos = new System.Windows.Forms.Button();
            this.ButtonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusica
            // 
            this.buttonMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusica.Location = new System.Drawing.Point(180, 12);
            this.buttonMusica.Name = "buttonMusica";
            this.buttonMusica.Size = new System.Drawing.Size(153, 40);
            this.buttonMusica.TabIndex = 6;
            this.buttonMusica.Text = "Música";
            this.buttonMusica.UseVisualStyleBackColor = true;
            this.buttonMusica.Click += new System.EventHandler(this.buttonMusica_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(350, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Figuras";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(525, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Películas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(695, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Variados";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelVentas
            // 
            this.panelVentas.Location = new System.Drawing.Point(93, 58);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(986, 435);
            this.panelVentas.TabIndex = 11;
            // 
            // buttonVideojuegos
            // 
            this.buttonVideojuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideojuegos.Location = new System.Drawing.Point(12, 12);
            this.buttonVideojuegos.Name = "buttonVideojuegos";
            this.buttonVideojuegos.Size = new System.Drawing.Size(153, 40);
            this.buttonVideojuegos.TabIndex = 12;
            this.buttonVideojuegos.Text = "Videojuegos";
            this.buttonVideojuegos.UseVisualStyleBackColor = true;
            this.buttonVideojuegos.Click += new System.EventHandler(this.buttonVideojuegos_Click);
            // 
            // ButtonVolver
            // 
            this.ButtonVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonVolver.Location = new System.Drawing.Point(12, 461);
            this.ButtonVolver.Name = "ButtonVolver";
            this.ButtonVolver.Size = new System.Drawing.Size(75, 23);
            this.ButtonVolver.TabIndex = 13;
            this.ButtonVolver.Text = "Volver";
            this.ButtonVolver.UseVisualStyleBackColor = true;
            this.ButtonVolver.Click += new System.EventHandler(this.ButtonVolver_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1091, 505);
            this.Controls.Add(this.ButtonVolver);
            this.Controls.Add(this.buttonVideojuegos);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMusica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Button buttonVideojuegos;
        private System.Windows.Forms.Button ButtonVolver;
    }
}