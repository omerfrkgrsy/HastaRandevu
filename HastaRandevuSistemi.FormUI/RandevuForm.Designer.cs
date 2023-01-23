namespace HastaRandevuSistemi.FormUI
{
    partial class RandevuForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.randevuTarihDatePicker = new System.Windows.Forms.DateTimePicker();
            this.randevuSaatCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hastaCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bolumCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doktorCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 50);
            this.label6.TabIndex = 34;
            this.label6.Text = "Randevu Menüsü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Randevu Tarihi";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.kaydetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydetBtn.Location = new System.Drawing.Point(264, 274);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(150, 34);
            this.kaydetBtn.TabIndex = 32;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // randevuTarihDatePicker
            // 
            this.randevuTarihDatePicker.Location = new System.Drawing.Point(133, 196);
            this.randevuTarihDatePicker.Name = "randevuTarihDatePicker";
            this.randevuTarihDatePicker.Size = new System.Drawing.Size(231, 23);
            this.randevuTarihDatePicker.TabIndex = 35;
            this.randevuTarihDatePicker.ValueChanged += new System.EventHandler(this.randevuTarihDatePicker_ValueChanged);
            // 
            // randevuSaatCombo
            // 
            this.randevuSaatCombo.FormattingEnabled = true;
            this.randevuSaatCombo.Location = new System.Drawing.Point(133, 232);
            this.randevuSaatCombo.Name = "randevuSaatCombo";
            this.randevuSaatCombo.Size = new System.Drawing.Size(231, 23);
            this.randevuSaatCombo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Bölüm";
            // 
            // hastaCombo
            // 
            this.hastaCombo.FormattingEnabled = true;
            this.hastaCombo.Location = new System.Drawing.Point(133, 83);
            this.hastaCombo.Name = "hastaCombo";
            this.hastaCombo.Size = new System.Drawing.Size(231, 23);
            this.hastaCombo.TabIndex = 43;
            this.hastaCombo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.hastaCombo_Format);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hasta";
            // 
            // bolumCombo
            // 
            this.bolumCombo.FormattingEnabled = true;
            this.bolumCombo.Location = new System.Drawing.Point(133, 117);
            this.bolumCombo.Name = "bolumCombo";
            this.bolumCombo.Size = new System.Drawing.Size(231, 23);
            this.bolumCombo.TabIndex = 44;
            this.bolumCombo.SelectedIndexChanged += new System.EventHandler(this.bolumCombo_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Randevu Saati";
            // 
            // doktorCombo
            // 
            this.doktorCombo.FormattingEnabled = true;
            this.doktorCombo.Location = new System.Drawing.Point(133, 156);
            this.doktorCombo.Name = "doktorCombo";
            this.doktorCombo.Size = new System.Drawing.Size(231, 23);
            this.doktorCombo.TabIndex = 45;
            this.doktorCombo.SelectedIndexChanged += new System.EventHandler(this.doktorCombo_SelectedIndexChanged);
            this.doktorCombo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.doktorCombo_Format);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Doktor";
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktorCombo);
            this.Controls.Add(this.bolumCombo);
            this.Controls.Add(this.hastaCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randevuSaatCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.randevuTarihDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaydetBtn);
            this.Name = "RandevuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label1;
        private Button kaydetBtn;
        private DateTimePicker randevuTarihDatePicker;
        private ComboBox randevuSaatCombo;
        private Label label7;
        private ComboBox hastaCombo;
        private Label label2;
        private ComboBox bolumCombo;
        private Label label4;
        private ComboBox doktorCombo;
        private Label label3;
    }
}