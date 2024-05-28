using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Recupeção_PROGRAMAÇÃO_VISUAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Double altura, peso, imc;
            peso = Double.Parse(txtPeso.Text);
            altura = Double.Parse(txtAltura.Text);
            imc = (peso / (altura * altura));

            if (rbHomem.Checked)
            {
                peso = 22 * altura * altura;
            }
            else if(rbMulher.Checked)
            {
                peso = 21 * altura * altura;
            }
            
            lblResultado.Text = peso.ToString();

        }
    }
}
