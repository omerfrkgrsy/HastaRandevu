namespace HastaRandevuSistemi.FormUI
{
    partial class HastaForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.hastaDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonNoTextBox = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.tcknTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.silBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hastaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(100, 96);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "Id";
            this.idLabel.Visible = false;
            // 
            // hastaDataGrid
            // 
            this.hastaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaDataGrid.Location = new System.Drawing.Point(100, 289);
            this.hastaDataGrid.Name = "hastaDataGrid";
            this.hastaDataGrid.RowTemplate.Height = 25;
            this.hastaDataGrid.Size = new System.Drawing.Size(673, 215);
            this.hastaDataGrid.TabIndex = 19;
            this.hastaDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastaDataGrid_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soy Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adı";
            // 
            // telefonNoTextBox
            // 
            this.telefonNoTextBox.Location = new System.Drawing.Point(542, 184);
            this.telefonNoTextBox.Name = "telefonNoTextBox";
            this.telefonNoTextBox.Size = new System.Drawing.Size(231, 23);
            this.telefonNoTextBox.TabIndex = 5;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(202, 93);
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(124, 23);
            this.idTxt.TabIndex = 6;
            this.idTxt.Visible = false;
            // 
            // tcknTextBox
            // 
            this.tcknTextBox.Location = new System.Drawing.Point(542, 134);
            this.tcknTextBox.Name = "tcknTextBox";
            this.tcknTextBox.Size = new System.Drawing.Size(231, 23);
            this.tcknTextBox.TabIndex = 8;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(202, 179);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(231, 23);
            this.soyadTextBox.TabIndex = 9;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(202, 134);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(231, 23);
            this.adTextBox.TabIndex = 10;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Firebrick;
            this.silBtn.Enabled = false;
            this.silBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silBtn.Location = new System.Drawing.Point(479, 227);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(116, 34);
            this.silBtn.TabIndex = 16;
            this.silBtn.Text = "Kaydı Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.Color.Firebrick;
            this.iptalBtn.Enabled = false;
            this.iptalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalBtn.Location = new System.Drawing.Point(657, 93);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(116, 34);
            this.iptalBtn.TabIndex = 17;
            this.iptalBtn.Text = "İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.kaydetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydetBtn.Location = new System.Drawing.Point(623, 227);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(150, 34);
            this.kaydetBtn.TabIndex = 18;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(290, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 50);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hasta Menüsü";
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 526);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.hastaDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonNoTextBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.tcknTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Name = "HastaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Menü";
            this.Load += new System.EventHandler(this.HastaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private DataGridView hastaDataGrid;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox telefonNoTextBox;
        private TextBox idTxt;
        private TextBox tcknTextBox;
        private TextBox soyadTextBox;
        private TextBox adTextBox;
        private Button silBtn;
        private Button iptalBtn;
        private Button kaydetBtn;
        private Label label6;
    }
}