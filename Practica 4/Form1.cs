using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void lblpw_Click(object sender, EventArgs e)
        {

        }

        private void btnl_Click(object sender, EventArgs e)
        {
            string usuario, pass;
            usuario=textBox1.Text;

            pass=txtp.Text;

            if (usuario == "Admin" && pass == "admin")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }

            else
            {
                MessageBox.Show("ERROR, Verifique el Usarname, Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
