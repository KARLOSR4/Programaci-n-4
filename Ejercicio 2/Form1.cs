using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        int vIndice;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btna_Click(object sender, EventArgs e)
        {
            string vSeleccion;
            vSeleccion = Convert.ToString(combp.Text);
            int vIndice = dataGridView1.Rows.Add();
            dataGridView1.Rows[vIndice].Cells[0].Value = txtn.Text;
            dataGridView1.Rows[vIndice].Cells[1].Value = txta.Text;
            dataGridView1.Rows[vIndice].Cells[2].Value = vSeleccion;

            txtn.Text = "";
            txta.Text = "";
            combp.Text = "";
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            if (vIndice != -1)
            {
                dataGridView1.Rows.RemoveAt(vIndice);
            }
            else
            {
                MessageBox.Show("Selected Item Incorrect");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void combp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
