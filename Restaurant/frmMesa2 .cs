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
   

    public partial class frmMesa2 : Form
    {
        public frmMesa2()
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
            btnOrdenar2.Enabled = true;
            this.Close();
            
        }

        

       
    }
}
