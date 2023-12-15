namespace pad_project
{
    partial class FormReportMenu
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPurchasingHistory = new System.Windows.Forms.Button();
            this.buttonAllVendor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(208, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonPurchasingHistory
            // 
            this.buttonPurchasingHistory.Location = new System.Drawing.Point(51, 93);
            this.buttonPurchasingHistory.Name = "buttonPurchasingHistory";
            this.buttonPurchasingHistory.Size = new System.Drawing.Size(168, 23);
            this.buttonPurchasingHistory.TabIndex = 5;
            this.buttonPurchasingHistory.Text = "Purchasing History";
            this.buttonPurchasingHistory.UseVisualStyleBackColor = true;
            this.buttonPurchasingHistory.Click += new System.EventHandler(this.buttonPurchasingHistory_Click);
            // 
            // buttonAllVendor
            // 
            this.buttonAllVendor.Location = new System.Drawing.Point(51, 50);
            this.buttonAllVendor.Name = "buttonAllVendor";
            this.buttonAllVendor.Size = new System.Drawing.Size(168, 23);
            this.buttonAllVendor.TabIndex = 4;
            this.buttonAllVendor.Text = "VendorData";
            this.buttonAllVendor.UseVisualStyleBackColor = true;
            this.buttonAllVendor.Click += new System.EventHandler(this.buttonAllVendor_Click);
            // 
            // FormReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 218);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPurchasingHistory);
            this.Controls.Add(this.buttonAllVendor);
            this.Name = "FormReportMenu";
            this.Text = "FormReportMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPurchasingHistory;
        private System.Windows.Forms.Button buttonAllVendor;
    }
}