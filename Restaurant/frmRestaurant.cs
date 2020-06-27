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



        private void InfoMesa(string Estado)
        {
            frmOrdenes mesasForm = new frmOrdenes();
            
            mesasForm.Show();
        }

        private void MesaUno()
        {
            InfoMesa("Disponible");
            btnMesa1.Enabled = false;
        }
        private void MesaDos()
        {
            InfoMesa("Disponible");
            btnMesa2.Enabled = false;
        }

        private void MesaTres()
        {
            InfoMesa("Disponible");
            btnMesa3.Enabled = false;
        }

        private void MesaCuatro()
        {
            InfoMesa("Disponible");
            btnMesa4.Enabled = false;
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
           
           
                    
        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {
            MesaDos();
        }
        private void btnMesa3_Click(object sender, EventArgs e)
        {

            InfoMesa("disponible");
            btnMesa3.Enabled = false;

        }
        private void btnMesa4_Click(object sender, EventArgs e)
        {
            InfoMesa("disponible");
            btnMesa4.Enabled = false;

        }

       
        
    }
}
