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
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPasswordVisible)
            {
                pictureBox1.Image = Properties.Resources.eye;
                txtContrasena.UseSystemPasswordChar = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.eye_fill;
                txtContrasena.UseSystemPasswordChar = false;
            }

            isPasswordVisible = !isPasswordVisible;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                HomeAdmin frm = new HomeAdmin();
                frm.Show();
                this.Hide();
            }
            else
            {
                HomeEmpleado frm = new HomeEmpleado();
                frm.Show();
                this.Hide();
            }
        }
    }
}
