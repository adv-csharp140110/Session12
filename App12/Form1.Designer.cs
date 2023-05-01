namespace App12
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTransactionFail = new System.Windows.Forms.Button();
            this.buttonTransactionEF = new System.Windows.Forms.Button();
            this.buttonTransactionScopr = new System.Windows.Forms.Button();
            this.buttonTransactionGR = new System.Windows.Forms.Button();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(375, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(269, 12);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(456, 10);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(64, 23);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.buttonTransactionGR);
            this.panel1.Controls.Add(this.buttonTransactionScopr);
            this.panel1.Controls.Add(this.buttonTransactionEF);
            this.panel1.Controls.Add(this.buttonTransactionFail);
            this.panel1.Location = new System.Drawing.Point(617, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 347);
            this.panel1.TabIndex = 6;
            // 
            // buttonTransactionFail
            // 
            this.buttonTransactionFail.Location = new System.Drawing.Point(19, 14);
            this.buttonTransactionFail.Name = "buttonTransactionFail";
            this.buttonTransactionFail.Size = new System.Drawing.Size(167, 23);
            this.buttonTransactionFail.TabIndex = 0;
            this.buttonTransactionFail.Text = "Transaction FAIL";
            this.buttonTransactionFail.UseVisualStyleBackColor = true;
            this.buttonTransactionFail.Click += new System.EventHandler(this.buttonTransactionFail_Click);
            // 
            // buttonTransactionEF
            // 
            this.buttonTransactionEF.Location = new System.Drawing.Point(19, 43);
            this.buttonTransactionEF.Name = "buttonTransactionEF";
            this.buttonTransactionEF.Size = new System.Drawing.Size(167, 23);
            this.buttonTransactionEF.TabIndex = 1;
            this.buttonTransactionEF.Text = "Transaction EF";
            this.buttonTransactionEF.UseVisualStyleBackColor = true;
            this.buttonTransactionEF.Click += new System.EventHandler(this.buttonTransactionEF_Click);
            // 
            // buttonTransactionScopr
            // 
            this.buttonTransactionScopr.Location = new System.Drawing.Point(19, 72);
            this.buttonTransactionScopr.Name = "buttonTransactionScopr";
            this.buttonTransactionScopr.Size = new System.Drawing.Size(167, 23);
            this.buttonTransactionScopr.TabIndex = 2;
            this.buttonTransactionScopr.Text = "Transaction Scope";
            this.buttonTransactionScopr.UseVisualStyleBackColor = true;
            this.buttonTransactionScopr.Click += new System.EventHandler(this.buttonTransactionScopr_Click);
            // 
            // buttonTransactionGR
            // 
            this.buttonTransactionGR.Location = new System.Drawing.Point(19, 101);
            this.buttonTransactionGR.Name = "buttonTransactionGR";
            this.buttonTransactionGR.Size = new System.Drawing.Size(167, 23);
            this.buttonTransactionGR.TabIndex = 3;
            this.buttonTransactionGR.Text = "Transaction Generic Repositoty";
            this.buttonTransactionGR.UseVisualStyleBackColor = true;
            this.buttonTransactionGR.Click += new System.EventHandler(this.buttonTransactionGR_Click);
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(844, 26);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(304, 20);
            this.textBoxRegex.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1049, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "regex EMAIL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTransactionFail;
        private System.Windows.Forms.Button buttonTransactionEF;
        private System.Windows.Forms.Button buttonTransactionScopr;
        private System.Windows.Forms.Button buttonTransactionGR;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Button button2;
    }
}

