namespace WindowsFormsApp2
{
    partial class OilStation
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
            this.label1 = new System.Windows.Forms.Label();
            this.oilcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceLblBox = new System.Windows.Forms.Label();
            this.quantityBtn = new System.Windows.Forms.RadioButton();
            this.quantumBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantityTxb = new System.Windows.Forms.MaskedTextBox();
            this.quantumTxb = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oilamountLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIL STATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oilcomboBox
            // 
            this.oilcomboBox.BackColor = System.Drawing.Color.Red;
            this.oilcomboBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oilcomboBox.FormattingEnabled = true;
            this.oilcomboBox.Location = new System.Drawing.Point(225, 427);
            this.oilcomboBox.Name = "oilcomboBox";
            this.oilcomboBox.Size = new System.Drawing.Size(121, 21);
            this.oilcomboBox.TabIndex = 1;
            this.oilcomboBox.SelectedIndexChanged += new System.EventHandler(this.oilcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oil types";
            // 
            // priceLbl
            // 
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceLbl.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLbl.Location = new System.Drawing.Point(116, 473);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(72, 32);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "Price";
            // 
            // priceLblBox
            // 
            this.priceLblBox.BackColor = System.Drawing.Color.White;
            this.priceLblBox.Location = new System.Drawing.Point(222, 473);
            this.priceLblBox.Name = "priceLblBox";
            this.priceLblBox.Size = new System.Drawing.Size(124, 20);
            this.priceLblBox.TabIndex = 3;
            // 
            // quantityBtn
            // 
            this.quantityBtn.AutoSize = true;
            this.quantityBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityBtn.Location = new System.Drawing.Point(6, 19);
            this.quantityBtn.Name = "quantityBtn";
            this.quantityBtn.Size = new System.Drawing.Size(64, 17);
            this.quantityBtn.TabIndex = 4;
            this.quantityBtn.TabStop = true;
            this.quantityBtn.Text = "Quantity";
            this.quantityBtn.UseVisualStyleBackColor = true;
            this.quantityBtn.TextChanged += new System.EventHandler(this.quantityBtn_TextChanged);
            // 
            // quantumBtn
            // 
            this.quantumBtn.AutoSize = true;
            this.quantumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantumBtn.Location = new System.Drawing.Point(6, 57);
            this.quantumBtn.Name = "quantumBtn";
            this.quantumBtn.Size = new System.Drawing.Size(68, 17);
            this.quantumBtn.TabIndex = 4;
            this.quantumBtn.TabStop = true;
            this.quantumBtn.Text = "Quantum";
            this.quantumBtn.UseVisualStyleBackColor = true;
            this.quantumBtn.TextChanged += new System.EventHandler(this.quantumBtn_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.quantityBtn);
            this.groupBox1.Controls.Add(this.quantumBtn);
            this.groupBox1.Location = new System.Drawing.Point(528, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // quantityTxb
            // 
            this.quantityTxb.Location = new System.Drawing.Point(680, 438);
            this.quantityTxb.Mask = "00000";
            this.quantityTxb.Name = "quantityTxb";
            this.quantityTxb.Size = new System.Drawing.Size(100, 20);
            this.quantityTxb.TabIndex = 6;
            this.quantityTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTxb.ValidatingType = typeof(int);
            this.quantityTxb.TextChanged += new System.EventHandler(this.quantityTxb_TextChanged);
            // 
            // quantumTxb
            // 
            this.quantumTxb.Location = new System.Drawing.Point(680, 476);
            this.quantumTxb.Mask = "00000";
            this.quantumTxb.Name = "quantumTxb";
            this.quantumTxb.Size = new System.Drawing.Size(100, 20);
            this.quantumTxb.TabIndex = 6;
            this.quantumTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantumTxb.ValidatingType = typeof(int);
            this.quantumTxb.TextChanged += new System.EventHandler(this.quantumTxb_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(426, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(698, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "manat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oilamountLbl
            // 
            this.oilamountLbl.BackColor = System.Drawing.Color.Transparent;
            this.oilamountLbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilamountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oilamountLbl.Location = new System.Drawing.Point(567, 542);
            this.oilamountLbl.Name = "oilamountLbl";
            this.oilamountLbl.Size = new System.Drawing.Size(150, 39);
            this.oilamountLbl.TabIndex = 7;
            this.oilamountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(771, 592);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(126, 31);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // OilStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.oil;
            this.ClientSize = new System.Drawing.Size(945, 635);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oilamountLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantumTxb);
            this.Controls.Add(this.quantityTxb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.priceLblBox);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oilcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "OilStation";
            this.Text = "OilStation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox oilcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label priceLblBox;
        private System.Windows.Forms.RadioButton quantityBtn;
        private System.Windows.Forms.RadioButton quantumBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox quantityTxb;
        private System.Windows.Forms.MaskedTextBox quantumTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label oilamountLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}