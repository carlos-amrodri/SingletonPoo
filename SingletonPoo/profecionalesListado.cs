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
    public partial class profecionalesListado : Form
    {
        public profecionalesListado()
        {
            InitializeComponent();
        }

        private void profecionalesListado_Load(object sender, EventArgs e)
        {
            General general = General.shared;
            listBox1.DataSource = general.getProfecionales();
            listBox1.DisplayMember = "_nombre";

            //Muestro los datos completos en una grilla
            dataGridView1.DataSource = general.getProfecionales();
        }
    }
}
