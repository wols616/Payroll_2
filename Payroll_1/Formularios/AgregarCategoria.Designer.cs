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
            button4 = new Button();
            button5 = new Button();
            TxtNombreCat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtSueldoBase = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(62, 41);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.Size = new Size(842, 269);
            dgvCategoria.TabIndex = 0;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            dgvCategoria.SelectionChanged += dgvCategoria_SelectionChanged;
            // 
            // agregar
            // 
            agregar.Location = new Point(74, 470);
            agregar.Name = "agregar";
            agregar.Size = new Size(94, 29);
            agregar.TabIndex = 1;
            agregar.Text = "agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 470);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(364, 470);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(502, 470);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(825, 494);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TxtNombreCat
            // 
            TxtNombreCat.Location = new Point(276, 339);
            TxtNombreCat.Name = "TxtNombreCat";
            TxtNombreCat.Size = new Size(250, 27);
            TxtNombreCat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 346);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre de la Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 389);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 8;
            label2.Text = "Sueldo Base:";
            // 
            // TxtSueldoBase
            // 
            TxtSueldoBase.Location = new Point(276, 386);
            TxtSueldoBase.Name = "TxtSueldoBase";
            TxtSueldoBase.Size = new Size(163, 27);
            TxtSueldoBase.TabIndex = 9;
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 546);
            Controls.Add(TxtSueldoBase);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNombreCat);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(agregar);
            Controls.Add(dgvCategoria);
            Name = "AgregarCategoria";
            Text = "AgregarCategoria";
            Load += AgregarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private Button agregar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox TxtNombreCat;
        private Label label1;
        private Label label2;
        private TextBox TxtSueldoBase;
    }
}