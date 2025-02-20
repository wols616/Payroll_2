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
            empleado.Dui = this.txt_DUI.Text;
            empleado.Nombre = this.txt_Nombre.Text;
            empleado.Apellidos = this.txt_Apellidos.Text;
            empleado.Direccion = this.txt_Direccion.Text;
            empleado.Telefono = this.txt_Telefono.Text;
            empleado.CuentaCorriente = this.txt_Ncuenta.Text;

            empleado.AgregarEmpleado();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void agregarEmpleado_Load(object sender, EventArgs e)
        {
            empleado.CargarTabla(dgvEmpleados);
        }


       

    }
}
