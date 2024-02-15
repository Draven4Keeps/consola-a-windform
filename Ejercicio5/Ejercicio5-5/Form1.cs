using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string producto = (NombreP.Text);
            
            double precio = double.Parse(PrecioP.Text);

            double impuesto = 0.0;

            if (producto.ToLower() != "medicina")
            {
                impuesto = 0.1;
            }

            double impuestoTotal = precio * impuesto;
            double precioTotal = precio + impuestoTotal;

            MessageBox.Show($"El precio total es: {precioTotal} pesos Mexicanos. Con un impuesto de: {impuestoTotal} pesos Mexicanos.");

        }

        
    }
}
