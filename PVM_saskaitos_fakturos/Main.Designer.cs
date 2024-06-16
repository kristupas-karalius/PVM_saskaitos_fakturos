namespace PVM_saskaitos_fakturos
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 46);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "Prisijunkite!";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 46);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 0;
            label2.Text = "Prisijunkite!";
            label2.Click += label1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 118);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 1;
            label3.Text = "Vartotojo vardas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 180);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 1;
            label4.Text = "Slaptažodis:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(206, 177);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(238, 23);
            txt_password.TabIndex = 2;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(206, 118);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(238, 23);
            txt_username.TabIndex = 2;
            // 
            // login
            // 
            login.Location = new Point(369, 229);
            login.Name = "login";
            login.Size = new Size(75, 23);
            login.TabIndex = 3;
            login.Text = "Prisijungti";
            login.UseVisualStyleBackColor = true;
            login.Click += prisijungti_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 432);
            Controls.Add(login);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button login;
    }
}
