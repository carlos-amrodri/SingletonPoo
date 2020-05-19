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
    public partial class clienteListado : Form
    {
        General general = General.shared;
        public clienteListado()
        {
            InitializeComponent();
        }

        private void clienteListado_Load(object sender, EventArgs e)
        {
            List<ClienteCls> listado = general.getClientes();
            if(listado.Count > 0)
            {
                listBox1.DataSource = general.getClientes();
                listBox1.DisplayMember = "_nombre";

                dataGridView1.DataSource = general.getClientes();
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }

           
        }
    }
}
