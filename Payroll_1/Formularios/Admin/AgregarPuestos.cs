using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios.Admin
{
    public partial class AgregarPuestos : Form
    {
        public AgregarPuestos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionarPuestoCategoria frm = new GestionarPuestoCategoria();
            frm.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
