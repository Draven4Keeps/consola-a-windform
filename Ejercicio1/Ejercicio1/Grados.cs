using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
        }

        private void Grados_Load(object sender, EventArgs e)
        {
           
            
        }
        static double ConvertirAGrados(double grados)
        {
            return grados * (Math.PI / 180);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grados = int.Parse(GradosARadianes.Text);
            double resultado;

            resultado = ConvertirAGrados(grados);
            MessageBox.Show($"Eso son {resultado}radianes.");
        }
    }
}
