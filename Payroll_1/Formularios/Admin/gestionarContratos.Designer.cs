namespace Payroll_1.Formularios
{
    partial class gestionarContratos
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
            label2 = new Label();
            dgvEmpleados = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            cbxPuesto = new ComboBox();
            btn_crear = new Button();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            label9 = new Label();
            dgvContratos = new DataGridView();
            pictureBox1 = new PictureBox();
            labelCategoria = new Label();
            labelSueldoBase = new Label();
            dtpFechaAlta = new DateTimePicker();
            dtpFechaBaja = new DateTimePicker();
            txtCategoria = new TextBox();
            txtSueldoBase = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 30);
            label1.Name = "label1";
            label1.Size = new Size(299, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestionar contratos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(55, 60);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar empleado";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(55, 90);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(904, 141);
            dgvEmpleados.TabIndex = 2;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(55, 233);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Datos de contrato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(55, 284);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Fecha de alta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(400, 283);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 6;
            label6.Text = "Fecha de baja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(743, 285);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Puesto";
            // 
            // cbxPuesto
            // 
            cbxPuesto.FormattingEnabled = true;
            cbxPuesto.Location = new Point(842, 280);
            cbxPuesto.Margin = new Padding(3, 2, 3, 2);
            cbxPuesto.Name = "cbxPuesto";
            cbxPuesto.Size = new Size(117, 23);
            cbxPuesto.TabIndex = 13;
            cbxPuesto.SelectedValueChanged += cbxPuesto_SelectedValueChanged;
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(366, 374);
            btn_crear.Margin = new Padding(3, 2, 3, 2);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(82, 22);
            btn_crear.TabIndex = 14;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(453, 374);
            btn_actualizar.Margin = new Padding(3, 2, 3, 2);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(82, 22);
            btn_actualizar.TabIndex = 15;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(541, 374);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(82, 22);
            btn_eliminar.TabIndex = 16;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 407);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 17;
            label9.Text = "Contratos";
            // 
            // dgvContratos
            // 
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(55, 424);
            dgvContratos.Margin = new Padding(3, 2, 3, 2);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.RowHeadersWidth = 51;
            dgvContratos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContratos.Size = new Size(887, 143);
            dgvContratos.TabIndex = 18;
            dgvContratos.SelectionChanged += dgvContratos_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelCategoria.Location = new Point(743, 331);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(76, 20);
            labelCategoria.TabIndex = 21;
            labelCategoria.Text = "Categoria";
            // 
            // labelSueldoBase
            // 
            labelSueldoBase.AutoSize = true;
            labelSueldoBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelSueldoBase.Location = new Point(743, 374);
            labelSueldoBase.Name = "labelSueldoBase";
            labelSueldoBase.Size = new Size(93, 20);
            labelSueldoBase.TabIndex = 22;
            labelSueldoBase.Text = "Sueldo Base";
            labelSueldoBase.Click += labelSueldoBase_Click;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(161, 284);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(200, 23);
            dtpFechaAlta.TabIndex = 23;
            dtpFechaAlta.ValueChanged += dtpFechaAlta_ValueChanged;
            // 
            // dtpFechaBaja
            // 
            dtpFechaBaja.Location = new Point(518, 283);
            dtpFechaBaja.Name = "dtpFechaBaja";
            dtpFechaBaja.Size = new Size(200, 23);
            dtpFechaBaja.TabIndex = 24;
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.Font = new Font("Segoe UI", 11.25F);
            txtCategoria.Location = new Point(842, 324);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(117, 27);
            txtCategoria.TabIndex = 25;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Font = new Font("Segoe UI", 11.25F);
            txtSueldoBase.Location = new Point(842, 355);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(117, 27);
            txtSueldoBase.TabIndex = 26;
            // 
            // gestionarContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 610);
            Controls.Add(txtSueldoBase);
            Controls.Add(txtCategoria);
            Controls.Add(dtpFechaBaja);
            Controls.Add(dtpFechaAlta);
            Controls.Add(labelSueldoBase);
            Controls.Add(labelCategoria);
            Controls.Add(pictureBox1);
            Controls.Add(dgvContratos);
            Controls.Add(label9);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_crear);
            Controls.Add(cbxPuesto);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dgvEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "gestionarContratos";
            Text = "gestionarContratos";
            Load += gestionarContratos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvEmpleados;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private ComboBox cbxPuesto;
        private Button btn_crear;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private Label label9;
        private DataGridView dgvContratos;
        private PictureBox pictureBox1;
        private Label labelCategoria;
        private Label labelSueldoBase;
        private DateTimePicker dtpFechaAlta;
        private DateTimePicker dtpFechaBaja;
        private TextBox txtCategoria;
        private TextBox txtSueldoBase;
    }
}