﻿using Payroll_1.Formularios.Empleado;
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
    public partial class HomeEmpleado : Form
    {
        public HomeEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Función para desloguearse
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosPersonales frm = new DatosPersonales();
            frm.Show();
            this.Hide();
        }
    }
}
