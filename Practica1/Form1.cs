using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btns_Click(object sender, EventArgs e)
        {
            result=Convert.ToDouble(txt1.Text)+Convert.ToDouble(txt2.Text);
            lblr.Text=result.ToString();
            label1.Text = "+" ;

        }

        private void btnm_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt2.Text);
            lblr.Text = result.ToString();
            label1.Text = "x";

        }

        private void btnr_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txt1.Text) - Convert.ToDouble(txt2.Text);
            lblr.Text = result.ToString();
            label1.Text = "-";

        }

        private void btnd_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txt1.Text) / Convert.ToDouble(txt2.Text);
            lblr.Text = result.ToString();
            label1.Text = "/";
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblr_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
