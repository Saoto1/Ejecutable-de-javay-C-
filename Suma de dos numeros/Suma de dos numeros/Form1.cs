using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_de_dos_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //variables
            double numero1, numero2, resultado;

           //asignacion de valores
            numero1 = Convert.ToDouble(txtnum1.Text);
            numero2 = Convert.ToDouble(txtnum2.Text);

            //salida de datos
            resultado = numero1 + numero2;
            lbResultado.Text = resultado.ToString();
           


        }
    }
}
