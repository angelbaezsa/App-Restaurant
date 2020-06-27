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
    public partial class frmRestaurant : Form
    {

        frmOrdenes mesas = new frmOrdenes();
        
        public frmRestaurant()
        {
            InitializeComponent();
        }

        


        private void btnMesa1_Click(object sender, EventArgs e)
        {   

            btnMesa1.Enabled = false;
            this.Hide();
            mesas.Show();

           

        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {

            btnMesa2.Enabled = false;
            
        }
        private void btnMesa3_Click(object sender, EventArgs e)
        {

            btnMesa3.Enabled = false;
           
        }
        private void btnMesa4_Click(object sender, EventArgs e)
        {

            btnMesa4.Enabled = false;
            
        }

        
    }
}
