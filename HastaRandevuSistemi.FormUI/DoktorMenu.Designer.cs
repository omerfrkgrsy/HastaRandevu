namespace HastaRandevuSistemi.FormUI
{
    partial class DoktorMenu
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
            this.userLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.randevuDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 25);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 15);
            this.userLabel.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(409, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 50);
            this.label6.TabIndex = 27;
            this.label6.Text = "Doktor Menü";
            // 
            // randevuDataGrid
            // 
            this.randevuDataGrid.AllowUserToAddRows = false;
            this.randevuDataGrid.AllowUserToDeleteRows = false;
            this.randevuDataGrid.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.randevuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.randevuDataGrid.Location = new System.Drawing.Point(61, 124);
            this.randevuDataGrid.Name = "randevuDataGrid";
            this.randevuDataGrid.ReadOnly = true;
            this.randevuDataGrid.RowTemplate.Height = 25;
            this.randevuDataGrid.Size = new System.Drawing.Size(922, 215);
            this.randevuDataGrid.TabIndex = 28;
            this.randevuDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevuDataGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Randevularım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Randevu detayı için randevuya çift tıklayınız";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Brown;
            this.exitBtn.Location = new System.Drawing.Point(910, 16);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 43);
            this.exitBtn.TabIndex = 31;
            this.exitBtn.Text = "Çıkış Yap";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // DoktorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 447);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randevuDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userLabel);
            this.Name = "DoktorMenu";
            this.Text = "DoktorMenu";
            this.Load += new System.EventHandler(this.DoktorMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevuDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userLabel;
        private Label label6;
        private DataGridView randevuDataGrid;
        private Label label1;
        private Label label2;
        private Button exitBtn;
    }
}