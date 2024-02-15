using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dias = int.Parse(Dia.Text);

            if (dias == 1)
            {
                MessageBox.Show("Es Lunes");
            }
            if (dias == 2)
            {
                MessageBox.Show("Es Martes");
            }
            if (dias == 3)
            {
                MessageBox.Show("Es Miercoles");
            }
            if (dias == 4)
            {
                MessageBox.Show("Es Jueves");
            }
            if(dias == 5)
            {
                MessageBox.Show("Es Viernes");
            }
            if (dias == 6)
            {
                MessageBox.Show("Es Sabado");
            }
            if (dias == 7)
            {
                MessageBox.Show("Es Domingo");
            }
        }
    }
}