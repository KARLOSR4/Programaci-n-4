using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        int vresultado, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Resultadolbl_Click(object sender, EventArgs e)
        {

        }

        private void lblin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnco_Click(object sender, EventArgs e)
        {
            vresultado = Convert.ToInt32(lblin.Text) * 9 / 5 + 32;
            label3.Text = vresultado.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtf_TextChanged(object sender, EventArgs e)
        {

        }

        private void result2_Click(object sender, EventArgs e)
        {

        }

        private void result3_Click(object sender, EventArgs e)
        {

        }

        private void Convertir2_Click(object sender, EventArgs e)
        {
            result = Convert.ToInt32(txtf.Text) - 32 * 5 / 9;
            result3.Text = result.ToString();
        }
    }
}
