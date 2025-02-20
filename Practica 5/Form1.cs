using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        int promedio;
        string Estatus;
        public Form1()
        {
            InitializeComponent();
            dgv.Columns.Add("Alumno", "Alumno");
            dgv.Columns.Add("Parcial 1", "Parcial 1");
            dgv.Columns.Add("Parcial 2", "Parcial 2");
            dgv.Columns.Add("Parcail 3", "Parcial 3");
            dgv.Columns.Add("Promedio", "Promedio");
            dgv.Columns.Add("Estatus", "Estatus");
        }

        private void btne_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtalum.Text) ||
                string.IsNullOrWhiteSpace(txt1.Text) ||
                string.IsNullOrWhiteSpace(txts.Text) ||
                string.IsNullOrWhiteSpace(txt3.Text))
            {
                
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            promedio = (Convert.ToInt32(txt1.Text) + Convert.ToInt32(txts.Text) + Convert.ToInt32(txt3.Text)) / 3;
            if (promedio >= 95)
            {
                Estatus = "Exento";
            }
            if (promedio >= 70 && promedio <= 94)
            {
                Estatus = "Ordinario";
            }
            if (promedio >= 50 && promedio <= 69)
            {
                Estatus = "Extraordinario";
            }
            if (promedio <= 49)
            {
                Estatus = "Especial";
            }

            int vIndice = dgv.Rows.Add();
            dgv.Rows[vIndice].Cells[0].Value = txtalum.Text;
            dgv.Rows[vIndice].Cells[1].Value = Convert.ToInt32(txt1.Text);
            dgv.Rows[vIndice].Cells[2].Value = Convert.ToInt32(txts.Text);
            dgv.Rows[vIndice].Cells[3].Value = Convert.ToInt32(txt3.Text);
            dgv.Rows[vIndice].Cells[4].Value = promedio;
            dgv.Rows[vIndice].Cells[5].Value = Estatus;

            txtalum.Text = "";
            txt1.Text = "";
            txts.Text = "";
            txt3.Text = "";
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtalum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
