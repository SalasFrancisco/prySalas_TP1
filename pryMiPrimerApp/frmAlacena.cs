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
    public partial class frmAlacena : Form
    {
        string varLugar, varAlimento;

        int varCantidad;

        DateTime varFechaVencimiento;


        public frmAlacena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mrcAlmacenar_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varLugar = cboLugar.Text;
            varAlimento = cboAlimento.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            varFechaVencimiento = dtpVencimiento.Value;

            cboLugarAlmacenado.Items.Add(varLugar);
            cboAlimentoAlmacenado.Items.Add(varAlimento);
            lblFechaAlmacenado2.Text = Convert.ToString(varFechaVencimiento);
            lblCantidadAlmacenado2.Text = Convert.ToString(varCantidad);
        }

        private void cboAlimentoAlmacenado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            cboLugar.Items.Add("Alacena");
            cboLugar.Items.Add("Heladera");
            cboLugar.Items.Add("Baño");
            cboLugar.Items.Add("Jardineria");
            cboLugar.Items.Add("Almacen");

            cboAlimento.Items.Add("Azucar");
            cboAlimento.Items.Add("Aceite");
            cboAlimento.Items.Add("Sal");
            cboAlimento.Items.Add("Pimienta");
            cboAlimento.Items.Add("Papel Higienico");
            cboAlimento.Items.Add("Pasta de Dientes");

        }
    }
}
