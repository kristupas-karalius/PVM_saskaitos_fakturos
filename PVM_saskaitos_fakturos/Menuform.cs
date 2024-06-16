using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVM_saskaitos_fakturos
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void imones_Click(object sender, EventArgs e)
        {
            imones form3 = new imones();
            form3.Show();
            this.Hide();
        }

        private void btn_isras_Click(object sender, EventArgs e)
        {
            pasirinkti_produktus form6 = new pasirinkti_produktus();
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Israsytisaskaita form5 = new Israsytisaskaita();
            form5.Show();
            this.Hide();
        }

        private void btnsuvestine_Click(object sender, EventArgs e)
        {
            Suvestines form6 = new Suvestines();
            form6.Show();
            this.Hide();
        }
    }
}
