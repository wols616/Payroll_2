namespace Payroll_1.Formularios
{
    partial class agregarEmpleado
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
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txt_DUI
            // 
            txt_DUI.Location = new Point(276, 76);
            txt_DUI.Name = "txt_DUI";
            txt_DUI.Size = new Size(291, 27);
            txt_DUI.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 83);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 6;
            label1.Text = "DUI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 408);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "N° Cuenta Corriente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 340);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 8;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 275);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 213);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 142);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // txt_Ncuenta
            // 
            txt_Ncuenta.Location = new Point(276, 401);
            txt_Ncuenta.Name = "txt_Ncuenta";
            txt_Ncuenta.Size = new Size(291, 27);
            txt_Ncuenta.TabIndex = 12;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(276, 333);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(291, 27);
            txt_Direccion.TabIndex = 13;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(276, 268);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(291, 27);
            txt_Telefono.TabIndex = 14;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(276, 206);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(291, 27);
            txt_Apellidos.TabIndex = 15;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(276, 135);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(291, 27);
            txt_Nombre.TabIndex = 16;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(57, 503);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(234, 45);
            btn_Guardar.TabIndex = 17;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += button1_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(320, 503);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(234, 45);
            btn_Modificar.TabIndex = 18;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += button2_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(716, 59);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(786, 539);
            dgvEmpleados.TabIndex = 19;
            // 
            // agregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 861);
            Controls.Add(dgvEmpleados);
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
            Name = "agregarEmpleado";
            Text = "agregarEmpleado";
            Load += agregarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
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
    }
}