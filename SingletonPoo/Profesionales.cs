﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPoo
{
    public partial class Profesionales : Form
    {
        General general = General.shared;
        public Profesionales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt16(textDni.Text);
            var name = textNombre.Text;
            var ape = textApellido.Text;
            ProfesionalCls pro = new ProfesionalCls(dni, name, ape);
            general.addProfecionales(pro);
            MessageBox.Show("El profecional fue creado");
            limpiar();
        }

        private void limpiar()
        {
            textApellido.Text = "";
            textNombre.Text = "";
            textDni.Text = "";
        }
    }
}
