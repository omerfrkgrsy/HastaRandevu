namespace HastaRandevuSistemi.FormUI
{
    partial class Login
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
            this.sekreterLoginBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sekreterLoginBtn
            // 
            this.sekreterLoginBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sekreterLoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sekreterLoginBtn.Location = new System.Drawing.Point(31, 42);
            this.sekreterLoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sekreterLoginBtn.Name = "sekreterLoginBtn";
            this.sekreterLoginBtn.Size = new System.Drawing.Size(119, 55);
            this.sekreterLoginBtn.TabIndex = 0;
            this.sekreterLoginBtn.Text = "Sekreter Giriş";
            this.sekreterLoginBtn.UseVisualStyleBackColor = false;
            this.sekreterLoginBtn.Click += new System.EventHandler(this.sekreterLoginBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(235, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "Doktor Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(138, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sekreterLoginBtn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Randevu Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private Button sekreterLoginBtn;
        private Button button2;
        private Button button1;
    }
}