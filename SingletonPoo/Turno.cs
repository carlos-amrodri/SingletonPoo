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
    public partial class Turno : Form
    {
        General general = General.shared;
        public Turno()
        {
            InitializeComponent();
        }

        private void Turno_Load(object sender, EventArgs e)
        {
            comboClientes.DataSource = general.getClientes();
            comboClientes.DisplayMember = "_nombre";

            comboProfecionales.DataSource = general.getProfecionales();
            comboProfecionales.DisplayMember = "_nombre";
            mostrarTurnos();

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            ClienteCls cli =(ClienteCls)comboClientes.SelectedValue;
            ProfecionalCls prof = (ProfecionalCls)comboProfecionales.SelectedValue;
            DateTime fecha = dateTimePicker1.Value;
            TurnoCls turno = new TurnoCls(fecha, prof, cli);
            general.addTurno(turno);
            mostrarTurnos();

        }

        private void mostrarTurnos()
        {
            dataGridView1.DataSource = null;
            List<TurnosVisualizar> listado = general.getTurnosMostrar();
            dataGridView1.DataSource = listado;
        }
    }
}
