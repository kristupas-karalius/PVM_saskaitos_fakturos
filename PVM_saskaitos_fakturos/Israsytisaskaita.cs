using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace PVM_saskaitos_fakturos
{
    public partial class Israsytisaskaita : Form
    {
        private DataTable invoiceData;
        private DataTable productData;
        private DataTable buyerData;
        private TextBox saskTextBox;
        private System.ComponentModel.IContainer components = null;

        public Israsytisaskaita()
        {
            InitializeComponent();
            this.Text = "Invoice";
            this.Size = new Size(1100, 600);

            Label label = new Label();
            label.Text = "Įveskite s/f seriją (SASK****):";
            label.Location = new Point(600, 10);
            this.Controls.Add(label);

            saskTextBox = new TextBox();
            saskTextBox.Location = new Point(750, 10);
            this.Controls.Add(saskTextBox);

            Button loadButton = new Button();
            loadButton.Text = "Atnaujinti";
            loadButton.Location = new Point(850, 10);
            loadButton.Click += new EventHandler(this.LoadButton_Click);
            this.Controls.Add(loadButton);

            Button printButton = new Button();
            printButton.Text = "Išsaugoti PDF";
            printButton.Location = new Point(950, 10);
            printButton.Click += new EventHandler(this.PrintButton_Click);
            this.Controls.Add(printButton);

            this.Paint += new PaintEventHandler(this.Israsytisaskaita_Paint);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadInvoiceData(saskTextBox.Text);
            this.Invalidate(); // Trigger a repaint to show the loaded data
        }

        private void LoadInvoiceData(string invoiceSeries)
        {
            // Define your connection string (modify it according to your database)
            string connectionString = @"Data Source=(localdb)\lokalus;Initial Catalog=PVM_SF;Integrated Security=True";

            // Define your queries
            string invoiceQuery = $"SELECT * FROM naujos_saskaitos WHERE saskaitosserija = '{invoiceSeries}'";
            string productsQuery = $"SELECT * FROM pirkimu_sarasas WHERE saskaitos_serija = '{invoiceSeries}'";
            string buyerQuery = $@"
                SELECT * 
                FROM imones1 
                WHERE pavadinimas = (
                    SELECT TOP 1 pirkejas 
                    FROM naujos_saskaitos 
                    WHERE saskaitosserija = '{invoiceSeries}'
                )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter invoiceAdapter = new SqlDataAdapter(invoiceQuery, connection);
                SqlDataAdapter productsAdapter = new SqlDataAdapter(productsQuery, connection);
                SqlDataAdapter buyerAdapter = new SqlDataAdapter(buyerQuery, connection);

                DataSet dataSet = new DataSet();

                invoiceAdapter.Fill(dataSet, "Invoice");
                productsAdapter.Fill(dataSet, "Products");
                buyerAdapter.Fill(dataSet, "Buyer");

                if (dataSet.Tables["Invoice"].Rows.Count == 0)
                {
                    MessageBox.Show("Nerasta s/f.");
                    return;
                }

                if (dataSet.Tables["Products"].Rows.Count == 0)
                {
                    MessageBox.Show("No product data found.");
                    return;
                }

                if (dataSet.Tables["Buyer"].Rows.Count == 0)
                {
                    MessageBox.Show("No buyer data found.");
                    return;
                }

                invoiceData = dataSet.Tables["Invoice"];
                productData = dataSet.Tables["Products"];
                buyerData = dataSet.Tables["Buyer"];
            }
        }

        private void Israsytisaskaita_Paint(object sender, PaintEventArgs e)
        {
            if (invoiceData == null || invoiceData.Rows.Count == 0 || buyerData == null || buyerData.Rows.Count == 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            XBrush brush = XBrushes.Black;
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10, FontStyle.Regular);

            // Draw the header
            g.DrawString("PVM SĄSKAITA - FAKTŪRA", headerFont, Brushes.Black, new PointF(300, 20));
            g.DrawString(invoiceData.Rows[0]["saskaitosserija"].ToString(), regularFont, Brushes.Black, new PointF(350, 50));
            g.DrawString(Convert.ToDateTime(invoiceData.Rows[0]["data"]).ToString("yyyy-MM-dd"), regularFont, Brushes.Black, new PointF(350, 70));

            // Draw seller and buyer information
            g.DrawString("Pardavėjas:", regularFont, Brushes.Black, new PointF(50, 100));
            g.DrawString("Pardavėjas1", regularFont, Brushes.Black, new PointF(50, 120));
            g.DrawString("Įmonės kodas: 123456789", regularFont, Brushes.Black, new PointF(50, 140));
            g.DrawString("Adresas: Adresas 1", regularFont, Brushes.Black, new PointF(50, 160));
            g.DrawString("PVM kodas: 123456789", regularFont, Brushes.Black, new PointF(50, 180));
            g.DrawString("A/S: LT11 1111 1111", regularFont, Brushes.Black, new PointF(50, 200));
            g.DrawString("Bankas: Bankas 1", regularFont, Brushes.Black, new PointF(50, 220));

            g.DrawString("Pirkėjas:", regularFont, Brushes.Black, new PointF(500, 100));
            g.DrawString(buyerData.Rows[0]["pavadinimas"].ToString(), regularFont, Brushes.Black, new PointF(500, 120));
            g.DrawString("Įmonės kodas: " + buyerData.Rows[0]["imones_kodas"].ToString(), regularFont, Brushes.Black, new PointF(500, 140));
            g.DrawString("Adresas: " + buyerData.Rows[0]["adresas"].ToString(), regularFont, Brushes.Black, new PointF(500, 160));
            g.DrawString("PVM kodas: " + buyerData.Rows[0]["pvm_kodas"].ToString(), regularFont, Brushes.Black, new PointF(500, 180));

            // Draw the table headers
            float yPosition = 260;
            g.DrawString("EIL. NR.", regularFont, Brushes.Black, new PointF(50, yPosition));
            g.DrawString("PAVADINIMAS", regularFont, Brushes.Black, new PointF(100, yPosition));
            g.DrawString("KIEKIS", regularFont, Brushes.Black, new PointF(250, yPosition));
            g.DrawString("KAINA (BE PVM)", regularFont, Brushes.Black, new PointF(350, yPosition));
            g.DrawString("SUMA (BE PVM)", regularFont, Brushes.Black, new PointF(450, yPosition));
            g.DrawString("PVM %", regularFont, Brushes.Black, new PointF(550, yPosition));
            g.DrawString("PVM", regularFont, Brushes.Black, new PointF(600, yPosition));
            g.DrawString("IŠ VISO", regularFont, Brushes.Black, new PointF(700, yPosition));

            // Draw the product rows
            yPosition += 20; // Move to the next line


            int rowNumber = 1;
            decimal totalWithoutVAT = 0;
            decimal totalVAT = 0;
            decimal totalWithVAT = 0;

            foreach (DataRow productRow in productData.Rows)
            {
                if (decimal.TryParse(productRow["kainabepvm"].ToString(), out decimal price) &&
                    decimal.TryParse(productRow["kainasupvm"].ToString(), out decimal total) &&
                    decimal.TryParse(productRow["VATkiekis"].ToString(), out decimal vatRate) &&
                    int.TryParse(productRow["kiekis"].ToString(), out int quantity))
                {
                    decimal sumWithoutVAT = price * quantity;
                    decimal vatAmount = (vatRate / 100) * sumWithoutVAT;
                    decimal sumWithVAT = sumWithoutVAT + vatAmount;

                    totalWithoutVAT += sumWithoutVAT;
                    totalVAT += vatAmount;
                    totalWithVAT += sumWithVAT;

                    g.DrawString(rowNumber.ToString(), regularFont, Brushes.Black, new PointF(50, yPosition));
                    g.DrawString(productRow["prekes_pavadinimas"].ToString(), regularFont, Brushes.Black, new PointF(100, yPosition));
                    g.DrawString(quantity.ToString(), regularFont, Brushes.Black, new PointF(250, yPosition));
                    g.DrawString(price.ToString("F2"), regularFont, Brushes.Black, new PointF(350, yPosition));
                    g.DrawString(sumWithoutVAT.ToString("F2"), regularFont, Brushes.Black, new PointF(450, yPosition));
                    g.DrawString(vatRate.ToString("F2"), regularFont, Brushes.Black, new PointF(550, yPosition));
                    g.DrawString(vatAmount.ToString("F2"), regularFont, Brushes.Black, new PointF(600, yPosition));
                    g.DrawString(sumWithVAT.ToString("F2"), regularFont, Brushes.Black, new PointF(700, yPosition));

                    yPosition += 20; // Move to the next line
                    rowNumber++;
                }
            }

            // Draw the totals
            yPosition += 20; // Add some space before totals
            g.DrawString("Suma žodžiais:", regularFont, Brushes.Black, new PointF(50, yPosition));
            g.DrawString("Keturiasdešimt aštuoni eurai 40 ct", regularFont, Brushes.Black, new PointF(200, yPosition));



            yPosition += 20; // Move to the next line
            g.DrawString("Sąskaita išrašė:", regularFont, Brushes.Black, new PointF(50, yPosition));
            g.DrawString(invoiceData.Rows[0]["saskaitaisrase"].ToString(), regularFont, Brushes.Black, new PointF(150, yPosition));

            yPosition += 20; // Move to the next line
            g.DrawString("Sąskaita gavo:", regularFont, Brushes.Black, new PointF(50, yPosition)); ;
            g.DrawString(invoiceData.Rows[0]["saskaitagavo"].ToString(), regularFont, Brushes.Black, new PointF(150, yPosition));




            yPosition += 20;
            g.DrawString("Iš viso (be PVM):", regularFont, Brushes.Black, new PointF(530, yPosition));
            g.DrawString(totalWithoutVAT.ToString("F2") + " €", regularFont, Brushes.Black, new PointF(650, yPosition));

            yPosition += 20; // Move to the next line
            g.DrawString("PVM:", regularFont, Brushes.Black, new PointF(530, yPosition));
            g.DrawString(totalVAT.ToString("F2") + " €", regularFont, Brushes.Black, new PointF(650, yPosition));

            yPosition += 20; // Move to the next line
            g.DrawString("Iš viso (su PVM):", regularFont, Brushes.Black, new PointF(530, yPosition));
            g.DrawString(totalWithVAT.ToString("F2") + " €", regularFont, Brushes.Black, new PointF(650, yPosition));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (invoiceData == null || invoiceData.Rows.Count == 0 || buyerData == null || buyerData.Rows.Count == 0)
            {
                MessageBox.Show("Nėra tokios sąskaitos faktūros (Patikrinti SASKxxxx numerį).");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file|*.pdf";
            saveFileDialog.Title = "Išsaugoti kaip PDF";
            saveFileDialog.FileName = "saskaita faktura.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (PdfDocument document = new PdfDocument())
                {
                    document.Info.Title = "Invoice";
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XBrush brush = XBrushes.Black;

                    // Define fonts directly with XFont
                    XFont headerFont = new XFont("Arial", 14);
                    XFont regularFont = new XFont("Arial", 10);

                    // Define margins
                    double leftMargin = 50;
                    double rightMargin = page.Width - 50;
                    double yPosition = 20;

                    // Draw the header
                    gfx.DrawString("PVM SĄSKAITA - FAKTŪRA", headerFont, brush, new XPoint((page.Width / 2) - 50, yPosition));
                    yPosition += 30;
                    gfx.DrawString(invoiceData.Rows[0]["saskaitosserija"].ToString(), regularFont, brush, new XPoint((page.Width / 2) - 30, yPosition));
                    yPosition += 20;
                    gfx.DrawString(Convert.ToDateTime(invoiceData.Rows[0]["data"]).ToString("yyyy-MM-dd"), regularFont, brush, new XPoint((page.Width / 2) - 30, yPosition));

                    // Draw seller and buyer information
                    yPosition += 40;
                    gfx.DrawString("Pardavėjas:", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Pardavėjas1", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Įmonės kodas: 123456789", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Adresas: Adresas 1", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("PVM kodas: 123456789", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("A/S: LT11 1111 1111", regularFont, brush, new XPoint(leftMargin, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Bankas: Bankas 1", regularFont, brush, new XPoint(leftMargin, yPosition));

                    double buyerInfoXPosition = leftMargin + 300;
                    yPosition = 100;
                    gfx.DrawString("Pirkėjas:", regularFont, brush, new XPoint(buyerInfoXPosition, yPosition));
                    yPosition += 20;
                    gfx.DrawString(buyerData.Rows[0]["pavadinimas"].ToString(), regularFont, brush, new XPoint(buyerInfoXPosition, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Įmonės kodas: " + buyerData.Rows[0]["imones_kodas"].ToString(), regularFont, brush, new XPoint(buyerInfoXPosition, yPosition));
                    yPosition += 20;
                    gfx.DrawString("Adresas: " + buyerData.Rows[0]["adresas"].ToString(), regularFont, brush, new XPoint(buyerInfoXPosition, yPosition));
                    yPosition += 20;
                    gfx.DrawString("PVM kodas: " + buyerData.Rows[0]["pvm_kodas"].ToString(), regularFont, brush, new XPoint(buyerInfoXPosition, yPosition));


                    // Draw the table headers

                    yPosition += 80;
                    gfx.DrawString("EIL. NR.", regularFont, brush, new XPoint(leftMargin, yPosition));
                    gfx.DrawString("PAVADINIMAS", regularFont, brush, new XPoint(leftMargin + 50, yPosition));
                    gfx.DrawString("KIEKIS", regularFont, brush, new XPoint(leftMargin + 150, yPosition));
                    gfx.DrawString("KAINA (BE PVM)", regularFont, brush, new XPoint(leftMargin + 200, yPosition));
                    gfx.DrawString("SUMA (BE PVM)", regularFont, brush, new XPoint(leftMargin + 300, yPosition));
                    gfx.DrawString("PVM %", regularFont, brush, new XPoint(leftMargin + 390, yPosition));
                    gfx.DrawString("PVM", regularFont, brush, new XPoint(leftMargin + 450, yPosition));
                    gfx.DrawString("IŠ VISO", regularFont, brush, new XPoint(leftMargin + 500, yPosition));

                    // Draw the product rows
                    yPosition += 20; // Move to the next line
                    int rowNumber = 1;
                    decimal totalWithoutVAT = 0;
                    decimal totalVAT = 0;
                    decimal totalWithVAT = 0;

                    foreach (DataRow productRow in productData.Rows)
                    {
                        if (decimal.TryParse(productRow["kainabepvm"].ToString(), out decimal price) &&
                            decimal.TryParse(productRow["kainasupvm"].ToString(), out decimal total) &&
                            decimal.TryParse(productRow["VATkiekis"].ToString(), out decimal vatRate) &&
                            int.TryParse(productRow["kiekis"].ToString(), out int quantity))
                        {
                            decimal sumWithoutVAT = price * quantity;
                            decimal vatAmount = (vatRate / 100) * sumWithoutVAT;
                            decimal sumWithVAT = sumWithoutVAT + vatAmount;

                            totalWithoutVAT += sumWithoutVAT;
                            totalVAT += vatAmount;
                            totalWithVAT += sumWithVAT;

                            gfx.DrawString(rowNumber.ToString(), regularFont, brush, new XPoint(leftMargin, yPosition));
                            gfx.DrawString(productRow["prekes_pavadinimas"].ToString(), regularFont, brush, new XPoint(leftMargin + 50, yPosition));
                            gfx.DrawString(quantity.ToString(), regularFont, brush, new XPoint(leftMargin + 150, yPosition));
                            gfx.DrawString(price.ToString("F2"), regularFont, brush, new XPoint(leftMargin + 200, yPosition));
                            gfx.DrawString(sumWithoutVAT.ToString("F2"), regularFont, brush, new XPoint(leftMargin + 300, yPosition));
                            gfx.DrawString(vatRate.ToString("F2"), regularFont, brush, new XPoint(leftMargin + 390, yPosition));
                            gfx.DrawString(vatAmount.ToString("F2"), regularFont, brush, new XPoint(leftMargin + 450, yPosition));
                            gfx.DrawString(sumWithVAT.ToString("F2"), regularFont, brush, new XPoint(leftMargin + 500, yPosition));

                            yPosition += 20; // Move to the next line
                            rowNumber++;
                        }
                    }

                    // Draw the totals
                    yPosition += 20; // Add some space before totals
                    gfx.DrawString("Suma žodžiais:", regularFont, brush, new XPoint(leftMargin, yPosition));
                    gfx.DrawString("Keturiasdešimt aštuoni eurai 40 ct", regularFont, brush, new XPoint(leftMargin + 150, yPosition));

                    yPosition += 20;
                    gfx.DrawString("Iš viso (be PVM):", regularFont, brush, new XPoint(leftMargin + 380, yPosition));
                    gfx.DrawString(totalWithoutVAT.ToString("F2") + " €", regularFont, brush, new XPoint(leftMargin + 480, yPosition));

                    yPosition += 20; // Move to the next line
                    gfx.DrawString("PVM:", regularFont, brush, new XPoint(leftMargin + 380, yPosition));
                    gfx.DrawString(totalVAT.ToString("F2") + " €", regularFont, brush, new XPoint(leftMargin + 480, yPosition));

                    yPosition += 20; // Move to the next line
                    gfx.DrawString("Iš viso (su PVM):", regularFont, brush, new XPoint(leftMargin + 380, yPosition));
                    gfx.DrawString(totalWithVAT.ToString("F2") + " €", regularFont, brush, new XPoint(leftMargin + 480, yPosition));


                    gfx.DrawString("Sąskaita išrašė:", regularFont, brush, new XPoint(leftMargin + 1, yPosition));
                    gfx.DrawString(invoiceData.Rows[0]["saskaitaisrase"].ToString(), regularFont, brush, new XPoint(leftMargin + 80, yPosition));

                    yPosition += 20; // Move to the next line
                    gfx.DrawString("Sąskaita gavo:", regularFont, brush, new XPoint(leftMargin + 1, yPosition));
                    gfx.DrawString(invoiceData.Rows[0]["saskaitagavo"].ToString(), regularFont, brush, new XPoint(leftMargin + 80, yPosition));

                    // Save the document
                    document.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("Sąskaita faktūra išsaugota PDF formatu");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuform form5 = new Menuform();
            form5.Show();
            this.Hide();
        }
    }
}
