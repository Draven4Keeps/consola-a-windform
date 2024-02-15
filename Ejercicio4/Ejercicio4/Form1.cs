using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(((NumEnt.Text)));

            if (numero % 2 == 0 ) 
            {
                MessageBox.Show("El numero es par.");
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }
        }
    }
}
