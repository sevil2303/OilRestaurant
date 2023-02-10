namespace WindowsFormsApp2
{
    partial class Exit
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
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalamountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLbl.Location = new System.Drawing.Point(123, 265);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(261, 39);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total Amount : ";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalamountLbl
            // 
            this.totalamountLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalamountLbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalamountLbl.Location = new System.Drawing.Point(377, 265);
            this.totalamountLbl.Name = "totalamountLbl";
            this.totalamountLbl.Size = new System.Drawing.Size(261, 39);
            this.totalamountLbl.TabIndex = 8;
            this.totalamountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(644, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "manat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(233, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 135);
            this.label2.TabIndex = 8;
            this.label2.Text = "GOOD BYE!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.invoiceBtn.Location = new System.Drawing.Point(775, 411);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(109, 38);
            this.invoiceBtn.TabIndex = 9;
            this.invoiceBtn.Text = "Show Invoice";
            this.invoiceBtn.UseVisualStyleBackColor = true;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.wood_textures_1920x1080_abstract_textures_hd_art_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.invoiceBtn);
            this.Controls.Add(this.totalamountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLbl);
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label totalamountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button invoiceBtn;
    }
}