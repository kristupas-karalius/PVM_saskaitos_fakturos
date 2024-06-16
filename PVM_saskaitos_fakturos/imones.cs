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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace PVM_saskaitos_fakturos
{
    public partial class imones : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        public imones()
        {
            InitializeComponent();
            string sql = "SELECT * from imones1";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sarasas.Items.Add(dr["pavadinimas"]);
            }
            conn.Close();
        }

        //  private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        // {

        //}



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            cmd = new SqlCommand("SELECT * from imones1 where Pavadinimas=@pavadinimas", conn);
            cmd.Parameters.AddWithValue("@pavadinimas", sarasas.Text);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string pavadinimas1 = dr["pavadinimas"].ToString();
                string adresas = dr["adresas"].ToString();
                string pvm_kodas = dr["pvm_kodas"].ToString();
                string imones_kodas = dr["imones_kodas"].ToString();
                string bankas = dr["bankas"].ToString();
                string name_id = dr["id"].ToString();

                txtpavadinimas.Text = pavadinimas1;
                txtadresas.Text = adresas;
                txtpvm.Text = pvm_kodas;
                txtim.Text = imones_kodas;
                txtbankas.Text = bankas;
                txtid.Text = name_id;
            }
            conn.Close();
        }

        private void btn_pakeisti_Click(object sender, EventArgs e)
        {



            conn.Open();

            string pavadinimas = txtpavadinimas.Text;
            string adresas = txtadresas.Text;
            string pvm_kodas = txtpvm.Text;
            string imones_kodas = txtim.Text;
            string bankas = txtbankas.Text;
            string id = txtid.Text;



            //     string pavadinimas = dr["pavadinimas"].ToString();
            //          string adresas = dr["adresas"].ToString();
            //          string pvm_kodas = dr["pvm_kodas"].ToString();
            //            string imones_kodas = dr["imones_kodas"].ToString();
            //             string bankas = dr["bankas"].ToString();
            //    string name_id = dr["id"].ToString();

            //  txtpavadinimas.Text = pavadinimas;
            //   txtadresas.Text = adresas;
            //     txtpvm.Text = pvm_kodas;
            //       txtim.Text = imones_kodas;
            //        txtbankas.Text = bankas;
            //  txtid.Text = name_id;



            //       string pavadinimas = txtpavadinimas.Text;
            //       string adresas = txtadresas.Text;
            //       string pvm_kodas = txtpvm.Text;
            //       string imones_kodas = txtim.Text;
            //       string bankas = txtbankas.Text;

            string Query = ("update imones1 set pavadinimas = '" + pavadinimas + "', adresas = '" + adresas + "', pvm_kodas = '" + pvm_kodas + "', imones_kodas = '" + imones_kodas + "', bankas = '" + bankas + "' WHERE ID = " + id);
            //   SqlDataAdapter d = new SqlDataAdapter(Query, conn);
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pridet_Click(object sender, EventArgs e)
        {
            prideti_imone form3 = new prideti_imone();
            form3.Show();
            this.Hide();
        }

        private void btn_griz_Click(object sender, EventArgs e)
        {
            Menuform form4 = new Menuform();
            form4.Show();
            this.Hide();
        }
    }
}
   // public void imon_sar_Click(object sender, EventArgs e)
   // {
       // string query = "select * from imones1";

      //  SqlDataAdapter d = new SqlDataAdapter(query, conn);
    //    DataTable dt = new DataTable();
        //d.Fill(dt);
       // sarasas.DataSource = dt;
     //   sarasas.DisplayMember = "pavadinimas";

   // }


