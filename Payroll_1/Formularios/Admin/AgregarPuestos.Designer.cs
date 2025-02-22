namespace Payroll_1.Formularios.Admin
{
    partial class AgregarPuestos
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
            label1 = new Label();
            textBox1 = new TextBox();
            cbxCategoria = new ComboBox();
            label2 = new Label();
            txtSueldoBase = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 163);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del puesto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 2;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(162, 103);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(177, 23);
            cbxCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Location = new Point(354, 103);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(100, 23);
            txtSueldoBase.TabIndex = 5;
            txtSueldoBase.Text = "Sueldo Base";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(264, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 56);
            label3.Name = "label3";
            label3.Size = new Size(255, 32);
            label3.TabIndex = 7;
            label3.Text = "Agregar Nuevo Puesto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AgregarPuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 277);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtSueldoBase);
            Controls.Add(label2);
            Controls.Add(cbxCategoria);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AgregarPuestos";
            Text = "AgregarPuestos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox cbxCategoria;
        private Label label2;
        private TextBox txtSueldoBase;
        private Button btnAgregar;
        private Label label3;
        private PictureBox pictureBox1;
    }
}