using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_1.Formularios.Empleado
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeEmpleado frm = new HomeEmpleado();
            frm.Show();
            this.Hide();
        }
    }
}
