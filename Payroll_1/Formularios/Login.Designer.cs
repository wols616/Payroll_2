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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            checkBoxAdmin = new CheckBox();
            lbl_error = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 286);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(178, 282);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(265, 27);
            txtCorreo.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(178, 354);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(265, 27);
            txtContrasena.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 358);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(178, 415);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(178, 31);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(452, 355);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(373, 421);
            checkBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(75, 24);
            checkBoxAdmin.TabIndex = 6;
            checkBoxAdmin.Text = "Admin";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_error
            // 
            lbl_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_error.ForeColor = Color.Firebrick;
            lbl_error.Location = new Point(1, 498);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(513, 95);
            lbl_error.TabIndex = 7;
            lbl_error.Text = "label3";
            lbl_error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Payroll;
            pictureBox2.Location = new Point(116, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(90, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 593);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_error);
            Controls.Add(checkBoxAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label lbl_error;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}