using Payroll_1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios
{
    public partial class gestionarContratos : Form
    {
        public gestionarContratos()
        {
            InitializeComponent();
            cargarEmpleados();
        }

        Empleados empleado = new Empleados();

        private void cargarEmpleados()
        {
            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeAdmin frm = new HomeAdmin();
            frm.Show();
            this.Hide();
        }
    }


}
