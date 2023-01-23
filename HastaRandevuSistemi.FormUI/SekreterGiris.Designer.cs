namespace HastaRandevuSistemi.FormUI
{
    partial class SekreterGirisForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geriBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(248, 139);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 35);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Giriş";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(141, 57);
            this.kullaniciAdiTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(288, 23);
            this.kullaniciAdiTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(141, 104);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(288, 23);
            this.sifreTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // geriBtn
            // 
            this.geriBtn.BackColor = System.Drawing.Color.Firebrick;
            this.geriBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geriBtn.Location = new System.Drawing.Point(10, 9);
            this.geriBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(88, 35);
            this.geriBtn.TabIndex = 0;
            this.geriBtn.Text = "Geri Dön";
            this.geriBtn.UseVisualStyleBackColor = false;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Önceden Tanımlı Kullanıcı Adı: sekreter, Şifre: 12345";
            // 
            // SekreterGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 195);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.loginBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SekreterGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Girişi";
            this.Load += new System.EventHandler(this.SekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private TextBox kullaniciAdiTxt;
        private TextBox sifreTxt;
        private Label label1;
        private Label label2;
        private Button geriBtn;
        private Label label3;
    }
}