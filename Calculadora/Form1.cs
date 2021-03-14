using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double total, ultimoNumeroDigitado;
        string operador;

        private void Limpar()
        {
            total = 0;
            ultimoNumeroDigitado = 0;
            operador = "+";
            txtResult.Text = "0";
        }
        private void Calcular()
        {
            switch (operador)
            {
                case "+":
                    total += ultimoNumeroDigitado;
                    break;
                case "-":
                    total -= ultimoNumeroDigitado;
                    break;
                case "/":
                    total /= ultimoNumeroDigitado;
                    break;
                case "x":
                    total *= ultimoNumeroDigitado;
                    break;
            }
            ultimoNumeroDigitado = 0;
            txtResult.Text = total.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            Limpar();
        }


        private void GerarNumero(object sender, EventArgs e)
        {
            if(ultimoNumeroDigitado == 0)
            {
                txtResult.Text = (sender as Button).Text;
            }
            else
            {
                txtResult.Text += (sender as Button).Text;
            }
            ultimoNumeroDigitado = double.Parse(txtResult.Text);

        }

        private void Operadores(object sender, EventArgs e)
        {
            txtResult.Text += (sender as Button).Text;
            Calcular();
            operador = (sender as Button).Text;
        }

        private void BtnResultado(object sender, EventArgs e)
        {
            ultimoNumeroDigitado = double.Parse(txtResult.Text);
            Calcular();
            operador = "+";
            total = 0;
        }

        private void BtnLimpar(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
