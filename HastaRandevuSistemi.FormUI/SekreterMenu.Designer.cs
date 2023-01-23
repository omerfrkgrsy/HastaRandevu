namespace HastaRandevuSistemi.FormUI
{
    partial class SekreterMenu
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
            this.sekreterBtn = new System.Windows.Forms.Button();
            this.doktorBtn = new System.Windows.Forms.Button();
            this.hastaBtn = new System.Windows.Forms.Button();
            this.randevuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.randevuDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.randevuIptalBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sekreterBtn
            // 
            this.sekreterBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sekreterBtn.Location = new System.Drawing.Point(612, 93);
            this.sekreterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sekreterBtn.Name = "sekreterBtn";
            this.sekreterBtn.Size = new System.Drawing.Size(113, 43);
            this.sekreterBtn.TabIndex = 0;
            this.sekreterBtn.Text = "Sekreter Ekle";
            this.sekreterBtn.UseVisualStyleBackColor = false;
            this.sekreterBtn.Click += new System.EventHandler(this.sekreterBtn_Click);
            // 
            // doktorBtn
            // 
            this.doktorBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.doktorBtn.Location = new System.Drawing.Point(374, 93);
            this.doktorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doktorBtn.Name = "doktorBtn";
            this.doktorBtn.Size = new System.Drawing.Size(113, 43);
            this.doktorBtn.TabIndex = 0;
            this.doktorBtn.Text = "Doktor Ekle";
            this.doktorBtn.UseVisualStyleBackColor = false;
            this.doktorBtn.Click += new System.EventHandler(this.doktorBtn_Click);
            // 
            // hastaBtn
            // 
            this.hastaBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hastaBtn.Location = new System.Drawing.Point(493, 93);
            this.hastaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hastaBtn.Name = "hastaBtn";
            this.hastaBtn.Size = new System.Drawing.Size(113, 43);
            this.hastaBtn.TabIndex = 0;
            this.hastaBtn.Text = "Hasta Ekle";
            this.hastaBtn.UseVisualStyleBackColor = false;
            this.hastaBtn.Click += new System.EventHandler(this.hastaBtn_Click);
            // 
            // randevuBtn
            // 
            this.randevuBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.randevuBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.randevuBtn.Location = new System.Drawing.Point(137, 93);
            this.randevuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuBtn.Name = "randevuBtn";
            this.randevuBtn.Size = new System.Drawing.Size(214, 43);
            this.randevuBtn.TabIndex = 0;
            this.randevuBtn.Text = "Randevu Oluştur";
            this.randevuBtn.UseVisualStyleBackColor = false;
            this.randevuBtn.Click += new System.EventHandler(this.randevuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Brown;
            this.exitBtn.Location = new System.Drawing.Point(731, 93);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 43);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Çıkış Yap";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yenileBtn.Location = new System.Drawing.Point(731, 169);
            this.yenileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(113, 43);
            this.yenileBtn.TabIndex = 2;
            this.yenileBtn.Text = "Yenile";
            this.yenileBtn.UseVisualStyleBackColor = false;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // randevuDataGrid
            // 
            this.randevuDataGrid.AllowUserToAddRows = false;
            this.randevuDataGrid.AllowUserToDeleteRows = false;
            this.randevuDataGrid.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.randevuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.randevuDataGrid.Location = new System.Drawing.Point(47, 246);
            this.randevuDataGrid.Name = "randevuDataGrid";
            this.randevuDataGrid.ReadOnly = true;
            this.randevuDataGrid.RowTemplate.Height = 25;
            this.randevuDataGrid.Size = new System.Drawing.Size(892, 215);
            this.randevuDataGrid.TabIndex = 4;
            this.randevuDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevuDataGrid_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(358, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 50);
            this.label6.TabIndex = 22;
            this.label6.Text = "DASHBOARD";
            // 
            // randevuIptalBtn
            // 
            this.randevuIptalBtn.BackColor = System.Drawing.Color.Brown;
            this.randevuIptalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randevuIptalBtn.Location = new System.Drawing.Point(137, 169);
            this.randevuIptalBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randevuIptalBtn.Name = "randevuIptalBtn";
            this.randevuIptalBtn.Size = new System.Drawing.Size(113, 43);
            this.randevuIptalBtn.TabIndex = 23;
            this.randevuIptalBtn.Text = "Randevu İptal";
            this.randevuIptalBtn.UseVisualStyleBackColor = false;
            this.randevuIptalBtn.Visible = false;
            this.randevuIptalBtn.Click += new System.EventHandler(this.randevuIptalBtn_Click);
            // 
            // iptalBtn
            // 
            this.iptalBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.iptalBtn.BackColor = System.Drawing.Color.Brown;
            this.iptalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iptalBtn.Location = new System.Drawing.Point(256, 169);
            this.iptalBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(113, 43);
            this.iptalBtn.TabIndex = 24;
            this.iptalBtn.Text = "Seçim İptal";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Visible = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 15);
            this.userLabel.TabIndex = 25;
            // 
            // SekreterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 783);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.randevuIptalBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.randevuDataGrid);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.hastaBtn);
            this.Controls.Add(this.doktorBtn);
            this.Controls.Add(this.randevuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sekreterBtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SekreterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Menüsü";
            this.Load += new System.EventHandler(this.SekreterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sekreterBtn;
        private Button doktorBtn;
        private Button hastaBtn;
        private Button randevuBtn;
        private Button exitBtn;
        private Button yenileBtn;
        private DataGridView randevuDataGrid;
        private Label label6;
        private Button randevuIptalBtn;
        private Button iptalBtn;
        private Label userLabel;
    }
}