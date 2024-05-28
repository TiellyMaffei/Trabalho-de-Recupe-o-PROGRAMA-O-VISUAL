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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbCirculo.Checked)
            {
                CalcularAreaCirculo();

            }
            else if (rbTriangulo.Checked)
            {
                CalcularPerimetroTriangulo();
            }
            else if (rbQuadrilatero.Checked)
            {
                CalcularPerimetroQuadrilatero();
            }
        }

        private void CalcularAreaCirculo()
        {
            double diametro = double.Parse(txtDiametroA.Text);
            double raio = diametro / 2;
            double area = Math.PI * raio * raio;
            MessageBox.Show($"A área é: {area:F2}");
        }

        private void CalcularPerimetroTriangulo()
        {
            double ladoA = double.Parse(txtDiametroA.Text);
            double ladoB = double.Parse(txtDiametroB.Text);
            double ladoC = double.Parse(txtDiametroC.Text);

            if (ladoA == ladoB && ladoB == ladoC)
            {
                double perimetro = ladoA + ladoB + ladoC;
                MessageBox.Show($"O perímetro é: {perimetro}");
            }
            else
            {
                MessageBox.Show("Os lados não formam um triângulo.");
            }

        }

        private void CalcularPerimetroQuadrilatero()
        {
            double ladoA = double.Parse(txtDiametroA.Text);
            double ladoB = double.Parse(txtDiametroB.Text);
            double ladoC = double.Parse(txtDiametroC.Text);
            double ladoD = double.Parse(txtDiametroD.Text);

            if (ladoA < ladoB && ladoB < ladoC && ladoC < ladoD)
            {
                double perimetro = ladoA + ladoB + ladoC + ladoD;
                MessageBox.Show($"O perímetro é: {perimetro}");
            }
            else
            {
                MessageBox.Show("Os lados não formam um quadrilatero.");
            }

        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirculo.Checked)
            {
                txtDiametroA.Visible = true;
                txtDiametroB.Visible = false;
                txtDiametroC.Visible = false;
                txtDiametroD.Visible = false;
            }
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                txtDiametroA.Visible = true;
                txtDiametroB.Visible = true;
                txtDiametroC.Visible = true;
                txtDiametroD.Visible = false;
            }
        }

        private void rbQuadrilatero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuadrilatero.Checked)
            {
                txtDiametroA.Visible = true;
                txtDiametroB.Visible = true;
                txtDiametroC.Visible = true;
                txtDiametroD.Visible = true;
            }
        }
    }
}
