namespace PVM_saskaitos_fakturos
{
    partial class israsyti_sf
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
            cmb_imone = new ComboBox();
            label1 = new Label();
            btnpr = new Button();
            btnisrasyti = new Button();
            SuspendLayout();
            // 
            // btn_griz
            // 
            btn_griz.Location = new Point(12, 12);
            btn_griz.Name = "btn_griz";
            btn_griz.Size = new Size(75, 30);
            btn_griz.TabIndex = 0;
            btn_griz.Text = "Grįžti atgal";
            btn_griz.UseVisualStyleBackColor = true;
            btn_griz.Click += btn_griz_Click;
            // 
            // cmb_imone
            // 
            cmb_imone.FormattingEnabled = true;
            cmb_imone.Location = new Point(117, 37);
            cmb_imone.Name = "cmb_imone";
            cmb_imone.Size = new Size(121, 23);
            cmb_imone.TabIndex = 1;
            cmb_imone.Text = "Pasirinkti įmonę";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 2;
            label1.Text = "Įmonė, kuriai išrašoma s/f";
            // 
            // btnpr
            // 
            btnpr.Location = new Point(12, 83);
            btnpr.Name = "btnpr";
            btnpr.Size = new Size(75, 47);
            btnpr.TabIndex = 3;
            btnpr.Text = "Pasirinkti produktus";
            btnpr.UseVisualStyleBackColor = true;
            btnpr.Click += btnpr_Click;
            // 
            // btnisrasyti
            // 
            btnisrasyti.Location = new Point(12, 153);
            btnisrasyti.Name = "btnisrasyti";
            btnisrasyti.Size = new Size(75, 67);
            btnisrasyti.TabIndex = 4;
            btnisrasyti.Text = "Išrašyti S/F";
            btnisrasyti.UseVisualStyleBackColor = true;
            btnisrasyti.Click += btnisrasyti_Click;
            // 
            // israsyti_sf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 603);
            Controls.Add(btnisrasyti);
            Controls.Add(btnpr);
            Controls.Add(label1);
            Controls.Add(cmb_imone);
            Controls.Add(btn_griz);
            Name = "israsyti_sf";
            Text = "israsyti_sf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_griz;
        private ComboBox cmb_imone;
        private Label label1;
        private Button btnpr;
        private Button btnisrasyti;
    }
}