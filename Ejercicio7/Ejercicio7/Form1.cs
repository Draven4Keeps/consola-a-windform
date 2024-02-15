using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(Temperatura.Text);

            double fahrenheit = ConvertirAFahrenheit(celsius);

            MessageBox.Show($"La temperatura en grados Fahrenheit es: {fahrenheit}");
        }

        private static double ConvertirAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

    }
}