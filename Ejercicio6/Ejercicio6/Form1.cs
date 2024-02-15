using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uneuro = 0.93;
            double undolar = 1.07;

            double resultado;
            double tipoCambio = double.Parse(Cantidad.Text);

            double dolares = double.Parse(Cantidad.Text);
            resultado = ConvertirAEuros(dolares, tipoCambio);
            MessageBox.Show($"Esos son {resultado} Dolares");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double uneuro = 0.93;
            double undolar = 1.07;

            double resultado;
            double tipoCambio = double.Parse(Cantidad.Text);

            double euros = double.Parse(Cantidad.Text);
            resultado = ConvertirADolares(euros, tipoCambio);
            MessageBox.Show($"Esos son {resultado} Euros.");
        }
        static double ConvertirADolares(double undolar, double tipoCambio)
        {
            double uneuro = 0.93;

            return uneuro * tipoCambio;
        }

        static double ConvertirAEuros(double uneuro, double  tipoCambio)
        {
            double undolar = 1.07;
            return undolar * tipoCambio;
        }
    }
}
