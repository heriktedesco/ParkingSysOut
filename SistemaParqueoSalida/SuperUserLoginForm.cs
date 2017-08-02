﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoSalida
{
    public partial class SuperUserLoginForm : Form
    {
        public SuperUserLoginForm()
        {
            InitializeComponent();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            if(Password_txt.Text == Properties.Settings.Default.SuperUserPassword)
            {
                this.Hide();
                ConfiguracionSalidaForm form = new ConfiguracionSalidaForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Acceso negado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
