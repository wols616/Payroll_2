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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_id = new TextBox();
            txt_fecha_alta = new TextBox();
            txt_fecha_baja = new TextBox();
            cbx_categoria = new ComboBox();
            cbx_puesto = new ComboBox();
            btn_crear = new Button();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestionar contratos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
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
            dgvEmpleados.Size = new Size(887, 141);
            dgvEmpleados.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 255);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "Datos de contrato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 287);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 4;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 287);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha de alta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 287);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 6;
            label6.Text = "Fecha de baja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(557, 287);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(774, 287);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 8;
            label8.Text = "Puesto";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(81, 285);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(58, 23);
            txt_id.TabIndex = 9;
            // 
            // txt_fecha_alta
            // 
            txt_fecha_alta.Location = new Point(247, 285);
            txt_fecha_alta.Margin = new Padding(3, 2, 3, 2);
            txt_fecha_alta.Name = "txt_fecha_alta";
            txt_fecha_alta.PlaceholderText = "YYYY-MM-DD";
            txt_fecha_alta.Size = new Size(88, 23);
            txt_fecha_alta.TabIndex = 10;
            // 
            // txt_fecha_baja
            // 
            txt_fecha_baja.Location = new Point(448, 285);
            txt_fecha_baja.Margin = new Padding(3, 2, 3, 2);
            txt_fecha_baja.Name = "txt_fecha_baja";
            txt_fecha_baja.PlaceholderText = "YYYY-MM-DD";
            txt_fecha_baja.Size = new Size(88, 23);
            txt_fecha_baja.TabIndex = 11;
            // 
            // cbx_categoria
            // 
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(627, 284);
            cbx_categoria.Margin = new Padding(3, 2, 3, 2);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(117, 23);
            cbx_categoria.TabIndex = 12;
            // 
            // cbx_puesto
            // 
            cbx_puesto.FormattingEnabled = true;
            cbx_puesto.Location = new Point(826, 284);
            cbx_puesto.Margin = new Padding(3, 2, 3, 2);
            cbx_puesto.Name = "cbx_puesto";
            cbx_puesto.Size = new Size(117, 23);
            cbx_puesto.TabIndex = 13;
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(366, 326);
            btn_crear.Margin = new Padding(3, 2, 3, 2);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(82, 22);
            btn_crear.TabIndex = 14;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(453, 326);
            btn_actualizar.Margin = new Padding(3, 2, 3, 2);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(82, 22);
            btn_actualizar.TabIndex = 15;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(541, 326);
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
            label9.Location = new Point(463, 390);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 17;
            label9.Text = "Contratos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(55, 424);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(887, 143);
            dataGridView2.TabIndex = 18;
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
            // gestionarContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 610);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label9);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_actualizar);
            Controls.Add(btn_crear);
            Controls.Add(cbx_puesto);
            Controls.Add(cbx_categoria);
            Controls.Add(txt_fecha_baja);
            Controls.Add(txt_fecha_alta);
            Controls.Add(txt_id);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "gestionarContratos";
            Text = "gestionarContratos";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvEmpleados;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_id;
        private TextBox txt_fecha_alta;
        private TextBox txt_fecha_baja;
        private ComboBox cbx_categoria;
        private ComboBox cbx_puesto;
        private Button btn_crear;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private Label label9;
        private DataGridView dataGridView2;
        private PictureBox pictureBox1;
    }
}