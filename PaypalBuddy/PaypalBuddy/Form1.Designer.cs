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
            this.btnShowAllCurrData = new System.Windows.Forms.Button();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurr2Date = new System.Windows.Forms.Label();
            this.lblCurr3Date = new System.Windows.Forms.Label();
            this.lblCurr4Date = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo1 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo2 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo3 = new System.Windows.Forms.Label();
            this.lblCurrencyRateNo4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUpdateFrequency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayPalConvTaxes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLayout1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayout1
            // 
            this.tabLayout1.Controls.Add(this.tabPage1);
            this.tabLayout1.Controls.Add(this.tabPage2);
            this.tabLayout1.Controls.Add(this.tabPage3);
            this.tabLayout1.Location = new System.Drawing.Point(1, 1);
            this.tabLayout1.Name = "tabLayout1";
            this.tabLayout1.SelectedIndex = 0;
            this.tabLayout1.Size = new System.Drawing.Size(186, 208);
            this.tabLayout1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(178, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Indication";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAllCurrData);
            this.groupBox1.Controls.Add(this.lblLastUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCurr2Date);
            this.groupBox1.Controls.Add(this.lblCurr3Date);
            this.groupBox1.Controls.Add(this.lblCurr4Date);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo1);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo2);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo3);
            this.groupBox1.Controls.Add(this.lblCurrencyRateNo4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USD->EUR";
            // 
            // btnShowAllCurrData
            // 
            this.btnShowAllCurrData.Location = new System.Drawing.Point(130, -2);
            this.btnShowAllCurrData.Name = "btnShowAllCurrData";
            this.btnShowAllCurrData.Size = new System.Drawing.Size(41, 23);
            this.btnShowAllCurrData.TabIndex = 10;
            this.btnShowAllCurrData.Text = "More";
            this.btnShowAllCurrData.UseVisualStyleBackColor = true;
            this.btnShowAllCurrData.Click += new System.EventHandler(this.btnShowAllCurrData_Click);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(9, 163);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(125, 13);
            this.lblLastUpdate.TabIndex = 9;
            this.lblLastUpdate.Text = "1999-99-99 99:99:99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last update:";
            // 
            // lblCurr2Date
            // 
            this.lblCurr2Date.AutoSize = true;
            this.lblCurr2Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurr2Date.Location = new System.Drawing.Point(88, 83);
            this.lblCurr2Date.Name = "lblCurr2Date";
            this.lblCurr2Date.Size = new System.Drawing.Size(20, 13);
            this.lblCurr2Date.TabIndex = 7;
            this.lblCurr2Date.Text = "lbl";
            // 
            // lblCurr3Date
            // 
            this.lblCurr3Date.AutoSize = true;
            this.lblCurr3Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurr3Date.Location = new System.Drawing.Point(88, 52);
            this.lblCurr3Date.Name = "lblCurr3Date";
            this.lblCurr3Date.Size = new System.Drawing.Size(20, 13);
            this.lblCurr3Date.TabIndex = 6;
            this.lblCurr3Date.Text = "lbl";
            // 
            // lblCurr4Date
            // 
            this.lblCurr4Date.AutoSize = true;
            this.lblCurr4Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurr4Date.Location = new System.Drawing.Point(88, 22);
            this.lblCurr4Date.Name = "lblCurr4Date";
            this.lblCurr4Date.Size = new System.Drawing.Size(20, 13);
            this.lblCurr4Date.TabIndex = 5;
            this.lblCurr4Date.Text = "lbl";
            // 
            // lblCurrencyRateNo1
            // 
            this.lblCurrencyRateNo1.AutoSize = true;
            this.lblCurrencyRateNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo1.Location = new System.Drawing.Point(2, 102);
            this.lblCurrencyRateNo1.Name = "lblCurrencyRateNo1";
            this.lblCurrencyRateNo1.Size = new System.Drawing.Size(178, 55);
            this.lblCurrencyRateNo1.TabIndex = 3;
            this.lblCurrencyRateNo1.Text = "0,0000";
            // 
            // lblCurrencyRateNo2
            // 
            this.lblCurrencyRateNo2.AutoSize = true;
            this.lblCurrencyRateNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo2.Location = new System.Drawing.Point(6, 79);
            this.lblCurrencyRateNo2.Name = "lblCurrencyRateNo2";
            this.lblCurrencyRateNo2.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo2.TabIndex = 2;
            this.lblCurrencyRateNo2.Text = "0,0000";
            // 
            // lblCurrencyRateNo3
            // 
            this.lblCurrencyRateNo3.AutoSize = true;
            this.lblCurrencyRateNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo3.Location = new System.Drawing.Point(6, 48);
            this.lblCurrencyRateNo3.Name = "lblCurrencyRateNo3";
            this.lblCurrencyRateNo3.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo3.TabIndex = 1;
            this.lblCurrencyRateNo3.Text = "0,0000";
            // 
            // lblCurrencyRateNo4
            // 
            this.lblCurrencyRateNo4.AutoSize = true;
            this.lblCurrencyRateNo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyRateNo4.Location = new System.Drawing.Point(6, 18);
            this.lblCurrencyRateNo4.Name = "lblCurrencyRateNo4";
            this.lblCurrencyRateNo4.Size = new System.Drawing.Size(84, 26);
            this.lblCurrencyRateNo4.TabIndex = 0;
            this.lblCurrencyRateNo4.Text = "0,0000";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(178, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency calculation";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(178, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUpdateFrequency);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPayPalConvTaxes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // txtUpdateFrequency
            // 
            this.txtUpdateFrequency.Location = new System.Drawing.Point(105, 36);
            this.txtUpdateFrequency.Name = "txtUpdateFrequency";
            this.txtUpdateFrequency.Size = new System.Drawing.Size(61, 20);
            this.txtUpdateFrequency.TabIndex = 4;
            this.txtUpdateFrequency.TextChanged += new System.EventHandler(this.txtUpdateFrequency_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update freq., s";
            // 
            // txtPayPalConvTaxes
            // 
            this.txtPayPalConvTaxes.Location = new System.Drawing.Point(105, 12);
            this.txtPayPalConvTaxes.Name = "txtPayPalConvTaxes";
            this.txtPayPalConvTaxes.Size = new System.Drawing.Size(61, 20);
            this.txtPayPalConvTaxes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PayPal Taxes, %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 210);
            this.Controls.Add(this.tabLayout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label lblCurr2Date;
        private System.Windows.Forms.Label lblCurr3Date;
        private System.Windows.Forms.Label lblCurr4Date;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUpdateFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayPalConvTaxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowAllCurrData;
    }
}

