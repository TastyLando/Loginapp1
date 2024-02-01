namespace LoginForm
{
    partial class Form1
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
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(289, 37);
            label1.Name = "label1";
            label1.Size = new Size(162, 35);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 159);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 227);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(246, 159);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(205, 27);
            txtKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(246, 224);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(205, 27);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(357, 288);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(232, 288);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 439);
            Controls.Add(btnSil);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnSil;
    }
}
