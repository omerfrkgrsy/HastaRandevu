namespace HastaRandevuSistemi.FormUI
{
    partial class RandevuDetay
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
            this.hastaTxt = new System.Windows.Forms.TextBox();
            this.tarihTxt = new System.Windows.Forms.TextBox();
            this.doktorTxt = new System.Windows.Forms.TextBox();
            this.durumTxt = new System.Windows.Forms.TextBox();
            this.notRichTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saatTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.randevuBitirBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hastaTxt
            // 
            this.hastaTxt.Enabled = false;
            this.hastaTxt.Location = new System.Drawing.Point(195, 112);
            this.hastaTxt.Name = "hastaTxt";
            this.hastaTxt.Size = new System.Drawing.Size(189, 23);
            this.hastaTxt.TabIndex = 0;
            // 
            // tarihTxt
            // 
            this.tarihTxt.Enabled = false;
            this.tarihTxt.Location = new System.Drawing.Point(195, 199);
            this.tarihTxt.Name = "tarihTxt";
            this.tarihTxt.Size = new System.Drawing.Size(189, 23);
            this.tarihTxt.TabIndex = 0;
            // 
            // doktorTxt
            // 
            this.doktorTxt.Enabled = false;
            this.doktorTxt.Location = new System.Drawing.Point(195, 154);
            this.doktorTxt.Name = "doktorTxt";
            this.doktorTxt.Size = new System.Drawing.Size(189, 23);
            this.doktorTxt.TabIndex = 0;
            // 
            // durumTxt
            // 
            this.durumTxt.Enabled = false;
            this.durumTxt.Location = new System.Drawing.Point(664, 107);
            this.durumTxt.Name = "durumTxt";
            this.durumTxt.Size = new System.Drawing.Size(100, 23);
            this.durumTxt.TabIndex = 0;
            // 
            // notRichTxt
            // 
            this.notRichTxt.Location = new System.Drawing.Point(94, 315);
            this.notRichTxt.Name = "notRichTxt";
            this.notRichTxt.Size = new System.Drawing.Size(670, 217);
            this.notRichTxt.TabIndex = 1;
            this.notRichTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Randevu Saat";
            // 
            // saatTxt
            // 
            this.saatTxt.Enabled = false;
            this.saatTxt.Location = new System.Drawing.Point(195, 241);
            this.saatTxt.Name = "saatTxt";
            this.saatTxt.Size = new System.Drawing.Size(189, 23);
            this.saatTxt.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Randevu Notu:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // randevuBitirBtn
            // 
            this.randevuBitirBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.randevuBitirBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.randevuBitirBtn.Location = new System.Drawing.Point(627, 538);
            this.randevuBitirBtn.Name = "randevuBitirBtn";
            this.randevuBitirBtn.Size = new System.Drawing.Size(137, 40);
            this.randevuBitirBtn.TabIndex = 4;
            this.randevuBitirBtn.Text = "Randevu Bitir";
            this.randevuBitirBtn.UseVisualStyleBackColor = false;
            this.randevuBitirBtn.Click += new System.EventHandler(this.randevuBitirBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(304, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 50);
            this.label7.TabIndex = 21;
            this.label7.Text = "Randevu Detay";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(741, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Mail Gönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandevuDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.randevuBitirBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notRichTxt);
            this.Controls.Add(this.durumTxt);
            this.Controls.Add(this.doktorTxt);
            this.Controls.Add(this.saatTxt);
            this.Controls.Add(this.tarihTxt);
            this.Controls.Add(this.hastaTxt);
            this.Name = "RandevuDetay";
            this.Text = "Randevu Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandevuDetay_FormClosing);
            this.Load += new System.EventHandler(this.RandevuDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox hastaTxt;
        private TextBox tarihTxt;
        private TextBox doktorTxt;
        private TextBox durumTxt;
        private RichTextBox notRichTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox saatTxt;
        private Label label5;
        private Label label6;
        private Button randevuBitirBtn;
        private Label label7;
        private Button button1;
    }
}