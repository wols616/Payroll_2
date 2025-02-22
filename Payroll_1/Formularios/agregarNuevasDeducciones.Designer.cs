namespace Payroll_1.Formularios
{
    partial class agregarNuevasDeducciones
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
            dgvDeducciones = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtPorcentajee = new TextBox();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).BeginInit();
            SuspendLayout();
            // 
            // dgvDeducciones
            // 
            dgvDeducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeducciones.Location = new Point(67, 63);
            dgvDeducciones.Margin = new Padding(3, 4, 3, 4);
            dgvDeducciones.Name = "dgvDeducciones";
            dgvDeducciones.RowHeadersWidth = 51;
            dgvDeducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeducciones.Size = new Size(781, 200);
            dgvDeducciones.TabIndex = 0;
            dgvDeducciones.CellClick += dgvDeducciones_CellClick;
            dgvDeducciones.SelectionChanged += dgvDeducciones_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 301);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 301);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Porcentaje:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 291);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(268, 379);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(403, 379);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(535, 379);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPorcentajee
            // 
            txtPorcentajee.Location = new Point(526, 297);
            txtPorcentajee.Margin = new Padding(3, 4, 3, 4);
            txtPorcentajee.Name = "txtPorcentajee";
            txtPorcentajee.Size = new Size(175, 27);
            txtPorcentajee.TabIndex = 8;
            txtPorcentajee.TextChanged += txtPorcentajee_TextChanged;
            txtPorcentajee.KeyPress += txtPorcentajee_KeyPress;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 13);
            btnRegresar.Margin = new Padding(3, 4, 3, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(86, 31);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "regresar";
            btnRegresar.Click += btnRegresar_Click;
            // 
            // agregarNuevasDeducciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 447);
            Controls.Add(btnRegresar);
            Controls.Add(txtPorcentajee);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDeducciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "agregarNuevasDeducciones";
            Text = "agregarDeducciones";
            Load += agregarDeducciones_Load;
            MouseClick += agregarNuevasDeducciones_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dgvDeducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDeducciones;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtPorcentajee;
        private Button btnRegresar;
    }
}