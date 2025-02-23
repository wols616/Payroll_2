namespace Payroll_1.Formularios
{
    partial class GestionarEmpleados
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
            txt_DUI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ncuenta = new TextBox();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Apellidos = new TextBox();
            txt_Nombre = new TextBox();
            btn_Guardar = new Button();
            btn_Modificar = new Button();
            dgvEmpleados = new DataGridView();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtContrasena = new TextBox();
            label8 = new Label();
            btnGenerarContrasena = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_DUI
            // 
            txt_DUI.Location = new Point(245, 70);
            txt_DUI.Margin = new Padding(3, 2, 3, 2);
            txt_DUI.Name = "txt_DUI";
            txt_DUI.Size = new Size(255, 23);
            txt_DUI.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 75);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "DUI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 319);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "N° Cuenta Corriente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 268);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 219);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 173);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 119);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // txt_Ncuenta
            // 
            txt_Ncuenta.Location = new Point(245, 314);
            txt_Ncuenta.Margin = new Padding(3, 2, 3, 2);
            txt_Ncuenta.Name = "txt_Ncuenta";
            txt_Ncuenta.Size = new Size(255, 23);
            txt_Ncuenta.TabIndex = 12;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(245, 263);
            txt_Direccion.Margin = new Padding(3, 2, 3, 2);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(255, 23);
            txt_Direccion.TabIndex = 13;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(245, 214);
            txt_Telefono.Margin = new Padding(3, 2, 3, 2);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(255, 23);
            txt_Telefono.TabIndex = 14;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(245, 167);
            txt_Apellidos.Margin = new Padding(3, 2, 3, 2);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(255, 23);
            txt_Apellidos.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(245, 114);
            txt_Nombre.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(255, 23);
            txt_Nombre.TabIndex = 16;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(37, 495);
            btn_Guardar.Margin = new Padding(3, 2, 3, 2);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(129, 34);
            btn_Guardar.TabIndex = 17;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += button1_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(196, 495);
            btn_Modificar.Margin = new Padding(3, 2, 3, 2);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(129, 34);
            btn_Modificar.TabIndex = 18;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += button2_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(0, 63);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(688, 440);
            dgvEmpleados.TabIndex = 19;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(245, 370);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(255, 23);
            txtCorreo.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 375);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 22;
            label7.Text = "Correo:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(245, 428);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(255, 23);
            txtContrasena.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 433);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 24;
            label8.Text = "Contraseña:";
            // 
            // btnGenerarContrasena
            // 
            btnGenerarContrasena.Location = new Point(425, 456);
            btnGenerarContrasena.Name = "btnGenerarContrasena";
            btnGenerarContrasena.Size = new Size(75, 23);
            btnGenerarContrasena.TabIndex = 26;
            btnGenerarContrasena.Text = "Generar";
            btnGenerarContrasena.UseVisualStyleBackColor = true;
            btnGenerarContrasena.Click += btnGenerarContrasena_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvEmpleados);
            panel1.Location = new Point(524, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 531);
            panel1.TabIndex = 27;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 555);
            Controls.Add(pictureBox1);
            Controls.Add(btnGenerarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(label8);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Guardar);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Apellidos);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Ncuenta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_DUI);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionarEmpleados";
            Text = "agregarEmpleado";
            Load += agregarEmpleado_Load;
            MouseClick += agregarEmpleado_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DUI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ncuenta;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Apellidos;
        private TextBox txt_Nombre;
        private Button btn_Guardar;
        private Button btn_Modificar;
        private DataGridView dgvEmpleados;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtContrasena;
        private Label label8;
        private Button btnGenerarContrasena;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}