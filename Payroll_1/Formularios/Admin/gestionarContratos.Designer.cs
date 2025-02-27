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
            label9 = new Label();
            dgvContratos = new DataGridView();
            pictureBox1 = new PictureBox();
            labelCategoria = new Label();
            labelSueldoBase = new Label();
            dtpFechaAlta = new DateTimePicker();
            dtpFechaBaja = new DateTimePicker();
            txtCategoria = new TextBox();
            txtSueldoBase = new TextBox();
            checboxFechaBaja = new CheckBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 26);
            label1.Name = "label1";
            label1.Size = new Size(308, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestionar contratos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(11, 7);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar empleado";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.Fixed3D;
            dgvEmpleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.GridColor = Color.Black;
            dgvEmpleados.Location = new Point(55, 90);
            dgvEmpleados.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(904, 141);
            dgvEmpleados.TabIndex = 2;
            dgvEmpleados.CellFormatting += dgvEmpleados_CellFormatting;
            dgvEmpleados.RowPrePaint += dgvEmpleados_RowPrePaint;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            dgvEmpleados.MouseClick += dgvEmpleados_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(56, 433);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Datos de contrato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(56, 484);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Fecha de alta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(401, 483);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 6;
            label6.Text = "Fecha de baja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(744, 485);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Puesto";
            // 
            // cbxPuesto
            // 
            cbxPuesto.FormattingEnabled = true;
            cbxPuesto.Location = new Point(843, 480);
            cbxPuesto.Margin = new Padding(3, 2, 3, 2);
            cbxPuesto.Name = "cbxPuesto";
            cbxPuesto.Size = new Size(117, 23);
            cbxPuesto.TabIndex = 13;
            cbxPuesto.SelectedValueChanged += cbxPuesto_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(482, 250);
            label9.Name = "label9";
            label9.Size = new Size(82, 21);
            label9.TabIndex = 17;
            label9.Text = "Contratos";
            // 
            // dgvContratos
            // 
            dgvContratos.BackgroundColor = Color.White;
            dgvContratos.BorderStyle = BorderStyle.Fixed3D;
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.GridColor = Color.Black;
            dgvContratos.Location = new Point(55, 272);
            dgvContratos.Margin = new Padding(3, 2, 3, 2);
            dgvContratos.MultiSelect = false;
            dgvContratos.Name = "dgvContratos";
            dgvContratos.ReadOnly = true;
            dgvContratos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvContratos.RowHeadersWidth = 51;
            dgvContratos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContratos.Size = new Size(904, 143);
            dgvContratos.TabIndex = 18;
            dgvContratos.CellFormatting += dgvContratos_CellFormatting;
            dgvContratos.RowPrePaint += dgvContratos_RowPrePaint;
            dgvContratos.SelectionChanged += dgvContratos_SelectionChanged;
            dgvContratos.MouseClick += dgvContratos_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(0, 0);
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
            labelCategoria.Location = new Point(744, 531);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(76, 20);
            labelCategoria.TabIndex = 21;
            labelCategoria.Text = "Categoria";
            // 
            // labelSueldoBase
            // 
            labelSueldoBase.AutoSize = true;
            labelSueldoBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelSueldoBase.Location = new Point(744, 574);
            labelSueldoBase.Name = "labelSueldoBase";
            labelSueldoBase.Size = new Size(93, 20);
            labelSueldoBase.TabIndex = 22;
            labelSueldoBase.Text = "Sueldo Base";
            labelSueldoBase.Click += labelSueldoBase_Click;
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(162, 484);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(200, 23);
            dtpFechaAlta.TabIndex = 23;
            dtpFechaAlta.ValueChanged += dtpFechaAlta_ValueChanged;
            // 
            // dtpFechaBaja
            // 
            dtpFechaBaja.Location = new Point(519, 483);
            dtpFechaBaja.Name = "dtpFechaBaja";
            dtpFechaBaja.Size = new Size(200, 23);
            dtpFechaBaja.TabIndex = 24;
            // 
            // txtCategoria
            // 
            txtCategoria.Enabled = false;
            txtCategoria.Font = new Font("Segoe UI", 11.25F);
            txtCategoria.Location = new Point(843, 524);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(117, 27);
            txtCategoria.TabIndex = 25;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Font = new Font("Segoe UI", 11.25F);
            txtSueldoBase.Location = new Point(842, 569);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(117, 27);
            txtSueldoBase.TabIndex = 26;
            // 
            // checboxFechaBaja
            // 
            checboxFechaBaja.AutoSize = true;
            checboxFechaBaja.Location = new Point(636, 512);
            checboxFechaBaja.Name = "checboxFechaBaja";
            checboxFechaBaja.Size = new Size(80, 19);
            checboxFechaBaja.TabIndex = 27;
            checboxFechaBaja.Text = "Indefinido";
            checboxFechaBaja.UseVisualStyleBackColor = true;
            checboxFechaBaja.CheckedChanged += checboxFechaBaja_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(44, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 376);
            panel1.TabIndex = 28;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.btnCancelar;
            pictureBox4.Location = new Point(479, 286);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(195, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.btnActualizar;
            pictureBox3.Location = new Point(338, 290);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(141, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.btnCrear;
            pictureBox2.Location = new Point(232, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(44, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(926, 187);
            panel2.TabIndex = 29;
            // 
            // gestionarContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1005, 640);
            Controls.Add(checboxFechaBaja);
            Controls.Add(label1);
            Controls.Add(txtSueldoBase);
            Controls.Add(txtCategoria);
            Controls.Add(dtpFechaBaja);
            Controls.Add(dtpFechaAlta);
            Controls.Add(labelSueldoBase);
            Controls.Add(labelCategoria);
            Controls.Add(pictureBox1);
            Controls.Add(dgvContratos);
            Controls.Add(label9);
            Controls.Add(cbxPuesto);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dgvEmpleados);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "gestionarContratos";
            Text = "gestionarContratos";
            Load += gestionarContratos_Load;
            MouseClick += gestionarContratos_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label9;
        private DataGridView dgvContratos;
        private PictureBox pictureBox1;
        private Label labelCategoria;
        private Label labelSueldoBase;
        private DateTimePicker dtpFechaAlta;
        private DateTimePicker dtpFechaBaja;
        private TextBox txtCategoria;
        private TextBox txtSueldoBase;
        private CheckBox checboxFechaBaja;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}