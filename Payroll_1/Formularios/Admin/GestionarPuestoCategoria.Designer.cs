﻿namespace Payroll_1.Formularios.Admin
{
    partial class GestionarPuestoCategoria
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
            btnCategorias = new Button();
            btnGestionarPuestos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(310, 218);
            btnCategorias.Margin = new Padding(3, 4, 3, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(159, 31);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Gestionar Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnGestionarPuestos
            // 
            btnGestionarPuestos.Location = new Point(310, 294);
            btnGestionarPuestos.Margin = new Padding(3, 4, 3, 4);
            btnGestionarPuestos.Name = "btnGestionarPuestos";
            btnGestionarPuestos.Size = new Size(159, 31);
            btnGestionarPuestos.TabIndex = 1;
            btnGestionarPuestos.Text = "Gestionar Puestos";
            btnGestionarPuestos.UseVisualStyleBackColor = true;
            btnGestionarPuestos.Click += btnGestionarPuestos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GestionarPuestoCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 543);
            Controls.Add(pictureBox1);
            Controls.Add(btnGestionarPuestos);
            Controls.Add(btnCategorias);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionarPuestoCategoria";
            Text = "GestionarPuestoCategoria";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private Button btnGestionarPuestos;
        private PictureBox pictureBox1;
    }
}