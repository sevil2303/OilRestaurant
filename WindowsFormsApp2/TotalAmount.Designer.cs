namespace WindowsFormsApp2
{
    partial class TotalAmount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totaltextLbl = new System.Windows.Forms.Label();
            this.totalamountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totaltextLbl
            // 
            this.totaltextLbl.AutoSize = true;
            this.totaltextLbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totaltextLbl.Location = new System.Drawing.Point(19, 10);
            this.totaltextLbl.Name = "totaltextLbl";
            this.totaltextLbl.Size = new System.Drawing.Size(115, 17);
            this.totaltextLbl.TabIndex = 0;
            this.totaltextLbl.Text = "TOTAL AMOUNT";
            // 
            // totalamountLbl
            // 
            this.totalamountLbl.AutoSize = true;
            this.totalamountLbl.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalamountLbl.Location = new System.Drawing.Point(590, 10);
            this.totalamountLbl.Name = "totalamountLbl";
            this.totalamountLbl.Size = new System.Drawing.Size(16, 17);
            this.totalamountLbl.TabIndex = 0;
            this.totalamountLbl.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(297, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thanks for visit...";
            // 
            // TotalAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalamountLbl);
            this.Controls.Add(this.totaltextLbl);
            this.Name = "TotalAmount";
            this.Size = new System.Drawing.Size(674, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totaltextLbl;
        private System.Windows.Forms.Label totalamountLbl;
        private System.Windows.Forms.Label label2;
    }
}
