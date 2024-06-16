using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PVM_saskaitos_fakturos
{
    public partial class prideti_imone : Form
    {
        public prideti_imone()
        {
            InitializeComponent();
            
          //  SqlCommand cmd;
          //  SqlDataReader dr;
        }

        private void grizti_Click(object sender, EventArgs e)
        {
            imones form4 = new imones();
            form4.Show();
            this.Hide();
        }

        private void btnpri_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into imones1(pavadinimas,adresas,pvm_kodas,imones_kodas,bankas) values ('" + txtpav.Text + "', '" + txtadr.Text + "', '" + txtpvm.Text + "', '" + txtimo.Text + "','" + txtban.Text + "')", conn);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Įmonė išsaugota.");
            }
            else
            {
                MessageBox.Show("Klaida.");
            }
            conn.Close();
        }
    }
}
