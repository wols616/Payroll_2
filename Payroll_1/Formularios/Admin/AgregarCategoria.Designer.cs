namespace Payroll_1.Formularios
{
    partial class AgregarCategoria
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
            dgvCategoria = new DataGridView();
            agregar = new Button();
            button2 = new Button();
            button3 = new Button();
            TxtNombreCat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtSueldoBase = new TextBox();
            btnAgregarPuesto = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(65, 65);
            dgvCategoria.Margin = new Padding(3, 2, 3, 2);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.Size = new Size(491, 202);
            dgvCategoria.TabIndex = 0;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            dgvCategoria.SelectionChanged += dgvCategoria_SelectionChanged;
            // 
            // agregar
            // 
            agregar.Location = new Point(463, 402);
            agregar.Margin = new Padding(3, 2, 3, 2);
            agregar.Name = "agregar";
            agregar.Size = new Size(82, 22);
            agregar.TabIndex = 1;
            agregar.Text = "agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(242, 402);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 2;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 402);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 3;
            button3.Text = "editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TxtNombreCat
            // 
            TxtNombreCat.Location = new Point(242, 305);
            TxtNombreCat.Margin = new Padding(3, 2, 3, 2);
            TxtNombreCat.Name = "TxtNombreCat";
            TxtNombreCat.Size = new Size(303, 23);
            TxtNombreCat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 311);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre de la Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 343);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 8;
            label2.Text = "Sueldo Base:";
            // 
            // TxtSueldoBase
            // 
            TxtSueldoBase.Location = new Point(242, 341);
            TxtSueldoBase.Margin = new Padding(3, 2, 3, 2);
            TxtSueldoBase.Name = "TxtSueldoBase";
            TxtSueldoBase.Size = new Size(133, 23);
            TxtSueldoBase.TabIndex = 9;
            // 
            // btnAgregarPuesto
            // 
            btnAgregarPuesto.Location = new Point(506, 451);
            btnAgregarPuesto.Name = "btnAgregarPuesto";
            btnAgregarPuesto.Size = new Size(75, 23);
            btnAgregarPuesto.TabIndex = 10;
            btnAgregarPuesto.Text = "Puestos";
            btnAgregarPuesto.UseVisualStyleBackColor = true;
            btnAgregarPuesto.Click += btnAgregarPuesto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back_Arrow_svg;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 497);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregarPuesto);
            Controls.Add(TxtSueldoBase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNombreCat);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(agregar);
            Controls.Add(dgvCategoria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarCategoria";
            Text = "AgregarCategoria";
            Load += AgregarCategoria_Load;
            MouseClick += AgregarCategoria_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private Button agregar;
        private Button button2;
        private Button button3;
        private TextBox TxtNombreCat;
        private Label label1;
        private Label label2;
        private TextBox TxtSueldoBase;
        private Button btnAgregarPuesto;
        private PictureBox pictureBox1;
    }
}