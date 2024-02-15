using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Perimetro : Form
    {
        public Perimetro()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int numLados = int.Parse(Lados1.Text);

            double longitudLado = double.Parse(Longitud1.Text);

            double perimetro = CalcularPerimetro(numLados, longitudLado);

            MessageBox.Show($"El perimetro del poligono es: {perimetro}");
        }
        static double CalcularPerimetro(int numLados, double longitudLado)
        {
            return numLados * longitudLado;
        }
    }
}
