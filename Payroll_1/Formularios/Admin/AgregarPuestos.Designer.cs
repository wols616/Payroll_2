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
            txtNombrePuesto = new TextBox();
            cbCategoria = new ComboBox();
            label2 = new Label();
            txtSueldoBase = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dgvPuestos = new DataGridView();
            editar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 416);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del puesto:";
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new Point(302, 413);
            txtNombrePuesto.Margin = new Padding(3, 4, 3, 4);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(243, 27);
            txtNombrePuesto.TabIndex = 2;
            txtNombrePuesto.TextChanged += textBox1_TextChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(302, 376);
            cbCategoria.Margin = new Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(243, 28);
            cbCategoria.TabIndex = 3;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 379);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Location = new Point(558, 377);
            txtSueldoBase.Margin = new Padding(3, 4, 3, 4);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(115, 27);
            txtSueldoBase.TabIndex = 5;
            txtSueldoBase.Text = "Sueldo Base";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(569, 456);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 16);
            label3.Name = "label3";
            label3.Size = new Size(260, 41);
            label3.TabIndex = 7;
            label3.Text = "Gestor de Puestos";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvPuestos
            // 
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(96, 77);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowHeadersWidth = 51;
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.Size = new Size(612, 276);
            dgvPuestos.TabIndex = 13;
            dgvPuestos.CellContentClick += dataGridView1_CellContentClick;
            dgvPuestos.SelectionChanged += dvgPuestos_SelectionChanged;
            // 
            // editar
            // 
            editar.Location = new Point(398, 456);
            editar.Margin = new Padding(3, 4, 3, 4);
            editar.Name = "editar";
            editar.Size = new Size(155, 31);
            editar.TabIndex = 14;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // AgregarPuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 516);
            Controls.Add(editar);
            Controls.Add(dgvPuestos);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtSueldoBase);
            Controls.Add(label2);
            Controls.Add(cbCategoria);
            Controls.Add(txtNombrePuesto);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarPuestos";
            Text = "AgregarPuestos";
            Load += AgregarPuestos_Load;
            MouseClick += AgregarPuestos_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrePuesto;
        private ComboBox cbCategoria;
        private Label label2;
        private TextBox txtSueldoBase;
        private Button btnAgregar;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dgvPuestos;
        private Button editar;
    }
}