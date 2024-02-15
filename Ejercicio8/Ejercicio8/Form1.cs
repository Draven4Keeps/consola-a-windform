using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grados = double.Parse(Valor.Text);

            double radianes = ConvertirAGrados(grados);

            MessageBox.Show($"El valor en radianes es: {radianes}");
        }

        private static double ConvertirAGrados(double grados)
        {
            return grados * (Math.PI / 180);
        }
    }
}
