namespace Payroll_1.Formularios
{
    partial class Login
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
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            checkBoxAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 117);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(275, 114);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(232, 23);
            txtCorreo.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(275, 168);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(232, 23);
            txtContrasena.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 171);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(275, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(156, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(513, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(445, 218);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(62, 19);
            checkBoxAdmin.TabIndex = 6;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label label2;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private CheckBox checkBoxAdmin;
    }
}