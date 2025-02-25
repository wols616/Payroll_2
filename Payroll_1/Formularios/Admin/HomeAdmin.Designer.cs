namespace Payroll_1.Formularios
{
    partial class HomeAdmin
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
            btnGestionarEmpleados = new Button();
            btnGestionarPuestoCategoria = new Button();
            btnGestionarContratos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGestionarEmpleados
            // 
            btnGestionarEmpleados.Location = new Point(214, 95);
            btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            btnGestionarEmpleados.Size = new Size(270, 23);
            btnGestionarEmpleados.TabIndex = 0;
            btnGestionarEmpleados.Text = "Gestionar Empleados";
            btnGestionarEmpleados.UseVisualStyleBackColor = true;
            btnGestionarEmpleados.Click += btnGestionarEmpleados_Click;
            // 
            // btnGestionarPuestoCategoria
            // 
            btnGestionarPuestoCategoria.Location = new Point(214, 151);
            btnGestionarPuestoCategoria.Name = "btnGestionarPuestoCategoria";
            btnGestionarPuestoCategoria.Size = new Size(270, 23);
            btnGestionarPuestoCategoria.TabIndex = 1;
            btnGestionarPuestoCategoria.Text = "Gestionar Puestos y Categorias";
            btnGestionarPuestoCategoria.UseVisualStyleBackColor = true;
            btnGestionarPuestoCategoria.Click += btnGestionarPuestoCategoria_Click;
            // 
            // btnGestionarContratos
            // 
            btnGestionarContratos.Location = new Point(214, 214);
            btnGestionarContratos.Name = "btnGestionarContratos";
            btnGestionarContratos.Size = new Size(270, 23);
            btnGestionarContratos.TabIndex = 2;
            btnGestionarContratos.Text = "Gestionar Contratos";
            btnGestionarContratos.UseVisualStyleBackColor = true;
            btnGestionarContratos.Click += btnGestionarContratos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logOut;
            pictureBox1.Location = new Point(613, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 344);
            Controls.Add(pictureBox1);
            Controls.Add(btnGestionarContratos);
            Controls.Add(btnGestionarPuestoCategoria);
            Controls.Add(btnGestionarEmpleados);
            Name = "HomeAdmin";
            Text = "HomeAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarEmpleados;
        private Button btnGestionarPuestoCategoria;
        private Button btnGestionarContratos;
        private PictureBox pictureBox1;
    }
}