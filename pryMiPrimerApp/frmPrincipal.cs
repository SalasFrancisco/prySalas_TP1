using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlacena = new frmAlacena();

            ventanaAlacena.ShowDialog();
        }   

        private void cmdAdministradorDeGastos_Click(object sender, EventArgs e)
        {
            frmGestionGastosMensuales ventanaControlDeGastosMensuales = new frmGestionGastosMensuales();

            ventanaControlDeGastosMensuales.ShowDialog();
        }
    }
}
