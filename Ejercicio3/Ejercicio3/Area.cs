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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(bas.Text);

            double altura = double.Parse(Longitud2.Text);

            double area = CalcularArea(b, altura);

            MessageBox.Show($"El area del poligono es: {area}");
        }
        static double CalcularArea(int b, double altura)
        {
            return b * altura; 
        }
    }
}
