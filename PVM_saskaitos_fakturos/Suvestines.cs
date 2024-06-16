using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PVM_saskaitos_fakturos
{
    public partial class Suvestines : Form
    {
        private DataGridView dataGridView;
        private TextBox fromDateTextBox;
        private TextBox toDateTextBox;
        private TextBox pavadinimasTextBox;
        private Button loadButton;

        public Suvestines()
        {
            InitializeComponent();
            this.Text = "Gautų sąskaitų faktūrų registras";
            this.Size = new Size(1000, 700);

            Label periodLabel = new Label();
            periodLabel.Text = "Laikotarpis (YYYY-MM-DD):";
            periodLabel.Location = new Point(10, 10);
            this.Controls.Add(periodLabel);

            fromDateTextBox = new TextBox();
            fromDateTextBox.Location = new Point(180, 10);
            this.Controls.Add(fromDateTextBox);

            toDateTextBox = new TextBox();
            toDateTextBox.Location = new Point(300, 10);
            this.Controls.Add(toDateTextBox);

            Label pavadinimasLabel = new Label();
            pavadinimasLabel.Text = "Įmonė:";
            pavadinimasLabel.Location = new Point(10, 40);
            this.Controls.Add(pavadinimasLabel);

            pavadinimasTextBox = new TextBox();
            pavadinimasTextBox.Location = new Point(180, 40);
            this.Controls.Add(pavadinimasTextBox);

            loadButton = new Button();
            loadButton.Text = "Ieškoti";
            loadButton.Location = new Point(500, 25);
            loadButton.Click += new EventHandler(this.LoadButton_Click);
            this.Controls.Add(loadButton);

            dataGridView = new DataGridView();
            dataGridView.Location = new Point(10, 80);
            dataGridView.Size = new Size(960, 560);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            this.Controls.Add(dataGridView);

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "EilNr", HeaderText = "Eil. Nr.", DataPropertyName = "EilNr", Width = 50 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "IsrasymoData", HeaderText = "Išrašymo data", DataPropertyName = "IsrasymoData", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Serija", HeaderText = "Serija", DataPropertyName = "Serija", Width = 50 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Pavadinimas", HeaderText = "Pirkėjo arba pardavėjo pavadinimas", DataPropertyName = "Pavadinimas", Width = 200 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Kodas", HeaderText = "Pirkėjo arba pardavėjo kodas", DataPropertyName = "Kodas", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "PVMKodas", HeaderText = "Pirkėjo arba pardavėjo PVM mokėtojo kodas", DataPropertyName = "PVMKodas", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "SumaBePVM", HeaderText = "Suma be PVM Eur", DataPropertyName = "SumaBePVM", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "PVMSuma", HeaderText = "PVM suma", DataPropertyName = "PVMSuma", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "VisoSuPVM", HeaderText = "Viso su PVM", DataPropertyName = "VisoSuPVM", Width = 100 });
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadInvoiceData(fromDateTextBox.Text, toDateTextBox.Text, pavadinimasTextBox.Text);
        }

        private void LoadInvoiceData(string fromDate, string toDate, string pavadinimas)
        {
            string connectionString = @"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True";

            string query = $@"
        SELECT 
            NS.saskaitosserija AS Serija,
            MIN(NS.data) AS IsrasymoData, 
            C.pavadinimas AS Pavadinimas,
            C.imones_kodas AS Kodas,
            C.pvm_kodas AS PVMKodas,
            SUM(CAST(P.kainabepvm AS DECIMAL(18, 2)) * CAST(P.kiekis AS INT)) AS SumaBePVM,  -- Multiply by quantity
           SUM(CAST(P.kainasupvm AS DECIMAL(18, 2))) AS VisoSuPVM,
    SUM(CAST(P.kainasupvm AS DECIMAL(18, 2)) - (CAST(P.kainabepvm AS DECIMAL(18, 2)) * CAST(P.kiekis AS INT))) AS PVMSuma,
            SUM(CAST(P.kiekis AS INT)) AS Kiekis  -- Include quantity
        FROM 
            naujos_saskaitos NS
        JOIN 
            imones1 C ON NS.pirkejas = C.pavadinimas
        JOIN 
            pirkimu_sarasas P ON NS.saskaitosserija = P.saskaitos_serija
        WHERE 
            NS.data BETWEEN '{fromDate}' AND '{toDate}'
            AND C.pavadinimas = '{pavadinimas}'
        GROUP BY 
            NS.saskaitosserija, 
            C.pavadinimas, 
            C.imones_kodas, 
            C.pvm_kodas";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    dataTable.Columns.Add("EilNr", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["EilNr"] = i + 1; 
                    }

                    dataGridView.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nerasta įrašų.");
                    }
                    else
                    {
                        MessageBox.Show($"{dataTable.Rows.Count} rasti(as) įrašai(as).");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
        }

        private void Suvestines_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuform form5 = new Menuform();
            form5.Show();
            this.Hide();
        }

        //    [STAThread]
        //  static void Main()
        //    {
        //       Application.EnableVisualStyles();
        //        Application.SetCompatibleTextRenderingDefault(false);
        //        Application.Run(new Suvestines());
        //    }
    }
}
