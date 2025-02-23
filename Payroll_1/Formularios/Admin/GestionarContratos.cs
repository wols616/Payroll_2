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
        Contrato contrato = new Contrato();
        Puesto puesto = new Puesto();
        Categoria categoria = new Categoria();
        Puesto puestoSelec = new Puesto();

        private void cargarEmpleados()
        {
            List<Empleados> listaEmpleados = empleado.MostrarEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
            dgvEmpleados.Columns["CuentaCorriente"].Visible = false;
            dgvEmpleados.Columns["Correo"].Visible = false;
            dgvEmpleados.Columns["Contrasena"].Visible = false;

        }

        private void cargarPuestos()
        {
            List<Puesto> listaPuestos = puesto.MostrarPuestos();
            cbxPuesto.DataSource = listaPuestos;
            cbxPuesto.DisplayMember = "NombrePuesto";
            cbxPuesto.ValueMember = "IdPuesto";
        }

        private void cargarContratos()
        {
            dgvContratos.DataSource = contrato.ObtenerContratos(empleado.IdEmpleado);
            //dgvContratos.Columns["IdContrato"].Visible = false;
            //dgvContratos.Columns["IdEmpleado"].Visible = false;
        }

        private string definirTipoContrato()
        {
            string tipo_contrato = "";
            if (dtpFechaBaja.Value == dtpFechaAlta.Value)
            {
                tipo_contrato = "Indefinido";
            }
            else
            {
                tipo_contrato = "Definido";
            }
            return tipo_contrato;
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

        private void labelSueldoBase_Click(object sender, EventArgs e)
        {

        }

        private void gestionarContratos_Load(object sender, EventArgs e)
        {
            cargarPuestos();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);
                cargarContratos();
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Puesto puestoSeleccionado = (Puesto)cbxPuesto.SelectedItem;
            
            Contrato contrato = new Contrato(
                empleado.IdEmpleado, dtpFechaAlta.Value, dtpFechaBaja.Value, puestoSeleccionado.IdPuesto, definirTipoContrato(), "S"
                );
            contrato.AgregarContrato();
            cargarContratos();
        }

        private void cbxPuesto_SelectedValueChanged(object sender, EventArgs e)
        {
            puestoSelec = (Puesto)cbxPuesto.SelectedItem;

            var categoriaSeleccionada = categoria.ObtenerCategoria(puestoSelec.IdCategoria);

            if (categoriaSeleccionada != null) // Verificar que no sea null antes de acceder a sus propiedades
            {
                txtCategoria.Text = categoriaSeleccionada.NombreCategoria;
                txtSueldoBase.Text = categoriaSeleccionada.SueldoBase.ToString();
            }
            else
            {
                txtCategoria.Text = "";
                txtSueldoBase.Text = "";
            }
        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaBaja.MinDate = dtpFechaAlta.Value;
            dtpFechaBaja.Value = dtpFechaAlta.Value;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
            Contrato contratoActualizar = new Contrato(
                contrato.IdContrato, empleado.IdEmpleado, dtpFechaAlta.Value, dtpFechaBaja.Value, puestoSelec.IdPuesto, definirTipoContrato(), "S"
                );
            contratoActualizar.ActualizarContrato();
            cargarContratos();
        }

        private void dgvContratos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                contrato.IdContrato = Convert.ToInt32(dgvContratos.CurrentRow.Cells["IdContrato"].Value);
                this.dtpFechaAlta.Value = Convert.ToDateTime(dgvContratos.CurrentRow.Cells["FechaAlta"].Value);
                this.dtpFechaBaja.Value = Convert.ToDateTime(dgvContratos.CurrentRow.Cells["FechaBaja"].Value);
                this.cbxPuesto.SelectedValue = Convert.ToInt32(dgvContratos.CurrentRow.Cells["IdPuesto"].Value);

            }
        }
    }


}
