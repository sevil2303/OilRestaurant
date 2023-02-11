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
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(117, 292);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(261, 39);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total Amount : ";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalamountLbl
            // 
            this.totalamountLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalamountLbl.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalamountLbl.Location = new System.Drawing.Point(349, 270);
            this.totalamountLbl.Name = "totalamountLbl";
            this.totalamountLbl.Size = new System.Drawing.Size(289, 69);
            this.totalamountLbl.TabIndex = 8;
            this.totalamountLbl.Text = "34";
            this.totalamountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(644, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "manat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Goodbye_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(331, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.invoiceBtn);
            this.Controls.Add(this.totalamountLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalLbl);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label totalamountLbl;
        private System.Windows.Forms.Button invoiceBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}