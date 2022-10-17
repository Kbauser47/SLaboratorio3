using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaboratorio3
{
    public partial class Form1 : Form
    {

        ColaCicular c = new ColaCicular();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {

            string x = txtNum.Text;
            if (c.Llena())
                MessageBox.Show("Error: La cola circular esta llena");
            else
            {
                c.Insertar(x);
                listMuestra.Items.Add(x);
            }

        }

        private void btnElim_Click(object sender, EventArgs e)
        {

            string x;
            if (c.Vacia())
                MessageBox.Show("Error: La cola circular esta VACIA");
            else
            {
                x = c.Eliminar();
                listMuestra.Items.Remove(x);
            }

        }
    }
}
