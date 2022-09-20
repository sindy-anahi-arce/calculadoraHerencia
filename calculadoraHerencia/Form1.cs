using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Creación del objeto
            Suma suma = new Suma();

            //Se llama del método en la clase
            txtResult.Text = suma.operar(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Creación de objeto
            Resta resta = new Resta();

            //Se llama del método en la clase
            txtResult.Text = resta.operar(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Creación de objeto
            Multiplicacion multi = new Multiplicacion();

            //Se llama del método en la clase
            txtResult.Text = multi.operar(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            //Creación de objeto
            Division divi = new Division();

            //Se llama del método en la clase
            txtResult.Text = divi.operar(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text)).ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResult.Clear();
        }
    }
}
