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
    public partial class Radianes : Form
    {
        private double radianes;

        public Radianes()
        {
            InitializeComponent();
        }

        private void Radianes_Load(object sender, EventArgs e)
        {
         
        }

        static double ConvertirARadianes(double radianes)
        {

            return radianes * (180 / Math.PI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radianes = int.Parse(GradosARadianes.Text);
            double resultado;
            
            resultado = ConvertirARadianes(radianes);
            MessageBox.Show($"Eso son {resultado}grados.");
        }
    }
}
