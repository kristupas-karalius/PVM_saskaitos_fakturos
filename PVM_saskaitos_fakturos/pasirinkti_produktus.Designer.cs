namespace PVM_saskaitos_fakturos
{
    partial class pasirinkti_produktus
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
            btn_griz = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView11 = new DataGridView();
            preke = new DataGridViewTextBoxColumn();
            Kaina = new DataGridViewTextBoxColumn();
            Kiekis = new DataGridViewTextBoxColumn();
            PVM = new DataGridViewTextBoxColumn();
            Kainabe = new DataGridViewTextBoxColumn();
            kainasu = new DataGridViewTextBoxColumn();
            gisrase = new DataGridViewTextBoxColumn();
            ggavo = new DataGridViewTextBoxColumn();
            gsserija = new DataGridViewTextBoxColumn();
            txtkaina = new TextBox();
            txtkiekis = new TextBox();
            txtpvms = new TextBox();
            txtkainasu = new TextBox();
            btnprideti = new Button();
            btnisv = new Button();
            cmbpreke = new ComboBox();
            btnpvm = new Button();
            txtpvm = new TextBox();
            cmbpirk = new ComboBox();
            saskgavo = new Label();
            israse = new Label();
            txtisrase = new TextBox();
            txtgavo = new TextBox();
            label7 = new Label();
            txtsserija = new TextBox();
            txtpvmkeisti = new TextBox();
            btnkeistipvm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).BeginInit();
            SuspendLayout();
            // 
            // btn_griz
            // 
            btn_griz.Location = new Point(23, 17);
            btn_griz.Name = "btn_griz";
            btn_griz.Size = new Size(75, 23);
            btn_griz.TabIndex = 0;
            btn_griz.Text = "Grįžti atgal";
            btn_griz.UseVisualStyleBackColor = true;
            btn_griz.Click += btn_griz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 1;
            label2.Text = "Prekė";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 110);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "Kaina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 1;
            label3.Text = "Kiekis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 208);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 1;
            label4.Text = "PVM (%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 253);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 1;
            label5.Text = "Pirkėjas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 295);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 1;
            label6.Text = "Kaina su PVM";
            // 
            // dataGridView11
            // 
            dataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView11.Columns.AddRange(new DataGridViewColumn[] { preke, Kaina, Kiekis, PVM, Kainabe, kainasu, gisrase, ggavo, gsserija });
            dataGridView11.Location = new Point(307, 62);
            dataGridView11.Name = "dataGridView11";
            dataGridView11.Size = new Size(916, 425);
            dataGridView11.TabIndex = 2;
            // 
            // preke
            // 
            preke.HeaderText = "Prekė";
            preke.Name = "preke";
            // 
            // Kaina
            // 
            Kaina.HeaderText = "Kaina";
            Kaina.Name = "Kaina";
            // 
            // Kiekis
            // 
            Kiekis.HeaderText = "Kiekis";
            Kiekis.Name = "Kiekis";
            // 
            // PVM
            // 
            PVM.HeaderText = "PVM (%)";
            PVM.Name = "PVM";
            // 
            // Kainabe
            // 
            Kainabe.HeaderText = "Pirkėjas";
            Kainabe.Name = "Kainabe";
            // 
            // kainasu
            // 
            kainasu.HeaderText = "Kaina su PVM";
            kainasu.Name = "kainasu";
            // 
            // gisrase
            // 
            gisrase.HeaderText = "Sąskaitą išrašė";
            gisrase.Name = "gisrase";
            // 
            // ggavo
            // 
            ggavo.HeaderText = "Sąskaita gavo";
            ggavo.Name = "ggavo";
            // 
            // gsserija
            // 
            gsserija.HeaderText = "Sąskaitos serija";
            gsserija.Name = "gsserija";
            // 
            // txtkaina
            // 
            txtkaina.Location = new Point(145, 112);
            txtkaina.Name = "txtkaina";
            txtkaina.ReadOnly = true;
            txtkaina.Size = new Size(140, 23);
            txtkaina.TabIndex = 3;
            // 
            // txtkiekis
            // 
            txtkiekis.Location = new Point(145, 160);
            txtkiekis.Name = "txtkiekis";
            txtkiekis.Size = new Size(140, 23);
            txtkiekis.TabIndex = 3;
            txtkiekis.Text = "1";
            // 
            // txtpvms
            // 
            txtpvms.Enabled = false;
            txtpvms.Location = new Point(1047, 506);
            txtpvms.Name = "txtpvms";
            txtpvms.ReadOnly = true;
            txtpvms.Size = new Size(140, 23);
            txtpvms.TabIndex = 3;
            txtpvms.Visible = false;
            // 
            // txtkainasu
            // 
            txtkainasu.Location = new Point(145, 295);
            txtkainasu.Name = "txtkainasu";
            txtkainasu.ReadOnly = true;
            txtkainasu.Size = new Size(140, 23);
            txtkainasu.TabIndex = 3;
            // 
            // btnprideti
            // 
            btnprideti.Location = new Point(35, 476);
            btnprideti.Name = "btnprideti";
            btnprideti.Size = new Size(246, 23);
            btnprideti.TabIndex = 4;
            btnprideti.Text = "Pridėti produktą";
            btnprideti.UseVisualStyleBackColor = true;
            btnprideti.Click += btnprideti_Click;
            // 
            // btnisv
            // 
            btnisv.Location = new Point(35, 517);
            btnisv.Name = "btnisv";
            btnisv.Size = new Size(246, 23);
            btnisv.TabIndex = 5;
            btnisv.Text = "Įdėti į duomenų bazę";
            btnisv.UseVisualStyleBackColor = true;
            btnisv.Click += btnisv_Click;
            // 
            // cmbpreke
            // 
            cmbpreke.FormattingEnabled = true;
            cmbpreke.Location = new Point(145, 64);
            cmbpreke.Name = "cmbpreke";
            cmbpreke.Size = new Size(140, 23);
            cmbpreke.TabIndex = 6;
            cmbpreke.SelectedIndexChanged += cmbpreke_SelectedIndexChanged;
            // 
            // btnpvm
            // 
            btnpvm.Location = new Point(35, 438);
            btnpvm.Name = "btnpvm";
            btnpvm.Size = new Size(246, 23);
            btnpvm.TabIndex = 4;
            btnpvm.Text = "Apskaičiuoti PVM";
            btnpvm.UseVisualStyleBackColor = true;
            btnpvm.Click += btnpvm_Click;
            // 
            // txtpvm
            // 
            txtpvm.Location = new Point(145, 208);
            txtpvm.Name = "txtpvm";
            txtpvm.ReadOnly = true;
            txtpvm.Size = new Size(140, 23);
            txtpvm.TabIndex = 3;
            // 
            // cmbpirk
            // 
            cmbpirk.FormattingEnabled = true;
            cmbpirk.Location = new Point(145, 253);
            cmbpirk.Name = "cmbpirk";
            cmbpirk.Size = new Size(140, 23);
            cmbpirk.TabIndex = 7;
            cmbpirk.SelectedIndexChanged += cmbpirk_SelectedIndexChanged;
            // 
            // saskgavo
            // 
            saskgavo.AutoSize = true;
            saskgavo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saskgavo.Location = new Point(12, 401);
            saskgavo.Name = "saskgavo";
            saskgavo.Size = new Size(108, 21);
            saskgavo.TabIndex = 1;
            saskgavo.Text = "Sąskaita gavo:";
            // 
            // israse
            // 
            israse.AutoSize = true;
            israse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            israse.Location = new Point(12, 370);
            israse.Name = "israse";
            israse.Size = new Size(114, 21);
            israse.TabIndex = 1;
            israse.Text = "Sąskaita išrašė:";
            // 
            // txtisrase
            // 
            txtisrase.Location = new Point(132, 370);
            txtisrase.Name = "txtisrase";
            txtisrase.Size = new Size(153, 23);
            txtisrase.TabIndex = 8;
            // 
            // txtgavo
            // 
            txtgavo.Location = new Point(132, 401);
            txtgavo.Name = "txtgavo";
            txtgavo.Size = new Size(153, 23);
            txtgavo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 330);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 1;
            label7.Text = "Sąskaitos serija";
            // 
            // txtsserija
            // 
            txtsserija.Location = new Point(145, 332);
            txtsserija.Name = "txtsserija";
            txtsserija.Size = new Size(140, 23);
            txtsserija.TabIndex = 3;
            txtsserija.Text = "SASK";
            // 
            // txtpvmkeisti
            // 
            txtpvmkeisti.Location = new Point(378, 517);
            txtpvmkeisti.Name = "txtpvmkeisti";
            txtpvmkeisti.Size = new Size(100, 23);
            txtpvmkeisti.TabIndex = 9;
            // 
            // btnkeistipvm
            // 
            btnkeistipvm.Location = new Point(494, 517);
            btnkeistipvm.Name = "btnkeistipvm";
            btnkeistipvm.Size = new Size(110, 23);
            btnkeistipvm.TabIndex = 10;
            btnkeistipvm.Text = "Pakeisti PVM dydį";
            btnkeistipvm.UseVisualStyleBackColor = true;
            btnkeistipvm.Click += btnkeistipvm_Click;
            // 
            // pasirinkti_produktus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 565);
            Controls.Add(btnkeistipvm);
            Controls.Add(txtpvmkeisti);
            Controls.Add(txtgavo);
            Controls.Add(txtisrase);
            Controls.Add(cmbpirk);
            Controls.Add(cmbpreke);
            Controls.Add(btnisv);
            Controls.Add(btnpvm);
            Controls.Add(btnprideti);
            Controls.Add(txtsserija);
            Controls.Add(txtkainasu);
            Controls.Add(txtpvms);
            Controls.Add(txtpvm);
            Controls.Add(txtkiekis);
            Controls.Add(txtkaina);
            Controls.Add(dataGridView11);
            Controls.Add(israse);
            Controls.Add(saskgavo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_griz);
            Name = "pasirinkti_produktus";
            Text = "pasirinkti_produktus";
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_griz;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView11;
        private TextBox txtkaina;
        private TextBox txtkiekis;
        private TextBox txtpvms;
        private TextBox txtkainasu;
        private Button btnprideti;
        private Button btnisv;
        private ComboBox cmbpreke;
        private Button btnpvm;
        private TextBox txtpvm;
        private DataGridViewTextBoxColumn preke;
        private DataGridViewTextBoxColumn Kaina;
        private DataGridViewTextBoxColumn Kiekis;
        private DataGridViewTextBoxColumn PVM;
        private DataGridViewTextBoxColumn Kainabe;
        private DataGridViewTextBoxColumn kainasu;
        private ComboBox cmbpirk;
        private DataGridViewTextBoxColumn gisrase;
        private DataGridViewTextBoxColumn ggavo;
        private Label saskgavo;
        private Label israse;
        private TextBox txtisrase;
        private TextBox txtgavo;
        private DataGridViewTextBoxColumn gsserija;
        private Label label7;
        private TextBox txtsserija;
        private TextBox txtpvmkeisti;
        private Button btnkeistipvm;
    }
}