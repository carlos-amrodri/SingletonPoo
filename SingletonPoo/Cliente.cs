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
    public partial class Cliente : Form
    {
        General general = General.shared;
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int leg = Convert.ToInt16(textLegajo.Text);
            string name = textNombre.Text;
            string ape = textApellido.Text;
            ClienteCls cli = new ClienteCls(leg, name, ape);
            general.addCliente(cli);
            MessageBox.Show("Elcliente fue creado");
            limpiar();
        }

        private void limpiar()
        {
            textApellido.Text = "";
            textNombre.Text = "";
            textLegajo.Text = "";
        }
    }
}
