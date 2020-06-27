using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
 
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void frmOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Mesas mesa = new Mesas();
            mesa.numPersonas = 1;

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Mesas mesa = new Mesas();
            mesa.numPersonas = 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Mesas mesa = new Mesas();
            mesa.numPersonas = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {


            Mesas mesa = new Mesas();
            mesa.numPersonas = 4;
        }

       
    }
}
