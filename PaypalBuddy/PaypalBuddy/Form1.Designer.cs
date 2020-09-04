namespace PaypalBuddy
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
            this.tabLayout1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrencyRateNo1 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo2 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo3 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabLayout1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayout1
            // 
            this.tabLayout1.Controls.Add(this.tabPage1);
            this.tabLayout1.Controls.Add(this.tabPage2);
            this.tabLayout1.Location = new System.Drawing.Point(1, 1);
            this.tabLayout1.Name = "tabLayout1";
            this.tabLayout1.SelectedIndex = 0;
            this.tabLayout1.Size = new System.Drawing.Size(228, 208);
            this.tabLayout1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(220, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Indication";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo1);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo2);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo3);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USD->EUR";
            // 
            // lblCurrencyRateNo1
            // 
            this.lblCurrencyRateNo1.AutoSize = true;
            this.lblCurrencyRateNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo1.Location = new System.Drawing.Point(2, 124);
            this.lblCurrencyRateNo1.Name = "lblCurrencyRateNo1";
            this.lblCurrencyRateNo1.Size = new System.Drawing.Size(158, 51);
            this.lblCurrencyRateNo1.TabIndex = 3;
            this.lblCurrencyRateNo1.Text = "lblCR1";
            // 
            // lblCurrencyRateNo2
            // 
            this.lblCurrencyRateNo2.AutoSize = true;
            this.lblCurrencyRateNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo2.Location = new System.Drawing.Point(6, 101);
            this.lblCurrencyRateNo2.Name = "lblCurrencyRateNo2";
            this.lblCurrencyRateNo2.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo2.TabIndex = 2;
            this.lblCurrencyRateNo2.Text = "lblCR2";
            // 
            // lblCurrencyRateNo3
            // 
            this.lblCurrencyRateNo3.AutoSize = true;
            this.lblCurrencyRateNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo3.Location = new System.Drawing.Point(6, 75);
            this.lblCurrencyRateNo3.Name = "lblCurrencyRateNo3";
            this.lblCurrencyRateNo3.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo3.TabIndex = 1;
            this.lblCurrencyRateNo3.Text = "lblCR3";
            // 
            // lblCurrencyRateNo4
            // 
            this.lblCurrencyRateNo4.AutoSize = true;
            this.lblCurrencyRateNo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo4.Location = new System.Drawing.Point(6, 49);
            this.lblCurrencyRateNo4.Name = "lblCurrencyRateNo4";
            this.lblCurrencyRateNo4.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo4.TabIndex = 0;
            this.lblCurrencyRateNo4.Text = "lblCR4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(220, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency calculation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 210);
            this.Controls.Add(this.tabLayout1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Paypal Buddy";
            this.tabLayout1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLayout1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrencyRateNo4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCurrencyRateNo1;
        private System.Windows.Forms.Label lblCurrencyRateNo2;
        private System.Windows.Forms.Label lblCurrencyRateNo3;
        private System.Windows.Forms.Button button1;
    }
}

