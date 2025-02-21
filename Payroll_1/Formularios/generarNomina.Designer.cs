namespace Payroll_1.Formularios
{
    partial class generarNomina
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
            dgvEmpleados = new DataGridView();
            dgvDeducciones = new DataGridView();
            cbxDeducciones = new ComboBox();
            btnAsignar = new Button();
            btnRegresar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            txtSueldoBase = new Label();
            txtSalarioNeto = new Label();
            txtTotalDeducciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(80, 75);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(723, 200);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            dgvEmpleados.MouseClick += dgvEmpleados_MouseClick;
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(80, 393);
            dgvDeducciones.Margin = new Padding(3, 4, 3, 4);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(466, 200);
            dgvDeducciones.TabIndex = 1;
            // 
            // cbxDeducciones
            // 
            cbxDeducciones.FormattingEnabled = true;
            cbxDeducciones.Location = new Point(665, 393);
            cbxDeducciones.Margin = new Padding(3, 4, 3, 4);
            cbxDeducciones.Name = "cbxDeducciones";
            cbxDeducciones.Size = new Size(138, 28);
            cbxDeducciones.TabIndex = 2;
            cbxDeducciones.SelectedValueChanged += cbxDeducciones_SelectedValueChanged;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(665, 445);
            btnAsignar.Margin = new Padding(3, 4, 3, 4);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(138, 31);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 13);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(102, 34);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 51);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 369);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 7;
            label2.Text = "Deducciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 620);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 8;
            label3.Text = "Complementos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 644);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 200);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(80, 905);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(466, 200);
            dataGridView2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 881);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 10;
            label4.Text = "Percepciones";
            label4.Click += label4_Click;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.AutoSize = true;
            txtSueldoBase.Location = new Point(680, 292);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(93, 20);
            txtSueldoBase.TabIndex = 12;
            txtSueldoBase.Tag = "";
            txtSueldoBase.Text = "Sueldo Base:";
            // 
            // txtSalarioNeto
            // 
            txtSalarioNeto.AutoSize = true;
            txtSalarioNeto.Location = new Point(665, 573);
            txtSalarioNeto.Name = "txtSalarioNeto";
            txtSalarioNeto.Size = new Size(95, 20);
            txtSalarioNeto.TabIndex = 13;
            txtSalarioNeto.Text = "Salario Neto:";
            // 
            // txtTotalDeducciones
            // 
            txtTotalDeducciones.AutoSize = true;
            txtTotalDeducciones.Location = new Point(462, 597);
            txtTotalDeducciones.Name = "txtTotalDeducciones";
            txtTotalDeducciones.Size = new Size(45, 20);
            txtTotalDeducciones.TabIndex = 14;
            txtTotalDeducciones.Text = "Total:";
            // 
            // generarNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(914, 1085);
            Controls.Add(txtTotalDeducciones);
            Controls.Add(txtSalarioNeto);
            Controls.Add(txtSueldoBase);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(btnAsignar);
            Controls.Add(cbxDeducciones);
            Controls.Add(dgvDeducciones);
            Controls.Add(dgvEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "generarNomina";
            Text = "generarNomina";
            Load += asignarDeduccionesEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DataGridView dgvDeducciones;
        private ComboBox cbxDeducciones;
        private Button btnAsignar;
        private Button btnRegresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Label txtSueldoBase;
        private Label txtSalarioNeto;
        private Label txtTotalDeducciones;
    }
}