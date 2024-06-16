namespace PVM_saskaitos_fakturos
{
    partial class Menuform
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
            imones = new Button();
            btn_isras = new Button();
            button1 = new Button();
            btnsuvestine = new Button();
            SuspendLayout();
            // 
            // imones
            // 
            imones.Location = new Point(32, 34);
            imones.Name = "imones";
            imones.Size = new Size(73, 57);
            imones.TabIndex = 0;
            imones.Text = "Įmonių duomenys";
            imones.UseVisualStyleBackColor = true;
            imones.Click += imones_Click;
            // 
            // btn_isras
            // 
            btn_isras.Location = new Point(156, 34);
            btn_isras.Name = "btn_isras";
            btn_isras.Size = new Size(73, 57);
            btn_isras.TabIndex = 1;
            btn_isras.Text = "Pridėti sąskaitas faktūras";
            btn_isras.UseVisualStyleBackColor = true;
            btn_isras.Click += btn_isras_Click;
            // 
            // button1
            // 
            button1.Location = new Point(262, 34);
            button1.Name = "button1";
            button1.Size = new Size(65, 57);
            button1.TabIndex = 2;
            button1.Text = "Išrašyti sąskaitas faktūras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnsuvestine
            // 
            btnsuvestine.Location = new Point(369, 34);
            btnsuvestine.Name = "btnsuvestine";
            btnsuvestine.Size = new Size(66, 57);
            btnsuvestine.TabIndex = 3;
            btnsuvestine.Text = "Sąskaitų faktūrų suvestinė";
            btnsuvestine.UseVisualStyleBackColor = true;
            btnsuvestine.Click += btnsuvestine_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsuvestine);
            Controls.Add(button1);
            Controls.Add(btn_isras);
            Controls.Add(imones);
            Name = "Menuform";
            Text = "Menuform";
            ResumeLayout(false);
        }

        #endregion

        private Button imones;
        private Button btn_isras;
        private Button button1;
        private Button btnsuvestine;
    }
}