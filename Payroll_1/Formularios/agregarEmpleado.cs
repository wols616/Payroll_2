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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;



namespace Payroll_1.Formularios
{
    public partial class agregarEmpleado : Form
    {
        public agregarEmpleado()
        {
            InitializeComponent();
        }
        Empleado empleado = new Empleado();


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                MessageBox.Show("No puedes agregar a un empleado que ya está registrado");
            }
            else
            {
                empleado.Dui = this.txt_DUI.Text;
                empleado.Nombre = this.txt_Nombre.Text;
                empleado.Apellidos = this.txt_Apellidos.Text;
                empleado.Direccion = this.txt_Direccion.Text;
                empleado.Telefono = this.txt_Telefono.Text;
                empleado.CuentaCorriente = this.txt_Ncuenta.Text;
                empleado.AgregarEmpleado();
                List<Empleado> listaEmpleados = empleado.MostrarEmpleados();
                dgvEmpleados.DataSource = listaEmpleados;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empleado.Dui = this.txt_DUI.Text;
            empleado.Nombre = this.txt_Nombre.Text;
            empleado.Apellidos = this.txt_Apellidos.Text;
            empleado.Direccion = this.txt_Direccion.Text;
            empleado.Telefono = this.txt_Telefono.Text;
            empleado.CuentaCorriente = this.txt_Ncuenta.Text;

            if (dgvEmpleados.SelectedRows.Count > 0)
            {

                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["idempleado"].Value);

                empleado.EditarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            List<Empleado> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void agregarEmpleado_Load(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvEmpleados.SelectedRows[0];
                txt_DUI.Text = fila.Cells["dui"].Value?.ToString();
                txt_Nombre.Text = fila.Cells["nombre"].Value?.ToString();
                txt_Apellidos.Text = fila.Cells["apellidos"].Value?.ToString();
                txt_Direccion.Text = fila.Cells["direccion"].Value?.ToString();
                txt_Telefono.Text = fila.Cells["telefono"].Value?.ToString();
                txt_Ncuenta.Text = fila.Cells["cuentacorriente"].Value?.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Dispose();
        }

        private void agregarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEmpleados.ClearSelection();
            txt_DUI.Text = "";
            txt_Nombre.Text = "";
            txt_Apellidos.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";
            txt_Ncuenta.Text = "";

        }
    }
}
