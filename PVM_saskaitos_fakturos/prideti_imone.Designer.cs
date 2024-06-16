namespace PVM_saskaitos_fakturos
{
    partial class prideti_imone
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
            grizti = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtpav = new TextBox();
            txtadr = new TextBox();
            txtpvm = new TextBox();
            txtimo = new TextBox();
            txtban = new TextBox();
            btnpri = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // grizti
            // 
            grizti.Location = new Point(12, 12);
            grizti.Name = "grizti";
            grizti.Size = new Size(75, 23);
            grizti.TabIndex = 0;
            grizti.Text = "Grįžti atgal";
            grizti.UseVisualStyleBackColor = true;
            grizti.Click += grizti_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 120);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 152);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Adresas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 191);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "PVM Kodas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 230);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "Įmonės kodas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 272);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 1;
            label5.Text = "Bankas";
            // 
            // txtpav
            // 
            txtpav.Location = new Point(168, 120);
            txtpav.Name = "txtpav";
            txtpav.Size = new Size(537, 23);
            txtpav.TabIndex = 2;
            // 
            // txtadr
            // 
            txtadr.Location = new Point(168, 152);
            txtadr.Name = "txtadr";
            txtadr.Size = new Size(537, 23);
            txtadr.TabIndex = 2;
            // 
            // txtpvm
            // 
            txtpvm.Location = new Point(168, 191);
            txtpvm.Name = "txtpvm";
            txtpvm.Size = new Size(537, 23);
            txtpvm.TabIndex = 2;
            // 
            // txtimo
            // 
            txtimo.Location = new Point(168, 230);
            txtimo.Name = "txtimo";
            txtimo.Size = new Size(537, 23);
            txtimo.TabIndex = 2;
            // 
            // txtban
            // 
            txtban.Location = new Point(168, 272);
            txtban.Name = "txtban";
            txtban.Size = new Size(537, 23);
            txtban.TabIndex = 2;
            // 
            // btnpri
            // 
            btnpri.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpri.Location = new Point(362, 301);
            btnpri.Name = "btnpri";
            btnpri.Size = new Size(115, 70);
            btnpri.TabIndex = 3;
            btnpri.Text = "Pridėti įmonę!";
            btnpri.UseVisualStyleBackColor = true;
            btnpri.Click += btnpri_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(308, 69);
            label6.Name = "label6";
            label6.Size = new Size(191, 21);
            label6.TabIndex = 4;
            label6.Text = "Naujos įmonęs duomenys";
            // 
            // prideti_imone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnpri);
            Controls.Add(txtban);
            Controls.Add(txtimo);
            Controls.Add(txtpvm);
            Controls.Add(txtadr);
            Controls.Add(txtpav);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grizti);
            Name = "prideti_imone";
            Text = "prideti_imone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button grizti;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtpav;
        private TextBox txtadr;
        private TextBox txtpvm;
        private TextBox txtimo;
        private TextBox txtban;
        private Button btnpri;
        private Label label6;
    }
}