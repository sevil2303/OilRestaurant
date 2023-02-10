namespace WindowsFormsApp2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openmenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(-4, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 670);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(27, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 33);
            this.panel2.TabIndex = 1;
            // 
            // slidePic
            // 
            this.slidePic.BackColor = System.Drawing.Color.Transparent;
            this.slidePic.Image = global::WindowsFormsApp2.Properties.Resources.organic_family1;
            this.slidePic.Location = new System.Drawing.Point(229, 138);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(479, 269);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slidePic.TabIndex = 2;
            this.slidePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(367, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(286, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yummy Restaurant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openmenuBtn
            // 
            this.openmenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.openmenuBtn.FlatAppearance.BorderSize = 0;
            this.openmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openmenuBtn.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openmenuBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.openmenuBtn.Location = new System.Drawing.Point(711, 483);
            this.openmenuBtn.Name = "openmenuBtn";
            this.openmenuBtn.Size = new System.Drawing.Size(140, 50);
            this.openmenuBtn.TabIndex = 4;
            this.openmenuBtn.Text = "Open Menu";
            this.openmenuBtn.UseVisualStyleBackColor = false;
            this.openmenuBtn.Click += new System.EventHandler(this.openmenuBtn_Click);
            this.openmenuBtn.MouseEnter += new System.EventHandler(this.openmenuBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.openmenuBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slidePic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openmenuBtn;
    }
}

