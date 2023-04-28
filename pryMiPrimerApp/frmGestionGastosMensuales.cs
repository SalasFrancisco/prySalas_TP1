﻿using System;
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
    public partial class frmGestionGastosMensuales : Form
    {
        //Declaracion de Variales
        decimal varDeposito, varAlquiler, varImpuesto,
            varComida, varGastosVarios, varSaldoRestante;

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmGestionGastosMensuales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varGastosVarios = Convert.ToDecimal(txtMonto.Text);
            varImpuesto = Convert.ToDecimal(txtImpuestos.Text);
            varSaldoRestante = varDeposito - varAlquiler - varComida - varGastosVarios - varImpuesto;

            lblSaldoRestante2.Text = varSaldoRestante.ToString();
        }

        private void frmGestionGastosMensuales_Load(object sender, EventArgs e)
        {
            varAlquiler = 0;
            varComida = 0;
            varDeposito = 0;
            varGastosVarios = 0;
            varImpuesto = 0;
            varSaldoRestante = 0;
            lblSaldoRestante2.Text = "$_____________";
        }
    }
}
