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
        
        
                
        public frmRestaurant()
        {
            InitializeComponent();
        }



        
        private void MesaUno()
        {

            frmMesa1 miMesa = new frmMesa1(); 
            miMesa.Show();
            btnMesa1.Enabled = false;
        }
        
        private void MesaDos()
        {
            frmMesa2 miMesa = new frmMesa2();
            miMesa.Show();
            btnMesa2.Enabled = false;
        }

        private void MesaTres()
        {
            frmMesa3 miMesa3 = new frmMesa3();
            miMesa3.Show();
            btnMesa3.Enabled = false;
        }

        private void MesaCuatro()
        {
            frmMesa4 miMesa = new frmMesa4();
            miMesa.Show();
            btnMesa4.Enabled = false;
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            MesaUno();
           
                    
        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {
            MesaDos();
        }
       
       
        private void btnMesa3_Click_1(object sender, EventArgs e)
        {
            MesaTres();
        }

        private void btnMesa4_Click_1(object sender, EventArgs e)
        {
            MesaCuatro();
        }
    }
}
