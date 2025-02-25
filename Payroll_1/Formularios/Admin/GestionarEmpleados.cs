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
using Payroll_1.Modelos;



namespace Payroll_1.Formularios
{
    public partial class GestionarEmpleados : Form
    {
        public GestionarEmpleados()
        {
            InitializeComponent();
        }

        //Payroll_1.Modelos.Empleado empleado = new Payroll_1.Modelos.Empleado();
        Empleados empleado = new Empleados();
        //Empleado empleado = new Empleado();


        private void button1_Click(object sender, EventArgs e)
        {
            empleado.Dui = this.txt_DUI.Text;
            empleado.Nombre = this.txt_Nombre.Text;
            empleado.Apellidos = this.txt_Apellidos.Text;
            empleado.Direccion = this.txt_Direccion.Text;
            empleado.Telefono = this.txt_Telefono.Text;
            empleado.CuentaCorriente = this.txt_Ncuenta.Text;
            empleado.Estado = "Activo";
            empleado.Correo = this.txtCorreo.Text;
            empleado.Contrasena = this.txtContrasena.Text;
            empleado.AgregarEmpleado();
            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empleado.Dui = this.txt_DUI.Text;
            empleado.Nombre = this.txt_Nombre.Text;
            empleado.Apellidos = this.txt_Apellidos.Text;
            empleado.Direccion = this.txt_Direccion.Text;
            empleado.Telefono = this.txt_Telefono.Text;
            empleado.CuentaCorriente = this.txt_Ncuenta.Text;
            empleado.Estado = "Activo";
            empleado.Correo = this.txtCorreo.Text;
            empleado.Contrasena = this.txtContrasena.Text;

            if (dgvEmpleados.SelectedRows.Count > 0)
            {

                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["idempleado"].Value);

                empleado.EditarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void agregarEmpleado_Load(object sender, EventArgs e)
        {
            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
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
                txtCorreo.Text = fila.Cells["correo"].Value?.ToString();
                txtContrasena.Text = fila.Cells["contrasena"].Value?.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }

        private void agregarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void btnGenerarContrasena_Click(object sender, EventArgs e)
        {
            char[] letras = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] numeros = "1234567890".ToCharArray();
            char[] caracteresEspeciales = "! # $ % & ' ( ) * + , - . / : ; < = > ? @ [ ] ^ _ ` { | } ~".ToCharArray();

            Random random = new Random();
            int longitud = random.Next(8, 16);

            char[] contrasena = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                int tipoCaracter = random.Next(3);
                switch (tipoCaracter)
                {
                    case 0:
                        contrasena[i] = letras[random.Next(letras.Length)];
                        break;
                    case 1:
                        contrasena[i] = numeros[random.Next(numeros.Length)];
                        break;
                    case 2:
                        contrasena[i] = caracteresEspeciales[random.Next(caracteresEspeciales.Length)];
                        break;
                }
            }

            string contrasenaGenerada = new string(contrasena);
            txtContrasena.Text = contrasenaGenerada;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEmpleados.ClearSelection();
            txt_DUI.Text = "";
            txt_Nombre.Text = "";
            txt_Apellidos.Text = "";
            txt_Direccion.Text = "";
            txt_Telefono.Text = "";
            txt_Ncuenta.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeAdmin frm = new HomeAdmin();
            frm.Show();
            this.Hide();
        }
    }
}
