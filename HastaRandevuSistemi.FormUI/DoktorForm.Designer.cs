namespace HastaRandevuSistemi.FormUI
{
    partial class DoktorForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.doktorDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonNoTextBox = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doktorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(270, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 50);
            this.label6.TabIndex = 34;
            this.label6.Text = "Doktor Menüsü";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(96, 67);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 35;
            this.idLabel.Text = "Id";
            this.idLabel.Visible = false;
            // 
            // doktorDataGrid
            // 
            this.doktorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktorDataGrid.Location = new System.Drawing.Point(48, 296);
            this.doktorDataGrid.Name = "doktorDataGrid";
            this.doktorDataGrid.RowHeadersWidth = 51;
            this.doktorDataGrid.RowTemplate.Height = 25;
            this.doktorDataGrid.Size = new System.Drawing.Size(778, 265);
            this.doktorDataGrid.TabIndex = 33;
            this.doktorDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doktorDataGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Soy Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Adı";
            // 
            // telefonNoTextBox
            // 
            this.telefonNoTextBox.Location = new System.Drawing.Point(556, 153);
            this.telefonNoTextBox.Name = "telefonNoTextBox";
            this.telefonNoTextBox.Size = new System.Drawing.Size(231, 23);
            this.telefonNoTextBox.TabIndex = 21;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(198, 64);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(124, 23);
            this.idTxt.TabIndex = 22;
            this.idTxt.Visible = false;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(198, 150);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(231, 23);
            this.soyadTextBox.TabIndex = 24;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(198, 105);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(231, 23);
            this.adTextBox.TabIndex = 25;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Firebrick;
            this.silBtn.Enabled = false;
            this.silBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silBtn.Location = new System.Drawing.Point(492, 243);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(116, 34);
            this.silBtn.TabIndex = 30;
            this.silBtn.Text = "Kaydı Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.Firebrick;
            this.iptalBtn.Enabled = false;
            this.iptalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalBtn.Location = new System.Drawing.Point(671, 62);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(116, 34);
            this.iptalBtn.TabIndex = 31;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.kaydetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydetBtn.Location = new System.Drawing.Point(637, 243);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(150, 34);
            this.kaydetBtn.TabIndex = 32;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(198, 198);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(231, 23);
            this.kullaniciAdiTextBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Branş";
            // 
            // bransComboBox
            // 
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(556, 201);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(231, 23);
            this.bransComboBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Şifre";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(556, 106);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(231, 23);
            this.sifreTextBox.TabIndex = 40;
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 571);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.doktorDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonNoTextBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Name = "DoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Menü";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doktorDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label idLabel;
        private DataGridView doktorDataGrid;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox telefonNoTextBox;
        private TextBox idTxt;
        private TextBox soyadTextBox;
        private TextBox adTextBox;
        private Button silBtn;
        private Button iptalBtn;
        private Button kaydetBtn;
        private Label label4;
        private TextBox kullaniciAdiTextBox;
        private Label label7;
        private ComboBox bransComboBox;
        private Label label8;
        private TextBox sifreTextBox;
    }
}