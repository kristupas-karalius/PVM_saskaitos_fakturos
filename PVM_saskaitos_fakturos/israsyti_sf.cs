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
    public partial class israsyti_sf : Form
    {
        public static israsyti_sf instance;
        public israsyti_sf()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_griz_Click(object sender, EventArgs e)
        {
            Menuform form5 = new Menuform();
            form5.Show();
            this.Hide();
        }

        private void btnpr_Click(object sender, EventArgs e)
        {
            pasirinkti_produktus form6 = new pasirinkti_produktus();
            form6.Show();
            this.Hide();
        }

        private void btnisrasyti_Click(object sender, EventArgs e)
        {
            //form9 Israsytisaskaita = new form9();
            //form9.ShowDialog  ();
        }
    }
}
