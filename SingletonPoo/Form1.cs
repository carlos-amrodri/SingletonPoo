using System;
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
    public partial class SolucionPoo : Form
    {
        public SolucionPoo()
        {
            InitializeComponent();
        }

        private void SolucionPoo_Load(object sender, EventArgs e)
        {
            General g = General.shared; //Aqui inicializo la instancia del general
        }

        private void ingresarNuevoProfecionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profecional windProfecional = new Profecional();
            windProfecional.MdiParent = this;
            windProfecional.Show();
        }

        private void listadoDeProfecionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profecionalesListado wProfList = new profecionalesListado();
            wProfList.MdiParent = this;
            wProfList.Show();
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.MdiParent = this;
            cli.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clienteListado listado = new clienteListado();
            listado.MdiParent = this;
            listado.Show();
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turno turnoWind = new Turno();
            turnoWind.MdiParent = this;
            turnoWind.Show();
        }
    }
}
