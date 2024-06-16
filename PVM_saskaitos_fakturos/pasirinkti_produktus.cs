using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PVM_saskaitos_fakturos
{
    public partial class pasirinkti_produktus : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public static pasirinkti_produktus instance;

        public pasirinkti_produktus()
        {
            InitializeComponent();
            instance = this;
            LoadComboBoxData();


        }

        private void LoadComboBoxData()
        {
            string sql = "SELECT * FROM prekes";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbpreke.Items.Add(dr["preke"]);
            }
            conn.Close();

            string sql4 = "SELECT pvm From pvm_dydis";
            cmd = new SqlCommand(sql4, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtpvm.Text = dr["pvm"].ToString();
            }
            conn.Close();


            string sql1 = "SELECT * FROM imones1";
            cmd = new SqlCommand(sql1, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbpirk.Items.Add(dr["pavadinimas"]);
            }
            conn.Close();

            string sql2 = "SELECT * FROM naujos_saskaitos";
            cmd = new SqlCommand(sql2, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtsserija.Text = "SASK" + dr["id"].ToString();
            }
            conn.Close();

        }

        private void btn_griz_Click(object sender, EventArgs e)
        {
            Menuform form5 = new Menuform();
            form5.Show();
            this.Hide();
        }

        private void cmbpreke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM prekes WHERE preke=@preke", conn);
            cmd.Parameters.AddWithValue("@preke", cmbpreke.Text);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string kaina = dr["kaina"].ToString();
                txtkaina.Text = kaina;
            }
            conn.Close();
        }

        public void btnpvm_Click(object sender, EventArgs e)
        {
            double quan = double.Parse(txtkiekis.Text);
            int kaina = int.Parse(txtkaina.Text);
            double pvm = double.Parse(txtpvm.Text) / 100;
            double result = kaina * pvm;
            double result1 = (kaina * pvm + kaina) * quan;

            txtpvms.Text = result.ToString();
            txtkainasu.Text = result1.ToString();
        }

        private void btnprideti_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView11.Rows.Add();
            DataGridViewRow row = dataGridView11.Rows[rowIndex];

            row.Cells["preke"].Value = cmbpreke.Text;
            row.Cells["Kaina"].Value = txtkaina.Text;
            row.Cells["Kiekis"].Value = txtkiekis.Text;
            row.Cells["PVM"].Value = txtpvm.Text;
            row.Cells["Kainabe"].Value = cmbpirk.Text;
            row.Cells["kainasu"].Value = txtkainasu.Text;
            row.Cells["gisrase"].Value = txtisrase.Text;
            row.Cells["ggavo"].Value = txtgavo.Text;
            row.Cells["gsserija"].Value = txtsserija.Text;
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnisv_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True");
            for (int i = 0; i < dataGridView11.Rows.Count; i++)
            {
                // Skip the last row if it is a new row placeholder
                if (dataGridView11.Rows[i].IsNewRow) continue;

                using (SqlCommand cmd = new SqlCommand("INSERT INTO naujos_saskaitos (kainabepvm, pirkejas, pvmsuma, kainasupvm, saskaitaisrase, saskaitagavo, data, saskaitosserija) VALUES (@kaina, @kainabe, @pvm, @kainasu, @gisrase, @ggavo, @date, @gsserija)", conn))
                {
                    cmd.Parameters.AddWithValue("@kaina", dataGridView11.Rows[i].Cells["Kaina"].Value);
                    cmd.Parameters.AddWithValue("@kainabe", dataGridView11.Rows[i].Cells["kainabe"].Value);
                    cmd.Parameters.AddWithValue("@pvm", dataGridView11.Rows[i].Cells["PVM"].Value);
                    cmd.Parameters.AddWithValue("@kainasu", dataGridView11.Rows[i].Cells["kainasu"].Value);
                    cmd.Parameters.AddWithValue("@gisrase", dataGridView11.Rows[i].Cells["gisrase"].Value);
                    cmd.Parameters.AddWithValue("@ggavo", dataGridView11.Rows[i].Cells["ggavo"].Value);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@gsserija", dataGridView11.Rows[i].Cells["gsserija"].Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO pirkimu_sarasas (prekes_pavadinimas, kainabepvm, kiekis, saskaitos_serija, kainasupvm, VATkiekis) VALUES (@preke, @kaina, @kiekis, @gsserija, @kainasu, @pvm)", conn))
                {
                    cmd1.Parameters.AddWithValue("@preke", dataGridView11.Rows[i].Cells["preke"].Value);
                    cmd1.Parameters.AddWithValue("@kaina", dataGridView11.Rows[i].Cells["Kaina"].Value);
                    cmd1.Parameters.AddWithValue("@kiekis", dataGridView11.Rows[i].Cells["Kiekis"].Value);
                    cmd1.Parameters.AddWithValue("@gsserija", dataGridView11.Rows[i].Cells["gsserija"].Value);
                    cmd1.Parameters.AddWithValue("@kainasu", dataGridView11.Rows[i].Cells["kainasu"].Value);
                    cmd1.Parameters.AddWithValue("@pvm", dataGridView11.Rows[i].Cells["pvm"].Value);

                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                }
            }


        }

        private void cmbpirk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnkeistipvm_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True";
            string newValue = txtpvmkeisti.Text; 
            string updateQuery = "UPDATE pvm_dydis SET pvm = @newValue";
            string selectQuery = "SELECT pvm FROM pvm_dydis";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newValue", newValue);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("PVM dydis pakeistas.");

                            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                            {
                                using (SqlDataReader reader = selectCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        txtpvm.Text = reader["pvm"].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to retrieve the updated value from the database.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Klaida");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida: {ex.Message}");
            }
            

        }


    }
  }

