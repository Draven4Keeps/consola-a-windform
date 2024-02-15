using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numLados = int.Parse(lados.Text);

            double longitudLado = double.Parse(longitud.Text);

            double perimetro = CalcularPerimetro(numLados, longitudLado);

            MessageBox.Show($"El perimetro del poligono con {numLados} lados y longitud de lado {longitudLado} es {perimetro}");

        }

        private static double CalcularPerimetro(int numLados, double longitudLado)
        {
            return numLados * longitudLado;
        }
    }
}
