using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_3
{
    public partial class Form1 : Form
    {
        double resultado, presultado, pi=3.1416;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbltext1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            Double Resultado, pi = 3.1416;
            resultado = Math.Pow(Convert.ToDouble(txtin.Text), 2) * pi;
            resulta.Text = resultado.ToString();
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            Double Resultado, pi = 3.1416;
            resultado = 2 * pi * Convert.ToDouble(txtin.Text);
            resultp.Text = resultado.ToString();

        }

        private void resulta_Click(object sender, EventArgs e)
        {

        }

        private void resultp_Click(object sender, EventArgs e)
        {

        }
    }
}
