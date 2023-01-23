namespace HastaRandevuSistemi.FormUI
{
    partial class SekreterForm
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
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.telefonNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.sekreterDataGrid = new System.Windows.Forms.DataGridView();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(183, 133);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(231, 23);
            this.adTextBox.TabIndex = 0;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(183, 178);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(231, 23);
            this.soyadTextBox.TabIndex = 0;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(183, 233);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(231, 23);
            this.kullaniciAdiTextBox.TabIndex = 0;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(523, 133);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(231, 23);
            this.sifreTextBox.TabIndex = 0;
            // 
            // telefonNoTextBox
            // 
            this.telefonNoTextBox.Location = new System.Drawing.Point(523, 178);
            this.telefonNoTextBox.Name = "telefonNoTextBox";
            this.telefonNoTextBox.Size = new System.Drawing.Size(231, 23);
            this.telefonNoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soy Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon No";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.kaydetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydetBtn.Location = new System.Drawing.Point(604, 226);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(150, 34);
            this.kaydetBtn.TabIndex = 2;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // sekreterDataGrid
            // 
            this.sekreterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sekreterDataGrid.Location = new System.Drawing.Point(81, 288);
            this.sekreterDataGrid.Name = "sekreterDataGrid";
            this.sekreterDataGrid.RowTemplate.Height = 25;
            this.sekreterDataGrid.Size = new System.Drawing.Size(673, 215);
            this.sekreterDataGrid.TabIndex = 3;
            this.sekreterDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sekreterDataGrid_CellClick);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(183, 92);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(124, 23);
            this.idTxt.TabIndex = 0;
            this.idTxt.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(81, 95);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Id";
            this.idLabel.Visible = false;
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.Firebrick;
            this.iptalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalBtn.Location = new System.Drawing.Point(638, 92);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(116, 34);
            this.iptalBtn.TabIndex = 2;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Visible = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Firebrick;
            this.silBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silBtn.Location = new System.Drawing.Point(437, 226);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(116, 34);
            this.silBtn.TabIndex = 2;
            this.silBtn.Text = "Kaydı Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Visible = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(267, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 50);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sekreter Menüsü";
            // 
            // SekreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.sekreterDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonNoTextBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Name = "SekreterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterForm";
            this.Load += new System.EventHandler(this.SekreterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sekreterDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox adTextBox;
        private TextBox soyadTextBox;
        private TextBox kullaniciAdiTextBox;
        private TextBox sifreTextBox;
        private TextBox telefonNoTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button kaydetBtn;
        private DataGridView sekreterDataGrid;
        private TextBox idTxt;
        private Label idLabel;
        private Button iptalBtn;
        private Button silBtn;
        private Label label6;
    }
}