namespace PVM_saskaitos_fakturos
{
    partial class imones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sarasas = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_pakeisti = new Button();
            txtpavadinimas = new TextBox();
            txtadresas = new TextBox();
            txtpvm = new TextBox();
            txtim = new TextBox();
            txtbankas = new TextBox();
            txtid = new TextBox();
            pridet = new Button();
            btn_griz = new Button();
            SuspendLayout();
            // 
            // sarasas
            // 
            sarasas.FormattingEnabled = true;
            sarasas.Location = new Point(352, 12);
            sarasas.Name = "sarasas";
            sarasas.Size = new Size(110, 23);
            sarasas.TabIndex = 1;
            sarasas.Text = "Pasirinkti įmonę";
            sarasas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 196);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Adresas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 238);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "PVM Kodas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 279);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 2;
            label4.Text = "Įmonės kodas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 317);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 2;
            label5.Text = "Bankas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 164);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 6;
            label6.Text = "Pavadinimas";
            // 
            // btn_pakeisti
            // 
            btn_pakeisti.Location = new Point(150, 129);
            btn_pakeisti.Name = "btn_pakeisti";
            btn_pakeisti.Size = new Size(119, 23);
            btn_pakeisti.TabIndex = 7;
            btn_pakeisti.Text = "Pakeisti duomenis";
            btn_pakeisti.UseVisualStyleBackColor = true;
            btn_pakeisti.Click += btn_pakeisti_Click;
            // 
            // txtpavadinimas
            // 
            txtpavadinimas.Location = new Point(150, 164);
            txtpavadinimas.Name = "txtpavadinimas";
            txtpavadinimas.Size = new Size(546, 23);
            txtpavadinimas.TabIndex = 8;
            // 
            // txtadresas
            // 
            txtadresas.Location = new Point(150, 196);
            txtadresas.Name = "txtadresas";
            txtadresas.Size = new Size(546, 23);
            txtadresas.TabIndex = 8;
            // 
            // txtpvm
            // 
            txtpvm.Location = new Point(150, 230);
            txtpvm.Name = "txtpvm";
            txtpvm.Size = new Size(546, 23);
            txtpvm.TabIndex = 8;
            // 
            // txtim
            // 
            txtim.Location = new Point(150, 271);
            txtim.Name = "txtim";
            txtim.Size = new Size(546, 23);
            txtim.TabIndex = 8;
            // 
            // txtbankas
            // 
            txtbankas.Location = new Point(150, 314);
            txtbankas.Name = "txtbankas";
            txtbankas.Size = new Size(546, 23);
            txtbankas.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Location = new Point(372, 399);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(67, 23);
            txtid.TabIndex = 9;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // pridet
            // 
            pridet.Location = new Point(577, 129);
            pridet.Name = "pridet";
            pridet.Size = new Size(119, 23);
            pridet.TabIndex = 10;
            pridet.Text = "Pridėti naują įmonę";
            pridet.UseVisualStyleBackColor = true;
            pridet.Click += pridet_Click;
            // 
            // btn_griz
            // 
            btn_griz.Location = new Point(150, 12);
            btn_griz.Name = "btn_griz";
            btn_griz.Size = new Size(75, 23);
            btn_griz.TabIndex = 11;
            btn_griz.Text = "Grįžti";
            btn_griz.UseVisualStyleBackColor = true;
            btn_griz.Click += btn_griz_Click;
            // 
            // imones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_griz);
            Controls.Add(pridet);
            Controls.Add(txtid);
            Controls.Add(txtbankas);
            Controls.Add(txtim);
            Controls.Add(txtpvm);
            Controls.Add(txtadresas);
            Controls.Add(txtpavadinimas);
            Controls.Add(btn_pakeisti);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sarasas);
            Name = "imones";
            Text = "imones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox sarasas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        //private Button imon_sar;
      //  private TextBox textBox1;
    //    private TextBox textBox2;
  //      private TextBox textBox3;
       // private TextBox textBox4;
     //   private TextBox textBox5;
        private Label label6;
        private Button btn_pakeisti;
        private TextBox txtpavadinimas;
        private TextBox txtadresas;
        private TextBox txtpvm;
        private TextBox txtim;
        private TextBox txtbankas;
        private TextBox txtid;
        private Button pridet;
        private Button btn_griz;
    }
}