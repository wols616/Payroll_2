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
            dgvContratos.Columns["IdContrato"].Visible = false;
            dgvContratos.Columns["IdEmpleado"].Visible = false;
            dgvContratos.Columns["IdPuesto"].Visible = false;

        }

        private string definirTipoContrato()
        {
            string tipo_contrato = "";
            if (checboxFechaBaja.Checked)
            {
                tipo_contrato = "Indefinido";
            }
            else
            {
                tipo_contrato = "Definido";
            }
            return tipo_contrato;
        }

        private void actualizarEstadoEmpleado()
        {
            if (contrato.ActualizarEstadoEmpleado(empleado.IdEmpleado))
            {
                cargarEmpleados();
            }
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
            actualizarEstadoEmpleado();
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
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }
            Puesto puestoSeleccionado = (Puesto)cbxPuesto.SelectedItem;

            Contrato contrato = new Contrato(
                empleado.IdEmpleado, dtpFechaAlta.Value, dtpFechaBaja.Value, puestoSeleccionado.IdPuesto, definirTipoContrato(), "S"
                );
            contrato.AgregarContrato();
            actualizarEstadoEmpleado();
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
            dtpFechaBaja.MinDate = dtpFechaAlta.Value.AddDays(1);
            dtpFechaBaja.Value = dtpFechaAlta.Value.AddMonths(1);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea actualizar este contrato?",
                                                 "Confirmar Actualización",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (!checboxFechaBaja.Checked)
                {
                    Contrato contratoActualizar = new Contrato(
                    contrato.IdContrato, empleado.IdEmpleado, dtpFechaAlta.Value, dtpFechaBaja.Value, puestoSelec.IdPuesto, definirTipoContrato(), "S"
                    );
                    contratoActualizar.ActualizarContrato();
                }
                else if (checboxFechaBaja.Checked)
                {
                    Contrato contratoActualizar = new Contrato(
                    contrato.IdContrato, empleado.IdEmpleado, dtpFechaAlta.Value, null, puestoSelec.IdPuesto, definirTipoContrato(), "S"
                    );
                    contratoActualizar.ActualizarContrato();
                }
                actualizarEstadoEmpleado();
                cargarContratos();
            }
        }

        private void dgvContratos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContratos.CurrentRow != null && dgvContratos.CurrentRow.Cells["IdContrato"].Value != null)
            {
                contrato.IdContrato = Convert.ToInt32(dgvContratos.CurrentRow.Cells["IdContrato"].Value);
                this.dtpFechaAlta.Value = Convert.ToDateTime(dgvContratos.CurrentRow.Cells["FechaAlta"].Value);

                if (dgvContratos.CurrentRow.Cells["FechaBaja"].Value == null)
                {
                    checboxFechaBaja.Checked = true;
                }
                else
                {
                    checboxFechaBaja.Checked = false;
                    dtpFechaBaja.Enabled = true;
                    DateTime fechaBaja = Convert.ToDateTime(dgvContratos.CurrentRow.Cells["FechaBaja"].Value);
                    if (fechaBaja >= dtpFechaBaja.MinDate && fechaBaja <= dtpFechaBaja.MaxDate)
                    {
                        this.dtpFechaBaja.Value = fechaBaja;
                    }
                    else
                    {
                        // Handle the invalid date scenario
                        this.dtpFechaBaja.Value = dtpFechaBaja.MinDate; // or any other default valid date
                    }
                }

                this.cbxPuesto.SelectedValue = Convert.ToInt32(dgvContratos.CurrentRow.Cells["IdPuesto"].Value);
            }
        }

        private void checboxFechaBaja_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaBaja.Visible = !checboxFechaBaja.Checked;
            //dtpFechaBaja.Enabled = !checboxFechaBaja.Checked;
        }

        private void dgvEmpleados_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvContratos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gestionarContratos_MouseClick(object sender, MouseEventArgs e)
        {
            dgvEmpleados.ClearSelection();
            dgvContratos.ClearSelection();
        }

        private void dgvContratos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvContratos.Columns[e.ColumnIndex].Name == "TipoContrato" || dgvContratos.Columns[e.ColumnIndex].Name == "Vigente")
            {
                string tipoContrato = dgvContratos.Rows[e.RowIndex].Cells["TipoContrato"].Value.ToString();
                string vigente = dgvContratos.Rows[e.RowIndex].Cells["Vigente"].Value.ToString();

                if (vigente == "N")
                {
                    dgvContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; // Rojo claro
                }
                else if (tipoContrato == "Definido")
                {
                    dgvContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine; // Verde claro
                }
                else if (tipoContrato == "Indefinido")
                {
                    dgvContratos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; // Verde claro
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea cancelar este contrato?",
                                         "Confirmar Cancelación",
                                         MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Contrato contratoo = new Contrato();
                contratoo.IdContrato = contrato.IdContrato;
                contratoo.FechaBaja = DateTime.Now;
                contratoo.Vigente = "N";
                contratoo.ActualizarFechaBajaVigenteContrato();
                //Al momento de cancelar, este método comprueba si el empleado tiene contratos vigentes
                //Si no tiene contratos vigentes, se cambia el estado del empleado a inactivo
                actualizarEstadoEmpleado();
                cargarContratos();
            }
        }
    }


}
